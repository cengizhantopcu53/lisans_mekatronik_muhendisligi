;Bu program servo motorlarin istedigi açiya gitmesi 
;için gerekli degerleri gösterir.
;
;              90 derece / 0 derece
;                          ^
;   135/-45 derece^       ^ +45 / +45 derece
;                   \      l       /
;                     \    l     /
;                       \  l   /
;        180 derece\l /          0 derece
; ----------<---------------------------->----------- 
;        -90 derece                     +90 derece
;
$MOD51
	
PWM0L EQU 0xB1;
PWM0H EQU 0xB2;
PWM1L EQU 0xB3;
PWM1H EQU 0xB4;
PWMCON EQU 0xAE;

CSEG
	
ORG 0H
 
HERE:

		MOV R0,#0DCH ;     25	 Servo  0 / 90 dereceye gider.
		MOV R1,#05H  ;     06
		LCALL PWM 

; JMP	HERE
 
		MOV R0,#1AH  ;     19    Servo +45 / +45 dereceye gider.
		MOV R1,#04H  ;     04
		LCALL PWM 

; JMP	HERE

		MOV R0,#58H   ;    0C    Servo +90 / 0 dereceye gider.
		MOV R1,#02H   ;    02
		LCALL PWM 
  
; JMP	HERE    

		MOV R0,#9EH   ;    31    Servo 135 / -45 dereceye gider.
		MOV R1,#07H   ;    08
		LCALL PWM 
   
; JMP	HERE

		MOV R0,#60H   ;    3D    Servo 180 / -90 dereceye gider.
		MOV R1,#09H   ;    0A
		LCALL PWM 
 
; JMP	HERE 
PWM:
    	MOV PWM0L, R0
		MOV PWM0H, R1
		MOV PWM1L, #0EAH
		MOV PWM1H, #51H
		MOV PWMCON,#1BH
		LCALL DELAY1_66

RET

DELAY1_66:
		MOV R4, #125
DLY01: 	MOV R5, #030H
DLY02: 	MOV R6 ,#30H
		DJNZ R6,$
		DJNZ R5, DLY02
		DJNZ R4, DLY01
		MOV PWMCON, #0BH
RET

END