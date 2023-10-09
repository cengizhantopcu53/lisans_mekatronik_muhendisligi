; Yazar            : Cengizhan Topcu
; Gun              : 15 Aralik 2020                    
; Dosya ismi       : timer.asm
; Donanim          : AduC842
; Aciklama         : P3.4 pininden Timer 0 Mod 2 ile 5KHz freakansina sahip %50 doluluk oraniyla 
;                    kare dalga uretimi

$MOD51                                ; 8051 ON TANIMLAMASI YAPILDI
	
LED     EQU     P3.4                  ; P3.4 LED DEGISKENI
PLLCON  DATA    0D7H                  ; PLL CONTROL REGISTER ADRESI
	
;___________________________________________________________________________________   
                                                                        ;ANA PROGRAM
CSEG
	    ORG 0000H 
	
	    MOV    PLLCON,#03H            ; ISLEMCI 2.097 MHz AYARLANDI 
	    MOV    TMOD,#02               ; TIMER 1 VE MODE 1 SECILDI
		MOV    TH0,#42H               ; TH0 A HESAPLANAN DEGERIN YÜKLENMESI
	
HERE:
		CPL    LED                    ; TOGGLE ISLEMI >> 1 osc_clock
		ACALL  DELAY                  ; TIMER BASLATILMASI >> 2 osc_clock
		SJMP   HERE                   ; SONSUZ DONGUNUN YAPILMASI >> 3 osc_clock
;___________________________________________________________________________________
		                                                                ;SUBROUTINES
DELAY:
        SETB   TR0                    ; TIMER 0 IN BASLATILMASI >> 2 osc_clock
   
AGAIN:
        JNB    TF0,AGAIN              ; TF0 FLAG TAKIBI >> 4 osc_clock  
        CLR    TR0                    ; TIMER 0 FLAG TEMIZLENMESI >> 2 osc_clock       
        CLR    TF0                    ; TIMER 0 FLAG TEMIZLENMESI >> 2 osc_clock  
        RET                           ; >> 4 osc_clock 
;___________________________________________________________________________________	
END
	