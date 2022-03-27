  % K(s+7) = s+7
%------------------------
  % s(s+2)^2 = s^3+6s^2+13s

sifirlar= [1 7]; 
kutuplar= [1 6 13 0];

G=tf(sifirlar,kutuplar);
rlocus(G);