  % K = 1
%------------------------
  % (s+1)^2 = s^2+6s+9

sifirlar= [1]; 
kutuplar= [1 2 1];

G=tf(sifirlar,kutuplar);
rlocus(G);