$MOD51
T3FD    EQU 0x9D;
T3CON   EQU 0x9E;
PLLCON	EQU 0XD7;
CSEG
ORG	00H
; Kodlarin baslangici
        JMP     MAIN            ; jump to main program
ORG 0100h
MAIN:	; Set up UART
		MOV		PLLCON,#03H; 0	 1	 2	 3	 4	 5
		MOV		T3CON,#83H ;86	85	84	83	82	81
		MOV		T3FD,#2DH;9600 Baudrate i�in
		MOV		SCON,#52H
;------------------------------------- 
AGAIN:
		MOV     DPTR, #TITLE 	; Ekrana		ASCII	HEX
		CALL	SENDSTRING 		;              ______________    yazar ve alt satira ge�er.
;------------------------------------- 
		MOV		A,#00H			;Ak�m�lat�re ilk deger y�kleniyor 
;-------------------------------------
DEVAM:
		JNB		TI,$
		CLR		TI
		MOV		SBUF,A			;AK�M�LAT�RDEKI deger ASCII olarak g�nderilir.
;-------------------------------------
		MOV     DPTR, #SATIR1 
        CALL    SENDSTRING      ;1 TAB bosluk verilir      
;-------------------------------------	
		CALL    SENDVAL			;AK�M�LAT�RDEKI deger HEX. olarak g�nderilir.
		CALL    DELAY    
;-------------------------------------
        MOV      DPTR, #SATIR2 
        CALL     SENDSTRING     ;Satir sonu yapilip alt satira ge�ilir
;-------------------------------------		
		INC		A
		CPL		P2.4
;--------------------------------------	
		CJNE	A,#0FFH,DEVAM
;--------------------------------------  		
		JMP     AGAIN           ; repeat
;-------------------------------------- 
;____________________________________________________________________
                                                         ; SUBROUTINE
DELAY:				

		MOV		R1,#06FH		; Acc holds delay variable (1 clock)
 DLY0:	MOV		R2,#02Bh		; Set up delay loop0 (2 clocks)
 DLY1:	MOV		R3,#0FFh		; Set up delay loop1 (2 clocks)
		DJNZ	R3,$			; Dec R3 & Jump here until R3 is 0 (3 clocks)
		DJNZ	R2,DLY1         ; Dec R2 & Jump DLY1 until R2 is 0 (3 clocks)
		DJNZ	R1,DLY0			; Dec R1 & Jump DLY0 until R1 is 0 (3 clocks)
		RET						; Return from subroutine
;____________________________________________________________________
TITLE:    	DB  12,13,'ASCII',9,'HEX',10,13		; Ekrani temizleyip     ASCII	HEX
			DB '______________',10,13,0	    	;                      _____________    yazip alt satira ge�mek i�in.
				   
SATIR1:  	DB 9,0				;1 TAB bosluk vermek i�in
SATIR2: 	DB 10,13,0			;Satir sonu yapilip alt satira ge�mk i�in
;-----------------------------------------------------------------------------------------------
;9 Bir defa TAB yapar, 10 Satir sonu/yeni satir yapar, 12 Ekrani temizler,  13 Satir basi yapar
;-----------------------------------------------------------------------------------------------
$INCLUDE(UARTIO.ASM)		
END

