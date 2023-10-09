syms teta_1 teta_2 teta_3 teta_4 teta_5 teta_6

px=481;  %481-331
py=2;    %2-90
pz=776;  %776-776   
c=2;
  
teta_1=(atan2(-px,py)+atan2(sqrt((px^2)+(py^2)-(c^2)),c));
%teta_1= atan2(-px,py)-atan2(sqrt((px^2)+(py^2)-(c^2)),c);
  
eq_1=pz*cos(teta_2) - 75*sin(teta_2) - 331*cos(teta_2) + px*cos(teta_1)*sin(teta_2) + py*sin(teta_1)*sin(teta_2)==90*cos(teta_3) - 320*sin(teta_3) + 355;
eq_2=331*sin(teta_2) - 75*cos(teta_2) - pz*sin(teta_2) + px*cos(teta_1)*cos(teta_2) + py*cos(teta_2)*sin(teta_1)==320*cos(teta_3) + 90*sin(teta_3);

sol1=solve([eq_1 eq_2],[teta_2 teta_3]);
teta_2=(sol1.teta_2(1,1));
teta_3=(sol1.teta_3(1,1));

eq_3=-cos(teta_4)*sin(teta_5)==((cos(teta_1)*sin(teta_3)*sin(teta_2 - pi/2) - cos(teta_1)*cos(teta_3)*cos(teta_2 - pi/2))*(sin(teta_5)*(sin(teta_1)*sin(teta_4) + cos(teta_1)*cos(teta_2)*cos(teta_4)*sin(teta_3) + cos(teta_1)*cos(teta_3)*cos(teta_4)*sin(teta_2)) - cos(teta_2 + teta_3)*cos(teta_1)*cos(teta_5)))/(cos(teta_1)^2*cos(teta_3)^2*cos(teta_2 - pi/2)^2 + cos(teta_1)^2*cos(teta_3)^2*sin(teta_2 - pi/2)^2 + cos(teta_1)^2*cos(teta_2 - pi/2)^2*sin(teta_3)^2 + cos(teta_3)^2*cos(teta_2 - pi/2)^2*sin(teta_1)^2 + cos(teta_1)^2*sin(teta_3)^2*sin(teta_2 - pi/2)^2 + cos(teta_3)^2*sin(teta_1)^2*sin(teta_2 - pi/2)^2 + cos(teta_2 - pi/2)^2*sin(teta_1)^2*sin(teta_3)^2 + sin(teta_1)^2*sin(teta_3)^2*sin(teta_2 - pi/2)^2) + ((sin(teta_2 + teta_3)*cos(teta_5) + cos(teta_2 + teta_3)*cos(teta_4)*sin(teta_5))*(cos(teta_3)*sin(teta_2 - pi/2) + cos(teta_2 - pi/2)*sin(teta_3)))/(cos(teta_3)^2*cos(teta_2 - pi/2)^2 + cos(teta_3)^2*sin(teta_2 - pi/2)^2 + cos(teta_2 - pi/2)^2*sin(teta_3)^2 + sin(teta_3)^2*sin(teta_2 - pi/2)^2) - ((cos(teta_3)*cos(teta_2 - pi/2)*sin(teta_1) - sin(teta_1)*sin(teta_3)*sin(teta_2 - pi/2))*(sin(teta_5)*(cos(teta_2)*cos(teta_4)*sin(teta_1)*sin(teta_3) - cos(teta_1)*sin(teta_4) + cos(teta_3)*cos(teta_4)*sin(teta_1)*sin(teta_2)) - cos(teta_2 + teta_3)*cos(teta_5)*sin(teta_1)))/(cos(teta_1)^2*cos(teta_3)^2*cos(teta_2 - pi/2)^2 + cos(teta_1)^2*cos(teta_3)^2*sin(teta_2 - pi/2)^2 + cos(teta_1)^2*cos(teta_2 - pi/2)^2*sin(teta_3)^2 + cos(teta_3)^2*cos(teta_2 - pi/2)^2*sin(teta_1)^2 + cos(teta_1)^2*sin(teta_3)^2*sin(teta_2 - pi/2)^2 + cos(teta_3)^2*sin(teta_1)^2*sin(teta_2 - pi/2)^2 + cos(teta_2 - pi/2)^2*sin(teta_1)^2*sin(teta_3)^2 + sin(teta_1)^2*sin(teta_3)^2*sin(teta_2 - pi/2)^2);
eq_4=sin(teta_4)*sin(teta_5)==(sin(teta_1)*(sin(teta_5)*(sin(teta_1)*sin(teta_4) + cos(teta_1)*cos(teta_2)*cos(teta_4)*sin(teta_3) + cos(teta_1)*cos(teta_3)*cos(teta_4)*sin(teta_2)) - cos(teta_2 + teta_3)*cos(teta_1)*cos(teta_5)))/(cos(teta_1)^2 + sin(teta_1)^2) - (cos(teta_1)*(sin(teta_5)*(cos(teta_2)*cos(teta_4)*sin(teta_1)*sin(teta_3) - cos(teta_1)*sin(teta_4) + cos(teta_3)*cos(teta_4)*sin(teta_1)*sin(teta_2)) - cos(teta_2 + teta_3)*cos(teta_5)*sin(teta_1)))/(cos(teta_1)^2 + sin(teta_1)^2);

