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

        MOV     ADCCON1,#8Ch   ; power up ADC
        MOV     ADCCON2,#00h   ; select channel to convert

; PERFORM REPEATED SINGLE CONVERSIONS...

AGAIN:  CPL     LED             ; turn the LED off
        MOV     A,#03FH		; Delay length
		CALL    DELAY           ; delay 200ms

        SETB    SCONV           ; innitiate single ADC conversion
        		        ; ADC ISR is called upon completion
		JNB     ADCI,$
		CLR		ADCI

		MOV     A,ADCDATAH
		CALL    SENDVAL
		MOV     A,ADCDATAL
		CALL    SENDVAL
	
        MOV      DPTR, #SATIR 
        CALL     SENDSTRING   

		JMP     AGAIN           ; repeat

;____________________________________________________________________
                                                         ; SUBROUTINE
DELAY:				; Delays by 10ms * A
					; 25mSec based on 2.09MHZ 
					; Core Clock 
					; i.e. default ADuC842 Clock

		MOV		R1,A	; Acc holds delay variable (1 clock)
 DLY0:	MOV		R2,#01Bh	; Set up delay loop0 (2 clocks)
 DLY1:	MOV		R3,#0FFh	; Set up delay loop1 (2 clocks)
		DJNZ	R3,$		; Dec R3 & Jump here until R3 is 0 (3 clocks)
		DJNZ	R2,DLY1         ; Dec R2 & Jump DLY1 until R2 is 0 (3 clocks)
		DJNZ	R1,DLY0		; Dec R1 & Jump DLY0 until R1 is 0 (3 clocks)
		RET			; Return from subroutine


;____________________________________________________________________
SATIR:    DB 10,13,0
	
$INCLUDE(UARTIO.ASM)		
END
