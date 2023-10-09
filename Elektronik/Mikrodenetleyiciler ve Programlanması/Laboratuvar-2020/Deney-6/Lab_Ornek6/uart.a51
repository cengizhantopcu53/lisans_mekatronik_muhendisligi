; Yazar            : Cengizhan Topcu
; Gun              : 27	 Aralik 2020                    
; Dosya ismi       : uart.asm
; Donanim          : AduC842
; Aciklama         : "ASM" ifadesini UART haberlesmesiyle gönderme kodu

$MOD51                                ; 8051 ON TANIMLAMASI YAPILDI
	
PLLCON  DATA    0D7H                  ; PLL CONTROL REGISTER ADRESI
T3CON   DATA    0AFH                  ; T3CON REGISTER ADRESI
T3FD    DATA    0B1H                  ; T3FD REGISTER ADRESI
;___________________________________________________________________________
                                                                ;ANA PROGRAM
CSEG
	 ORG 0000H 
	    MOV    PLLCON,#00H            ; ISLEMCI 16.777 MHz AYARLANDI 
	    MOV    T3CON,#86H             ; TIMER 3, 9600 BAUD-RATE 
		MOV    T3FD,#2DH              
		MOV    SCON,#52H              ; 9 BIT UART, REN VE TI IZINLERI
		
MAIN:
	    MOV    A,#41H                 ; A HARFI GONDERILIYOR
		ACALL  SEND            	      ; GONDERME ISLEMI
	    MOV    A,#53H                 ; S HARFI GONDERILIYOR
		ACALL  SEND            	      ; GONDERME ISLEMI
	    MOV    A,#4DH                 ; M HARFI GONDERILIYOR
		ACALL  SEND            	      ; GONDERME ISLEMI
		SJMP   MAIN                   ; ISLEMIN TEKRARLANMASI SAGLANDI
;____________________________________________________________________________
                                                                 ;SUBROUTINES	
SEND:
        JNB   TI,$                    ; GONDERME ISLEMININ BITMESINI BEKLE
		CLR   TI                      ; KESME BAYRAGININ TEMIZLENMESI 
		MOV   SBUF,A                  ; VERININ SBUF'DAN GONDERILMESI
		ACALL DELAY                   ; 10ms BEKLEMENIN OLUSTURULMASI
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
	