sol2=solve([eq_3 eq_4],[teta_4 teta_5]);
teta_4=(sol2.teta_4(1,1));
teta_5=(sol2.teta_5(1,1));

teta_6=0;

q2=[double(rad2deg(teta_1))
    double(rad2deg(teta_2))
    double(rad2deg(teta_3))
    double(rad2deg(teta_4))
    double(rad2deg(teta_5))
    double(rad2deg(teta_6))];

T_01=[ cos(teta_1)  -sin(teta_1)   0   0
       sin(teta_1)   cos(teta_1)   0   0
                0            0     1  331
                0            0     0   1 ];
         
            
T_12= [  cos(teta_2 - pi/2)    -sin(teta_2 - pi/2)    0  75   
         0                          0                 1   2
         -sin(teta_2 - pi/2)   -cos(teta_2 - pi/2)    0   0
           0                         0                0   1];
       
       
T_23=[ cos(teta_3)  -sin(teta_3)   0    355
       sin(teta_3)    cos(teta_3)  0    0
                0            0     1    0
                0            0     0    1  ];
            
            
            
T_34=[cos(teta_4)     -sin(teta_4)       0   90 
          0                0             1   320
      -sin(teta_4)    -cos(teta_4)       0    0
         0                0              0    1];
     
     
T_45=[  cos(teta_5)      -sin(teta_5)    0     0
         0                   0           -1    0
        sin(teta_5)      cos(teta_5)     0     0
           0                 0           0     1];
       
       
T_56= [ cos(teta_6)     -sin(teta_6)     0     0
           0               0             1     0
       -sin(teta_6)     -cos(teta_6)     0     0
           0               0             0     1];



T_06=double(T_01*T_12*T_23*T_34*T_45*T_56);



R_06=[T_06(1,1) T_06(1,2) T_06(1,3)
      T_06(2,1) T_06(2,2) T_06(2,3)
      T_06(3,1) T_06(3,2) T_06(3,3)];

A=R_06*86;
B=[0
   0
   1];
A1=A*B;   %4.EKLEM İLE 6.EKLEM ARASINDAKİ FARK
    
  x=T_06(1,4)-A1(1,1);
  y=T_06(2,4)-A1(2,1);
  z=T_06(3,4)-A1(3,1);
  
  T_06_=T_06;
  T_06_(1,4)=x;
  T_06_(2,4)=y;
  T_06_(3,4)=z;
  
  tetaa_1=rad2deg(teta_1);
  tetaa_2=rad2deg(teta_2);
  tetaa_3=rad2deg(teta_3);
  tetaa_4=rad2deg(teta_4);
  tetaa_5=rad2deg(teta_5);
  tetaa_6=rad2deg(teta_6);
  
q=[tetaa_1
   tetaa_2
   tetaa_3
   tetaa_4
   tetaa_5
   tetaa_6];

syms teta_11 teta_22 teta_33 teta_44 teta_55 teta_66
xx=double(x);
yy=double(y);
zz=double(z);

teta_11= (atan2(-xx,yy)+atan2(sqrt((xx^2)+(yy^2)-(c^2)),c));
%teta_1= atan2(-px,py)-atan2(sqrt((px^2)+(py^2)-(c^2)),c);

