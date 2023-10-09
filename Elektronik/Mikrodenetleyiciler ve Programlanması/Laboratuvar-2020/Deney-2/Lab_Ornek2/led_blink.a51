; Yazar            : Cengizhan Topcu
; Gun              : 25 Kasim 2020                    
; Dosya ismi       : led_blink.asm
; Donanim          : AduC842
; Aciklama         : P3.4'e bagli 100 ms'lik LED blink uygulamasi 

$MOD51                                 ; 8051 ON TANIMLAMASI YAPILDI
	
LED     EQU     P3.4                   ; P3.4 LED DEGISKENI
PLLCON  EQU     0DFH                   ; PLL CONTROL REGISTER ADRESI
	
CSEG
	ORG 0000H 
		
        MOV    PLLCON,#00H             ; ISLEMCI 2.097 MHz AYARLANDI
	    MOV    A,#5                    ; A SABIT DEGER ATAMASI
	
BLINK: 
        CPL    LED                     ; LED TOOGLE ISLEMI
	    CALL   DELAY                   ; YAZILIMSAL BEKLEME
	    JMP    BLINK                   ; ISLEMIN TEKRARLANMASI
	 
DELAY:
        MOV    R1,A                    ; A DEGERI R1'E ALINDI
	 
DLY0:   MOV    R2,#01CH                ; LOOP1 BEKLEME DEGERI
DLY1:   MOV    R3,#0F8H                ; LOOP2 BEKLEME DEGERI
        DJNZ   R3,$ 
		DJNZ   R2,DLY1
		DJNZ   R1,DLY0
		RET
		
END
	 