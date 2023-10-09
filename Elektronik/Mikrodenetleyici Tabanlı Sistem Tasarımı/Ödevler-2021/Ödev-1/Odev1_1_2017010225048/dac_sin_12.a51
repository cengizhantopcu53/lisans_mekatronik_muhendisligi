; Yazar            : Cengizhan Topcu-2017010225048
; Gun              : 01 Nisan 2021                  
; Dosya ismi       : dac_sin_12.asm
; Donanim          : AduC842
; Aciklama         : 0V-3V arasinda 8kHz frekansinda 1000H adresinden itibaren 12kHz’de örneklenmis program

;-----------------------------------------------------------------------------------------------------------
$MOD51
     PLLCON     DATA  0D7H
     ADCCON1   	EQU   0xEF
     DACCON		EQU	  0xFD
     DAC0L	  	EQU   0xF9
     DAC0H	  	EQU   0xFA
;-----------------------------------------------------------------------------------------------------------
     CSEG
     ORG	00H
     JMP     MAIN            
;-----------------------------------------------------------------------------------------------------------
ORG 0100h
	MAIN:
	    MOV     PLLCON,#00H         ;16,78 MHz olarak ayarlandi
		MOV		ADCCON1,#80H
		MOV		DACCON,#2DH
		MOV		TMOD,#01H           ;Timer0 ve Mod 1 olarak ayarlandi
		MOV		TCON,#00H
		MOV		DPTR,#SINTABLO	    ;DPTR=1000H
		MOV		R0,#00H			    ;R0 baslangiç degeri (N=0) 
;-----------------------------------------------------------------------------------------------------------
	DACYAZ:	
		MOV		A,R0                
		MOVC	A,@A+DPTR		    ;TABLODAN H DEGERI AL
		MOV		R1,A  
		
		INC		R0				    ;N=N+1
		MOV		A,R0                
		MOVC	A,@A+DPTR		    ;TABLODAN L DEGERI AL
		MOV		R2,A
		
		MOV		DAC0H,R1            
		MOV		DAC0L,R2
;-----------------------------------------------------------------------------------------------------------		
		ACALL   DELAY
;-----------------------------------------------------------------------------------------------------------		
		INC		R0				    ;N=N+2
		CJNE    R0,#24,DACYAZ       ;N=!24 ETIKETE ATLA
		ANL		00H,#00H            ;N==24 N=0
		JMP		DACYAZ              ;TEKRARLA
;-----------------------------------------------------------------------------------------------------------
    DELAY:
        MOV     TH0,#0FFH           ;
		MOV     TL0,#07DH           ;
		SETB    TR0                 ;TIMER0 SET EDILDI
		JNB     TF0,$               ;TIMER0 DOLANA KADAR BEKLE
	    CLR     TR0                 ;TRO BAYRAGI TEMIZLE
		CLR     TF0                 ;TFO BAYRAGI TEMIZLE
		RET
;-----------------------------------------------------------------------------------------------------------
ORG 1000H
	SINTABLO:
		DB		04H,0CDH		    ;1.5  VOLT
		DB		07H,33H			    ;2.25 VOLT
		DB		08H,0F4H			;2.8  VOLT
		DB		09H,99H			    ;3    VOLT
		DB		08H,0F4H		    ;2.8  V0LT
		DB		07H,33H			    ;2.25 VOLT
		DB		04H,0CDH			;1.5  VOLT
		DB		02H,66H			    ;0.75 VOLT
		DB		00H,0A5H		    ;0.2  V0LT
		DB		00H,00H			    ;0    VOLT
		DB		00H,0A5H			;0.2  VOLT
		DB		02H,66H			    ;0.75 VOLT
;-----------------------------------------------------------------------------------------------------------			
		END
			
			