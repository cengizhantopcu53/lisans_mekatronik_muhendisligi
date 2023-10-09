; Yazar            : Cengizhan Topcu
; Gun              : 07 Ocak 2021                   
; Dosya ismi       : serial.asm
; Donanim          : AduC842
; Aciklama         : Gelen veri "0" ise LED'i sonduren, "1" ise LED'i yakan ve belitilenler haricinde "FF" veren program

$MOD51                                ; 8051 ON TANIMLAMASI YAPILDI
	 
PLLCON  DATA    0D7H                  ; PLL CONTROL REGISTER ADRESI
LED     EQU     P3.4                  ; LED P3.4 PININE BAGLI
T3CON   DATA    09EH                  ; T3CON REGISTER ADRESI
T3FD    DATA    09DH                  ; T3FD REGISTER ADRESI
;___________________________________________________________________________
                                                                ;ANA PROGRAM
CSEG
	 ORG 0000H 
	    LJMP   MAIN                   ; MAIN KOD
	 ORG 0003H 
	    LJMP   SERIAL                 ; KESME KODU        
	 ORG 0060H 
		
MAIN:
	    MOV    PLLCON,#00H            ; ISLEMCI 16.777 MHz AYARLANDI
		MOV    T3CON,#86H             ; TIMER 3, 9600 BAUD-RATE 
		MOV    T3FD,#2DH 
		MOV    SCON,#50H              ; 8 BIT UART, REN VE TI IZINLERI
	    MOV    IE,#90H                ; KESME KONFIGÜRASYONLARI AYARLANDI
		
HERE:   SJMP   HERE                   ; BOS DA BEKLIYOR

;____________________________________________________________________________
                                                                 ;SUBROUTINES	
																 
SERIAL: JNB    RI,SERIAL              ; ALMA ISLEMININ BITTIGI KONTROL EDILIYOR
        CLR    RI                     ; ALMA BAYRAGI TEMIZLENDI
		MOV    A,SBUF                 ; SBUF DEGERI A'YA YUKLENDI
		ACALL  DELAY                  ; BEKLEME ADIMI
		MOV    R1,A                   ; 
		SUBB   A,#30H                 ; ALINAN BILGININ HANGI ARALIKTA OLDUGUNUN KONTROL EDILMESI
		JNC    CONTROL                ; GELEN BILGI 30H'DEN BUYUKSE CONTROL'E GIT
		SJMP   ANSWER                 ; KUCUKSE ANSWER'E GIT
		
CONTROL: CLR    C                      ; ELDE BITI TEMIZLENIR
        MOV    A,R1                   ; A'YA GELEN VERI R1 UZERINDEN YUKLENIR
		SUBB   A,#32H                 ; GELEN VERI 32H'DEN KUCUKSE DEVAM ET
		JNC    ANSWER                 ; BUYUKSE ANSWER'E GIT
		CLR    C                      ; ELDE BITI TEMIZLENIR
		MOV    A,R1                   ; A'YA GELEN VERI R1 UZERINDEN YUKLENIR
		                              ; BU ADIMA GELINDIYSE GELEN VERI 30H VEYA 31H'DIR
	    SUBB   A,#31H
		JNC    LED_ON                 ; ELDE OLUSURSA GELEN VERI 30H'DIR OLUSMASSA 31H'DIR.
		CLR    C                      ; ELDE BITI TEMIZLENIR
        SETB   LED                    ; GELEN VERI 30H OLDUGU ICIN LED'I SONDUR
		RETI                          ; GELINEN KESMEYE GERI DON
		
LED_ON: CLR    LED                    ; GELEN VERI 31H OLDUGU ICIN LED'I YAK
        RETI                          ; GELINEN KESMEYE GERI DON

ANSWER: CLR    C                      ; ELDE BITI TEMIZLENIR
        MOV    A,#0FFH                ; GELEN VERI GECERSIZ ARALIKTA OLDUGU ICIN FFH DEGERI GONDER
		MOV    SBUF,A                 ; GONDERILECEK VERI SBUF'A ATANIR
        ACALL  DELAY                  ; BEKLEME ADIMI 
        JNB    TI,$                   ; GONDERME ISLEMININ TAMAMLANMASININ KONTROL EDILMESI
        CLR    TI                     ; GONDERME BAYRAGININ TEMIZLENMESI
        RETI		                  ; GELINEN KESMEYE GERI DON

DELAY:  MOV    R1,#1                  ; 10ms BEKLEMEYI URETECEK DEGERLERIN YUKLENMESI
DLY0:   MOV    R2,#0DBH
DLY1:   MOV    R3,#0FFH
        DJNZ   R3,$                   ; IC ICE DONGULERIN OLUSTURULMASI
		DJNZ   R1,DLY1
		DJNZ   R2,DLY0
		RETI
;___________________________________________________________________________________	
END 
	
	