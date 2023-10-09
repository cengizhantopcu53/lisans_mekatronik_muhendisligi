; Yazar            : Cengizhan Topcu
; Gun              : 06 Ocak 2021                   
; Dosya ismi       : int_ex.asm
; Donanim          : AduC842
; Aciklama         : P3.2 pininde olusan harici kesme INT0 ile LED'i 1 saniye yakan program kodu

$MOD51                                ; 8051 ON TANIMLAMASI YAPILDI
	
LED     EQU     P3.4                  ; LED P3.4 PININE BAGLI 
PLLCON  DATA    0D7H                  ; PLL CONTROL REGISTER ADRESI
;___________________________________________________________________________
                                                                ;ANA PROGRAM
CSEG
	 ORG 0000H 
	    LJMP   MAIN                   ; MAIN KOD
	 ORG 0003H 
	    LJMP   ISR_ITO                ; KESME KODU        
	 ORG 0060H 
		
MAIN:
	    MOV    PLLCON,#00H            ; ISLEMCI 16.777 MHz AYARLANDI
	    MOV    IE,#81H                ; KESME KONFIGÜRASYONLARI AYARLANDI
		SETB   ITO            	      ; KESME PINI AKTIF EDILDI
	    MOV    A,#100                 
		
HERE:   SJMP   HERE                   ; BOS DA BEKLIYOR

;____________________________________________________________________________
                                                                 ;SUBROUTINES	
																 
ISR_ITO:
        CLR    LED 

		MOV    R1,#A                  ; 1s BEKLEMEYI URETECEK DEGERLERIN YUKLENMESI
DLY0:   MOV    R2,#0DBH
DLY1:   MOV    R3,#0FFH
        DJNZ   R3,$                   ; IC ICE DONGULERIN OLUSTURULMASI
		DJNZ   R1,DLY1
		DJNZ   R2,DLY0
		
		SETB   LED
		
		RETI
;___________________________________________________________________________________	
END 
	
	
	