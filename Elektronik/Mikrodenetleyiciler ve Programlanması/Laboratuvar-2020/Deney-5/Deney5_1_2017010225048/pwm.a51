; Yazar            : Cengizhan Topcu
; Gun              : 23 Aralik 2020                    
; Dosya ismi       : pwm.asm
; Donanim          : AduC842
; Aciklama         : P2.7 pin cikisindan 25 KHz ve %75 doluluk oraniyla pwm uretilmesi

$MOD51                                ; 8051 ON TANIMLAMASI YAPILDI
	
PLLCON  DATA    0D7H                  ; PLL CONTROL REGISTER ADRESI

PWMCON  DATA    0AEH                  ; PWM CONTROL REGISTER ADRESI
CFG842  DATA    0AFH                  ; ADuC842 CONFIGURATION SFR REGISTER
PWM0L   DATA    0B1H                  ; PWM DATA REGISTER
PWM0H   DATA    0B2H                  ; PWM DATA REGISTER
PWM1L   DATA    0B3H                  ; PWM DATA REGISTER
PWM1H   DATA    0B4H                  ; PWM DATA REGISTER
	
CSEG
	    ORG 0000H 
	
	    MOV    PLLCON,#00H            ; ISLEMCI 16.777 MHz AYARLANDI 
		
	    MOV    ACC,CFG842             ; CFG842 DEGERI ACC YE YOLLANDI
		CLR    ACC.6                  ; 6. BIT CLR YAPILDI
		MOV    CFG842,ACC             ; ACC DEGERI CFG842 YE YAZILDI
		
	    MOV    PWM1H,#02H             ; PWM SINYAL FREKANSININ 1 KHz AYARLANMASI
		MOV    PWM1L,#9FH             	
		
	    MOV    PWM0H,#01H             ; PWM SINYALININ DOLULUK ORANIN %50 AYARLANMASI
		MOV    PWM0L,#0F7H             
		
		MOV    PWMCON,#93H            ; PWM MODE:1 KULLANILDI

BASLA:
        SJMP   BASLA
		
END
	
	