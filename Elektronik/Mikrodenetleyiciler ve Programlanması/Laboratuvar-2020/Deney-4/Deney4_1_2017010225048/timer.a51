; Yazar            : Cengizhan Topcu
; Gun              : 15 Aralik 2020                    
; Dosya ismi       : timer.asm
; Donanim          : AduC842
; Aciklama         : P3.4 pininden Timer 1 Mod 2 ile 5KHz freakansina sahip %50 doluluk oraniyla 
;                    kare dalga uretimi

$MOD51                                ; 8051 ON TANIMLAMASI YAPILDI
	
LED     EQU     P3.4                  ; P3.4 LED DEGISKENI
PLLCON  DATA    0D7H                  ; PLL CONTROL REGISTER ADRESI
	
;___________________________________________________________________________________   
                                                                        ;ANA PROGRAM
CSEG
	    ORG 0000H 
	
	    MOV    PLLCON,#00H            ; ISLEMCI 16.777 MHz AYARLANDI 
	    MOV    TMOD,#20               ; TIMER 1 VE MODE 2 SECILDI
		MOV    TH1,#6CH               ; TH1 A HESAPLANAN DEGERIN YÜKLENMESI
	
HERE:
		CPL    LED                    ; TOGGLE ISLEMI >> 2 osc_clock
		ACALL  DELAY                  ; TIMER BASLATILMASI >> 3 osc_clock
		SJMP   HERE                   ; SONSUZ DONGUNUN YAPILMASI >> 3 osc_clock
;___________________________________________________________________________________
		                                                                ;SUBROUTINES
DELAY:
        SETB   TR1                    ; TIMER 1 IN BASLATILMASI >> 2 osc_clock
   
AGAIN:
        JNB    TF0,AGAIN              ; TF0 FLAG TAKIBI >> 4 osc_clock  
        CLR    TR1                    ; TIMER 1 FLAG TEMIZLENMESI >> 2 osc_clock       
        CLR    TF1                    ; TIMER 1 FLAG TEMIZLENMESI >> 2 osc_clock  
        RET                           ; >> 4 osc_clock 
;___________________________________________________________________________________	
END
	
	