;ADC girisindeki gerilim degerini her 10ms'de bir okuyan ve okunan degerleri r4 r5 registerlerinde saklayan program .

$MOD51
	CSEG
		SCONV    EQU 0DCH
		ADCI     EQU 0DFH
		ADCCON1  EQU 0xEF
		ADCCON2  EQU 0xD8
		ADCDATAL EQU 0xD9
		ADCDATAH EQU 0xDA
			
		ORG 0000H
			AYAR:
			MOV ADCCON1 ,#8CH
			MOV ADCCON2 ,#01H
			OKU:
			SETB SCONV 
			JNB  ADCI,$ ;ADC1 flagi olusana kadar bekle , yani adc okumasinin bitmesini bekliyoruz
			CLR  ADCI   ;ADCI bitini temizledik
			MOV  R4,ADCDATAH  
			MOV  R5,ADCDATAL
			
			ANL 04H,#0FH  ; 04h adresinde r4 var
			              ; ADCDATAH registerinde hem hangi adcyi kullandigimiz bilgisi hemde adch bilgisi var biz sadece
			              ; adc bilgisini istiyoruz yani diger bilgileri istemiyoruz bu yüzden bu islemi yaptik
						  ; yani ilk 4 biti 0 ile and yapiyor ve sonuç haliyle 0 oluyor ama diger 4 biti yani son 4 biti 
						  ; F ile(1) and yapiyor ve sonuç kendisi çikiyor .

			
			;DELAY
			;.
			;.
			;.
			END 
	
			
		
			
			
			
			
	