eq_6=zz*cos(teta_22) - 75*sin(teta_22) - 331*cos(teta_22) + xx*cos(teta_11)*sin(teta_22) + yy*sin(teta_11)*sin(teta_22)==90*cos(teta_33) - 320*sin(teta_33) + 355;
eq_7=331*sin(teta_22) - 75*cos(teta_22) - zz*sin(teta_22) + xx*cos(teta_11)*cos(teta_22) + yy*cos(teta_22)*sin(teta_11)==320*cos(teta_33) + 90*sin(teta_33);

sol3=solve([eq_6 eq_7],[teta_22 teta_33]);
teta_22=(sol3.teta_22(1,1));
teta_33=(sol3.teta_33(1,1));

xfark=A1(1,1);
yfark=A1(2,1);
zfark=A1(3,1);

eq_8=(zfark*(81129638414606678066041400783053*cos(teta_44)*cos(teta_55) + 36352050459684853281621484240896*sin(teta_44)*sin(teta_55)))/(81129638414606678066041400783053*(cos(teta_44)^2*cos(teta_55)^2 + cos(teta_44)^2*sin(teta_55)^2 + cos(teta_55)^2*sin(teta_44)^2 + sin(teta_44)^2*sin(teta_55)^2)) - (yfark*(36352050459684853281621484240896*cos(teta_44)*sin(teta_55) - 81129638414606678066041400783053*cos(teta_55)*sin(teta_44)))/(81129638414606678066041400783053*(cos(teta_44)^2*cos(teta_55)^2 + cos(teta_44)^2*sin(teta_55)^2 + cos(teta_55)^2*sin(teta_44)^2 + sin(teta_44)^2*sin(teta_55)^2)) + (72529626061778025144792148606976*xfark*sin(teta_55))/(81129638414606678066041400783053*(cos(teta_55)^2 + sin(teta_55)^2))==0;
eq_9=(72529626061778025144792148606976*xfark*cos(teta_55))/(81129638414606678066041400783053*(cos(teta_55)^2 + sin(teta_55)^2)) - (zfark*(81129638414606678066041400783053*cos(teta_44)*sin(teta_55) - 36352050459684853281621484240896*cos(teta_55)*sin(teta_44)))/(81129638414606678066041400783053*(cos(teta_44)^2*cos(teta_55)^2 + cos(teta_44)^2*sin(teta_55)^2 + cos(teta_55)^2*sin(teta_44)^2 + sin(teta_44)^2*sin(teta_55)^2)) - (yfark*(36352050459684853281621484240896*cos(teta_44)*cos(teta_55) + 81129638414606678066041400783053*sin(teta_44)*sin(teta_55)))/(81129638414606678066041400783053*(cos(teta_44)^2*cos(teta_55)^2 + cos(teta_44)^2*sin(teta_55)^2 + cos(teta_55)^2*sin(teta_44)^2 + sin(teta_44)^2*sin(teta_55)^2))==76.8837;

sol4=solve([eq_8 eq_9],[teta_44 teta_55]);


teta_44= sol4.teta_44(3,1);
teta_55= sol4.teta_55(3,1);


  tetaa_11=double(rad2deg(teta_11));
  tetaa_22=double(rad2deg(teta_22));
  tetaa_33=double(rad2deg(teta_33));
  tetaa_44=double(rad2deg(teta_44));
  tetaa_55=double(rad2deg(teta_55));
  
  
acilar=[tetaa_11
    tetaa_22
    tetaa_33
    tetaa_44
    tetaa_55
    0       ];
            









