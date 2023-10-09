; Yazar            : Cengizhan Topcu
; Gun              : 07 Ocak 2021                   
; Dosya ismi       : serial.asm
; Donanim          : AduC842
; Aciklama         : P3.5'den 48 KHz frekansinda kare dalgayi Timer 0 mod 1 ile üretilirken ayni zamanda
                   ; gelen veri "8" ise LED'i sonduren, "4" ise LED'i yakan ve belitilenler haricinde "FF" veren program

$MOD51                                ; 8051 ON TANIMLAMASI YAPILDI
	 
PLLCON  DATA    0D7H                  ; PLL CONTROL REGISTER ADRESI
LED     EQU     P3.5                  ; LED P3.5 PININE BAGLI
T3CON   DATA    09EH                  ; T3CON REGISTER ADRESI
T3FD    DATA    09DH                  ; T3FD REGISTER ADRESI
;___________________________________________________________________________
                                                                ;ANA PROGRAM
CSEG
	 ORG 0000H 
	    LJMP   MAIN                   ; MAIN KOD
	 ORG 0023H 
	    LJMP   SERIAL                 ; SERIAL KESME KODU 
     ORG 000BH  
        LJMP   TIMER                  ; TIMER KESME KODU	 
	 ORG 0060H 
		
MAIN:
	    MOV    PLLCON,#00H            ; ISLEMCI 16.777 MHz AYARLANDI
	    MOV    TMOD,#01               ; TIMER 0 VE MODE 1 SECILDI
		MOV    TL0,#018H              ; TL0'A HESAPLANAN DEGERIN YUKLENMESI
		MOV    TH0,#0FFH              ; TH0'A HESAPLANAN DEGERIN YUKLENMESI	
		
		MOV    T3CON,#86H             ; TIMER 3, 9600 BAUD-RATE 
		MOV    T3FD,#2DH 
		MOV    SCON,#50H              ; 8 BIT UART, REN VE TI IZINLERI
	    MOV    IE,#92H                ; KESME KONFIGÜRASYONLARI AYARLANDI
		MOV    IP,#01H
		
		SETB   TR0                    ; TIMER 0 IN BASLATILMASI
		
HERE:   SJMP   HERE                   ; BOS DA BEKLIYOR >> 3 osc_clock

;____________________________________________________________________________
                                                                 ;SUBROUTINES	
																 
SERIAL: JNB    RI,SERIAL              ; ALMA ISLEMININ BITTIGI KONTROL EDILIYOR >> 4 osc_clock
        CLR    RI                     ; ALMA BAYRAGI TEMIZLENDI >> 2 osc_clock
		MOV    A,SBUF                 ; SBUF DEGERI A'YA YUKLENDI >> 2 osc_clock
		ACALL  DELAY                  ; BEKLEME ADIMI >> 3 osc_clock
		MOV    R1,A                   ; >> 2 osc_clock
		SUBB   A,#38H                 ; ALINAN BILGININ HANGI ARALIKTA OLDUGUNUN KONTROL EDILMESI >> 2 osc_clock
		JNC    ANSWER                 ; GELEN BILGI 38H'DEN BUYUKSE ANSWER'E GIT >> 3 osc_clock
		SJMP   CONTROL                ; KUCUKSE CONTROL'E GIT >> 3 osc_clock
		
