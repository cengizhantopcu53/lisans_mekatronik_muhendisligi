$MOD51

SCONV 		EQU 0DCH;
ADCI 		EQU 0DFH;	

ADCCON1   	EQU 0xEF;
ADCCON2   	EQU 0xD8;
ADCDATAL  	EQU 0xD9;
ADCDATAH  	EQU 0xDA;	
	
T3FD      	EQU 0x9D;
T3CON     	EQU 0x9E;

EADC      	EQU 0xAE;

LED     	EQU     P2.4            ; P3.4 drives red LED on eval board

;____________________________________________________________________
                                                  ; BEGINNING OF CODE
CSEG

ORG 0000h

        JMP     MAIN            ; jump to main program
;____________________________________________________________________
            

;====================================================================
                                                       ; MAIN PROGRAM
ORG 004Bh

MAIN:
	
; Set up UART
		MOV	T3CON,#083H
		MOV	T3FD,#02DH
		MOV SCON,#52h

; PRECONFIGURE...
        MOV      DPTR, #TITLE 
		CALL	SENDSTRING
AGAIN:
        MOV     ADCCON1,#8Ch   ; power up ADC
        MOV     ADCCON2,#00h  ; select channel 0 to convert

; PERFORM REPEATED SINGLE CONVERSIONS...

		CPL     LED             ; turn the LED off
   
		CALL    DELAY           ; delay 200ms

        SETB    SCONV           ; innitiate single ADC0 conversion
								; ADC ISR is called upon completion
		JNB     ADCI,$
		CLR		ADCI

		MOV     A,ADCDATAH
		CALL    SENDVAL
		MOV     A,ADCDATAL
		CALL    SENDVAL
	
        MOV      DPTR, #SATIR1 
        CALL     SENDSTRING   
;________________________________________________________________________
AGAIN2: CPL     LED             ; turn the LED off
  
		MOV     ADCCON1,#8Ch   	; power up ADC
        MOV     ADCCON2,#01h   	; select channel 1 to convert
        SETB    SCONV           ; innitiate single ADC1 conversion
								; ADC ISR is called upon completion
		JNB     ADCI,$
		CLR		ADCI

		MOV     A,ADCDATAH
		CALL    SENDVAL
		MOV     A,ADCDATAL
		CALL    SENDVAL
	
        MOV      DPTR, #SATIR2 
        CALL     SENDSTRING   
		CALL    DELAY           ; delay 200ms
		JMP     AGAIN           ; repeat

;____________________________________________________________________
                                                         ; SUBROUTINE
DELAY:							; Delays by 10ms * A
								; 25mSec based on 2.09MHZ 
								; Core Clock 
								; i.e. default ADuC842 Clock

		MOV		R1,#6Fh			; Acc holds delay variable (1 clock)
 DLY0:	MOV		R2,#01Bh		; Set up delay loop0 (2 clocks)
 DLY1:	MOV		R3,#0FFh		; Set up delay loop1 (2 clocks)
		DJNZ	R3,$			; Dec R3 & Jump here until R3 is 0 (3 clocks)
		DJNZ	R2,DLY1         ; Dec R2 & Jump DLY1 until R2 is 0 (3 clocks)
		DJNZ	R1,DLY0			; Dec R1 & Jump DLY0 until R1 is 0 (3 clocks)
		RET						; Return from subroutine


;____________________________________________________________________
SATIR1:  	DB 9,0
SATIR2: 	DB 9,10,13,0
TITLE:    	DB 'ADC0',9,'ADC1',10,13
			DB '____________',10,10,13,0
		

	
$INCLUDE(UARTIO.ASM)		
END
