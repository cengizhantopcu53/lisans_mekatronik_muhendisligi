; Yazar            : Cengizhan Topcu
; Gun              : 17 Kasim 2020                    
; Dosya ismi       : buton_led.a51 
; Donanim          : AduC842
; Aciklama         : Buton kontrollu Led ornegi

$MOD51                                 ; 8051 ON TANIMLAMASI YAPILDI

LED     EQU     P3.5                   ; lED TANIMLAMASI YAPILDI
BUTTON  EQU     P0.0                   ; BUTTON TANIMLAMASI YAPILDI
	
CSEG
	ORG 0000H 
		
	 MOV 	P0,#0FFH                   ; P0 GIRIS OLARAK TANIMLANDI
	 
CONTROL:
     MOV    C,BUTTON                   ; BUTTON BASILDIYSA CARRY BITINE YUKLE
	 JC     LED_ON                     ; LEDE BASILMISSA LED_ON ETIKETINE GIDER, BASILMADIYSA ALT SATIRDAN DEVAM EDER
	 CLR    LED                        ; LEDI SONDURUR
	 JMP    CONTROL
	 
LED_ON:
     SETB   LED                        ; LED YANAR
	 JMP    CONTROL                    ; CONTROLL DONGUSUNE GERI DON
	
END 
	 