% eq_8=-cos(teta_44)*sin(teta_55)==((cos(teta_11)*sin(teta_33)*sin(teta_22 - pi/2) - cos(teta_11)*cos(teta_33)*cos(teta_22 - pi/2))*(sin(teta_55)*(sin(teta_11)*sin(teta_44) + cos(teta_11)*cos(teta_22)*cos(teta_44)*sin(teta_33) + cos(teta_11)*cos(teta_33)*cos(teta_44)*sin(teta_22)) - cos(teta_22 + teta_33)*cos(teta_11)*cos(teta_55)))/(cos(teta_11)^2*cos(teta_33)^2*cos(teta_22 - pi/2)^2 + cos(teta_11)^2*cos(teta_33)^2*sin(teta_22 - pi/2)^2 + cos(teta_11)^2*cos(teta_22 - pi/2)^2*sin(teta_33)^2 + cos(teta_33)^2*cos(teta_22 - pi/2)^2*sin(teta_11)^2 + cos(teta_11)^2*sin(teta_33)^2*sin(teta_22 - pi/2)^2 + cos(teta_33)^2*sin(teta_11)^2*sin(teta_22 - pi/2)^2 + cos(teta_22 - pi/2)^2*sin(teta_11)^2*sin(teta_33)^2 + sin(teta_11)^2*sin(teta_33)^2*sin(teta_22 - pi/2)^2) + ((sin(teta_22 + teta_33)*cos(teta_55) + cos(teta_22 + teta_33)*cos(teta_44)*sin(teta_55))*(cos(teta_33)*sin(teta_22 - pi/2) + cos(teta_22 - pi/2)*sin(teta_33)))/(cos(teta_33)^2*cos(teta_22 - pi/2)^2 + cos(teta_33)^2*sin(teta_22 - pi/2)^2 + cos(teta_22 - pi/2)^2*sin(teta_33)^2 + sin(teta_33)^2*sin(teta_22 - pi/2)^2) - ((cos(teta_33)*cos(teta_22 - pi/2)*sin(teta_11) - sin(teta_11)*sin(teta_3)*sin(teta_22 - pi/2))*(sin(teta_5)*(cos(teta_22)*cos(teta_44)*sin(teta_11)*sin(teta_33) - cos(teta_11)*sin(teta_44) + cos(teta_33)*cos(teta_44)*sin(teta_11)*sin(teta_22)) - cos(teta_22 + teta_33)*cos(teta_55)*sin(teta_11)))/(cos(teta_11)^2*cos(teta_33)^2*cos(teta_22 - pi/2)^2 + cos(teta_11)^2*cos(teta_33)^2*sin(teta_22 - pi/2)^2 + cos(teta_11)^2*cos(teta_22 - pi/2)^2*sin(teta_33)^2 + cos(teta_33)^2*cos(teta_22 - pi/2)^2*sin(teta_11)^2 + cos(teta_11)^2*sin(teta_33)^2*sin(teta_22 - pi/2)^2 + cos(teta_33)^2*sin(teta_11)^2*sin(teta_22 - pi/2)^2 + cos(teta_22 - pi/2)^2*sin(teta_11)^2*sin(teta_33)^2 + sin(teta_11)^2*sin(teta_33)^2*sin(teta_22 - pi/2)^2);
% eq_9=sin(teta_44)*sin(teta_55)==(sin(teta_11)*(sin(teta_55)*(sin(teta_11)*sin(teta_44) + cos(teta_11)*cos(teta_22)*cos(teta_44)*sin(teta_33) + cos(teta_11)*cos(teta_33)*cos(teta_44)*sin(teta_22)) - cos(teta_22 + teta_33)*cos(teta_11)*cos(teta_55)))/(cos(teta_11)^2 + sin(teta_11)^2) - (cos(teta_11)*(sin(teta_55)*(cos(teta_22)*cos(teta_44)*sin(teta_11)*sin(teta_33) - cos(teta_11)*sin(teta_44) + cos(teta_33)*cos(teta_44)*sin(teta_11)*sin(teta_22)) - cos(teta_22 + teta_33)*cos(teta_55)*sin(teta_11)))/(cos(teta_11)^2 + sin(teta_11)^2);
% 
% sol4=solve([eq_8 eq_9],[teta_44 teta_55]);
% teta_44=(sol4.teta_44(1,1));
% teta_55=(sol4.teta_55(1,1));
% 
% teta_66=0;
%          
         

%   tetaa_11=double(rad2deg(teta_11));
%   tetaa_22=double(rad2deg(teta_22));
%   tetaa_33=double(rad2deg(teta_33));
%   tetaa_44=double(rad2deg(teta_44));
%   tetaa_55=double(rad2deg(teta_55));
%   tetaa_66=double(rad2deg(teta_66));
%   
% q1=[tetaa_11
%     tetaa_22
%     tetaa_33
%     tetaa_44
%     tetaa_55
%     tetaa_66];