CONTROL: CLR    C                     ; ELDE BITI TEMIZLENIR >> 1 osc_clock
        MOV    A,R1                   ; A'YA GELEN VERI R1 UZERINDEN YUKLENIR >> 2 osc_clock
		SUBB   A,#34H                 ; GELEN VERI 34H'DEN BÜYÜKSE DEVAM ET >> 2 osc_clock
		JC     ANSWER                 ; KUCUKSE ANSWER'E GIT >> 3 osc_clock
		CLR    C                      ; ELDE BITI TEMIZLENIR >> 1 osc_clock
		MOV    A,R1                   ; A'YA GELEN VERI R1 UZERINDEN YUKLENIR >> 2 osc_clock
		                              ; BU ADIMA GELINDIYSE GELEN VERI 34H ILE 38H ARASINDADIR
		              
        SUBB   A,#38H                 ; >> 2 osc_clock
        JNC    LED_OFF                ; ELDE OLUSURSA GELEN VERI 38H'DAN KÜÇÜKTÜR OLUSMASSA 38H'DIR >> 3 osc_clock
		
		CLR    C                      ; ELDE BITI TEMIZLENIR >> 1 osc_clock
		MOV    A,R1                   ; A'YA GELEN VERI R1 UZERINDEN YUKLENIR >> 2 osc_clock
		SUBB   A,#37H                 ; >> 2 osc_clock
		JNC    ANSWER                 ; ELDE OLUSURSA GELEN VERI 37H'DAN KÜÇÜKTÜR OLUSMASSA 37H'DIR >> 3 osc_clock
		CLR    C                      ; ELDE BITI TEMIZLENIR >> 1 osc_clock
		MOV    A,R1                   ; A'YA GELEN VERI R1 UZERINDEN YUKLENIR >> 2 osc_clock
		SUBB   A,#36H                 ; >> 2 osc_clock 
		JNC    ANSWER                 ; ELDE OLUSURSA GELEN VERI 36H'DAN KÜÇÜKTÜR OLUSMASSA 36H'DIR >> 3 osc_clock
		CLR    C                      ; ELDE BITI TEMIZLENIR >> 1 osc_clock
		MOV    A,R1                   ; A'YA GELEN VERI R1 UZERINDEN YUKLENIR >> 2 osc_clock
		SUBB   A,#35H                 ; >> 2 osc_clock 
		JC     LED_ON                 ; ELDE OLUSURSA GELEN VERI 34H'DIR OLUSMASSA 35H'DIR >> 3 osc_clock 
        SJMP   ANSWER                 ; >> 4 osc_clock
		RETI                          ; GELINEN KESMEYE GERI DON >> 4 osc_clock
		
LED_OFF:CLR    C                      ; ELDE BITI TEMIZLENIR >> 1 osc_clock
        SETB   LED                    ; GELEN VERI 38H OLDUGU ICIN LED'I SONDUR >> 2 osc_clock
        RETI                          ; GELINEN KESMEYE GERI DON >> 4 osc_clock	 	
		
LED_ON: CLR    LED                    ; GELEN VERI 34H OLDUGU ICIN LED'I YAK >> 2 osc_clock
        RETI                          ; GELINEN KESMEYE GERI DON >> 4 osc_clock

ANSWER: CLR    C                      ; ELDE BITI TEMIZLENIR >> 1 osc_clock
        MOV    A,#0FFH                ; GELEN VERI GECERSIZ ARALIKTA OLDUGU ICIN FFH DEGERI GONDER >> 3 osc_clock
		MOV    SBUF,A                 ; GONDERILECEK VERI SBUF'A ATANIR >> 2 osc_clock
        ACALL  DELAY                  ; BEKLEME ADIMI >> 3 osc_clock
        JNB    TI,$                   ; GONDERME ISLEMININ TAMAMLANMASININ KONTROL EDILMESI >> 4 osc_clock
        CLR    TI                     ; GONDERME BAYRAGININ TEMIZLENMESI >> 2 osc_clock
        RETI		                  ; GELINEN KESMEYE GERI DON >> 4 osc_clock
		
TIMER:  
        CPL    LED                    ; TOGGLE ISLEMI >> 2 osc_clock

DELAY:  MOV    R1,#1                  ; 10ms BEKLEMEYI URETECEK DEGERLERIN YUKLENMESI >> 1 osc_clock
DLY0:   MOV    R2,#0DBH               ; >> 2 osc_clock
DLY1:   MOV    R3,#0FFH               ; >> 2 osc_clock
        DJNZ   R3,$                   ; IC ICE DONGULERIN OLUSTURULMASI >> 3 osc_clock
		DJNZ   R1,DLY1                ; >> 3 osc_clock
		DJNZ   R2,DLY0                ; >> 3 osc_clock
		RETI                          ; >> 4 osc_clock
;___________________________________________________________________________________	
END 
	
	
	