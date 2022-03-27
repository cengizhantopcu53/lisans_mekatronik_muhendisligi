  % K = 1
%------------------------
  % s(s+2)^2 = s^3+4s^2+4s

sifirlar= [1]; 
kutuplar= [1 4 4 0];

G=tf(sifirlar,kutuplar);
rlocus(G);