; Yazar            : Cengizhan Topcu
; Gun              : 17 Kasim 2020                    
; Dosya ismi       : button_led.a51 
; Donanim          : AduC842
; Aciklama         : Buton kontrollu Led ornegi

$MOD51                                 ; 8051 ON TANIMLAMASI YAPILDI

LED     EQU     P3.4                   ; lED TANIMLAMASI YAPILDI
BUTTON  EQU     P3.2                   ; BUTTON TANIMLAMASI YAPILDI
	
CSEG
	ORG 0000H 
		
	 MOV 	P3,#0FFH                   ; P3 GIRIS OLARAK TANIMLANDI
	 
CONTROL:
     MOV    C,BUTTON                   ; BUTTON BASILDIYSA CARRY BITINE YUKLE
	 JC     LED_ON                     ; BUTTON BASILMISSA LED_ON ETIKETINE GIDER, BASILMADIYSA ALT SATIRDAN DEVAM EDER
	 SETB   LED                        ; LED SONER
	 JMP    CONTROL                    ; CONTROL DONGUSUNE GERI DON
	 
LED_ON:
     CLR    LED                        ; LED YANAR
	 JMP    CONTROL                    ; CONTROL DONGUSUNE GERI DON
	
END 
	