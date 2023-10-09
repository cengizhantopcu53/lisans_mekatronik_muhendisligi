; Yazar            : Cengizhan Topcu
; Gun              : 27	 Aralik 2020                    
; Dosya ismi       : uart.asm
; Donanim          : AduC842
; Aciklama         : Timer 3 ile 9600 baudrate üreterek, aliciya A ile Z arasindaki harfleri gönderen program 

$MOD51                                ; 8051 ON TANIMLAMASI YAPILDI
	
PLLCON  DATA    0D7H                  ; PLL CONTROL REGISTER ADRESI
T3CON   DATA    09EH                  ; T3CON REGISTER ADRESI
T3FD    DATA    09DH                  ; T3FD REGISTER ADRESI
;___________________________________________________________________________
                                                                ;ANA PROGRAM
CSEG
	 ORG 0000H 
	    MOV    PLLCON,#00H            ; ISLEMCI 16.777 MHz AYARLANDI 
	    MOV    T3CON,#86H             ; TIMER 3, 9600 BAUD-RATE 
		MOV    T3FD,#2DH              
		MOV    SCON,#52H              ; 9 BIT UART, REN VE TI IZINLERI

	    MOV    A,#41H                 ; A HARFI GONDERILIYOR
	    
MAIN:
		CJNE   A,#5BH,SEND      	  ; ISLEMIN KONTROLU SAGLANDI
		SJMP   MAIN
;____________________________________________________________________________
                                                                 ;SUBROUTINES	
SEND:
        JNB   TI,$                    ; GONDERME ISLEMININ BITMESINI BEKLE
		CLR   TI                      ; KESME BAYRAGININ TEMIZLENMESI 
		MOV   SBUF,A                  ; VERININ SBUF'DAN GONDERILMESI
		ACALL DELAY                   ; 10ms BEKLEMENIN OLUSTURULMASI
		INC    A                      ; ISLEMIN TEKRARLANMASI SAGLANDI  
		SJMP   MAIN                   ; ISLEM DEVAM ETTIRILIYOR
		RET 

DELAY:                                ; 10ms BEKLEMENIN ÜRETILMESI
			
		MOV   R5,#1                   ; 10ms BEKLEMEYI URETECEK DEGERLERIN YUKLENMESI
DLY0:   MOV   R6,#01BH
DLY1:   MOV   R7,#0FFH
        DJNZ  R7,$                    ; IC ICE DONGULERIN OLUSTURULMASI
		DJNZ  R6,DLY1
		DJNZ  R5,DLY0
		RET
;___________________________________________________________________________________	
END 
	
	
	
	