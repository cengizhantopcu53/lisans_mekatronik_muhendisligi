; Yazar            : Cengizhan Topcu
; Gun              : 08 Aralik 2020                    
; Dosya ismi       : timer.asm
; Donanim          : AduC842
; Aciklama         : P3.4 pininden Timer 1 Mod 1 ile 1KHz freakansina sahip %50 doluluk oraniyla 
;                    kare dalga uretimi

$MOD51                                ; 8051 ON TANIMLAMASI YAPILDI
	
LED     EQU     P3.4                  ; P3.4 LED DEGISKENI
PLLCON  DATA    0D7H                  ; PLL CONTROL REGISTER ADRESI
	
;___________________________________________________________________________________   
                                                                        ;ANA PROGRAM
CSEG
	    ORG 0000H 
	
	    MOV    PLLCON,#00H            ; ISLEMCI 16.777 MHz AYARLANDI 
	    MOV    TMOD,#10               ; TIMER 1 VE MODE 1 SECILDI
	
HERE:
        MOV    TL1,#53H               ; TL1'A HESAPLANAN DEGERIN YUKLENMESI >> 3 osc_clock
		MOV    TH1,#0DFH              ; TH1'A HESAPLANAN DEGERIN YUKLENMESI >> 3 osc_clock
		CPL    LED                    ; TOGGLE ISLEMI >> 1 osc_clock
		ACALL  DELAY                  ; TIMER BASLATILMASI >> 2 osc_clock
		SJMP   HERE                   ; SINSUZ DONGUNUN YAPILMASI >> 3 osc_clock
;___________________________________________________________________________________
		                                                                ;SUBROUTINES
DELAY:
        SETB   TR1                    ; TIMER 1 IN BASLATILMASI >> 2 osc_clock
   
AGAIN:
        JNB    TF1,AGAIN              ; TF1 FLAG TAKIBI >> 4 osc_clock  
        CLR    TR1                    ; TIMER 1 FLAG TEMIZLENMESI >> 2 osc_clock       
        CLR    TF1                    ; TIMER 1 FLAG TEMIZLENMESI >> 2 osc_clock  
        RET                           ; >> 4 osc_clock 
;___________________________________________________________________________________	
END
	
	