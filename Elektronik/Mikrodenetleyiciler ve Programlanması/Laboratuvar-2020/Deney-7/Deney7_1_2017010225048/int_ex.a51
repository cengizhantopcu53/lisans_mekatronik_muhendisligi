; Yazar            : Cengizhan Topcu
; Gun              : 06 Ocak 2021                   
; Dosya ismi       : int_ex.asm
; Donanim          : AduC842
; Aciklama         : Timer 0 kesmesi kullanarak, P3.4 pini ile 1 ms periyodunda kare dalga üretimi

$MOD51                                ; 8051 ON TANIMLAMASI YAPILDI
	
LED     EQU     P3.4                  ; P3.4 LED DEGISKENI 
PLLCON  DATA    0D7H                  ; PLL CONTROL REGISTER ADRESI
T3CON   DATA    09EH                  ; T3CON REGISTER ADRESI
T3FD    DATA    09DH                  ; T3FD REGISTER ADRESI
;___________________________________________________________________________
                                                                ;ANA PROGRAM
CSEG
	 ORG 0000H 
	    LJMP   MAIN                   ; MAIN KOD
	 ORG 000BH 
	    LJMP   ISR_ITO                ; KESME KODU        
	 ORG 0060H 
		
MAIN:
	    MOV    PLLCON,#00H            ; ISLEMCI 16.777 MHz AYARLANDI 
	    MOV    TMOD,#01               ; TIMER 0 VE MODE 1 SECILDI
		MOV    TL0,#91H               ; TL0'A HESAPLANAN DEGERIN YUKLENMESI
		MOV    TH0,#0BEH              ; TH0'A HESAPLANAN DEGERIN YUKLENMESI	
		
	    MOV    P0,#0FFH               ; P0 GIRIS YAPILDI
		
	    MOV    IE,#82H                ; KESME KONFIGÜRASYONLARI AYARLANDI
		SETB   IT0            	      ; EXTERNAL INTERRUPT PINI AKTIF EDILDI 
		
		SETB   TR0                    ; TIMER 0 IN BASLATILMASI 
		
	    MOV    A,#100                 
		
HERE:   SJMP   HERE                   ; BOS DA BEKLIYOR >> 3 osc_clock

;____________________________________________________________________________
                                                                 ;SUBROUTINES														 
ISR_ITO:
        CPL    LED                    ; TOGGLE ISLEMI >> 2 osc_clock

		MOV    R1,A                   ; BEKLEMEYI URETECEK DEGERLERIN YUKLENMESI >> 1 osc_clock
DLY0:   MOV    R2,#0DBH               ; >> 2 osc_clock
DLY1:   MOV    R3,#0FFH               ; >> 2 osc_clock
        DJNZ   R3,$                   ; IC ICE DONGULERIN OLUSTURULMASI >> 3 osc_clock
		DJNZ   R1,DLY1                ; >> 3 osc_clock
		DJNZ   R2,DLY0                ; >> 3 osc_clock
		RETI                          ; >> 4 osc_clock
		
OKUMA: MOV A,P0                       ; >> 2 osc_clock
       MOV P2,A                       ; >> 2 osc_clock
       SJMP OKUMA                     ; >> 3 osc_clock
;___________________________________________________________________________________	
END 
	
	