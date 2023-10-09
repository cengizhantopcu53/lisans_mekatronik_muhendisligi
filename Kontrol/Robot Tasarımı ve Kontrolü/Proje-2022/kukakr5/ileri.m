syms teta_1 teta_2 teta_3 teta_4 teta_5 teta_6

% teta_1=deg2rad(teta1);
% teta_2=deg2rad(teta2);
% teta_3=deg2rad(teta3);
% teta_4=deg2rad(teta4);
% teta_5=deg2rad(teta5);
% teta_6=deg2rad(teta6);

alpha1=   0;
alpha2=   -90;
alpha3=   0;
alpha4=   -90;
alpha5=   90;
alpha6=   -90;

alpha_1=deg2rad(alpha1);
alpha_2=deg2rad(alpha2);
alpha_3=deg2rad(alpha3);
alpha_4=deg2rad(alpha4);
alpha_5=deg2rad(alpha5);
alpha_6=deg2rad(alpha6);

a_1= 0;
a_2= 75;
a_3= 355;
a_4= 90;
a_5= 0;
a_6= 0;

d_1= 331;  
d_2= 2;    
d_3= 0;
d_4= 320; %404;   
d_5= 0;
d_6= 0;

%syms teta_1  teta_2 teta_3 teta_4 teta_5 teta_6 ;

T_01=[ cos(teta_1)                      -sin(teta_1)                   0                       a_1 
       sin(teta_1)*cos(alpha_1)   cos(teta_1)*cos(alpha_1)       -sin(alpha_1)       -sin(alpha_1)*d_1  
       sin(teta_1)*sin(alpha_1)   cos(teta_1)*sin(alpha_1)        cos(alpha_1)        cos(alpha_1)*d_1  
             0                            0                       0             1                ];
         
         
T_12=[ cos(-pi/2+teta_2)                      -sin(-pi/2+teta_2)                   0                       a_2 
       sin(-pi/2+teta_2)*cos(alpha_2)   cos(-pi/2+teta_2)*cos(alpha_2)       -sin(alpha_2)       -sin(alpha_2)*d_2 
       sin(-pi/2+teta_2)*sin(alpha_2)   cos(-pi/2+teta_2)*sin(alpha_2)        cos(alpha_2)        cos(alpha_2)*d_2   
             0                            0                       0             1                ];         
         
            
T_23=[ cos(teta_3)                      -sin(teta_3)                   0                       a_3
       sin(teta_3)*cos(alpha_3)   cos(teta_3)*cos(alpha_3)       -sin(alpha_3)       -sin(alpha_3)*d_3  
       sin(teta_3)*sin(alpha_3)   cos(teta_3)*sin(alpha_3)        cos(alpha_3)        cos(alpha_3)*d_3   
             0                            0                       0             1                ];   
         
T_34=[ cos(teta_4)                      -sin(teta_4)                   0                       a_4
       sin(teta_4)*cos(alpha_4)   cos(teta_4)*cos(alpha_4)       -sin(alpha_4)       -sin(alpha_4)*d_4  
       sin(teta_4)*sin(alpha_4)   cos(teta_4)*sin(alpha_4)        cos(alpha_4)        cos(alpha_4)*d_4   
             0                            0                       0             1                ];        
         
T_45=[ cos(teta_5)                      -sin(teta_5)                   0                       a_5
       sin(teta_5)*cos(alpha_5)   cos(teta_5)*cos(alpha_5)       -sin(alpha_5)       -sin(alpha_5)*d_5  
       sin(teta_5)*sin(alpha_5)   cos(teta_5)*sin(alpha_5)        cos(alpha_5)        cos(alpha_5)*d_5   
             0                            0                       0                     1                ];  
         
         
T_56=[ cos(teta_6)                      -sin(teta_6)                   0                       a_6
       sin(teta_6)*cos(alpha_6)   cos(teta_6)*cos(alpha_6)       -sin(alpha_6)       -sin(alpha_6)*d_6  
       sin(teta_6)*sin(alpha_6)   cos(teta_6)*sin(alpha_6)        cos(alpha_6)        cos(alpha_6)*d_6   
             0                            0                       0                     1                ];          
         
T_06= T_01*T_12*T_23*T_34*T_45*T_56;

%    x=T_06(1,4);
%    y=T_06(2,4);
%    z=T_06(3,4);
  
  R_06=[T_06(1,1) T_06(1,2) T_06(1,3)
      T_06(2,1) T_06(2,2) T_06(2,3)
      T_06(3,1) T_06(3,2) T_06(3,3)];

A=R_06*86;
B=[0
   0
   1];
A1=A*B;
    
  x=T_06(1,4)+A1(1,1);
  y=T_06(2,4)+A1(2,1);
  z=T_06(3,4)+A1(3,1);