  % K(s+5) = s+5
%------------------------
  % s(s+2)(s+3)(s+7) = s^4+12s^3+41s^2+42s

sifirlar= [1 5]; 
kutuplar= [1 12 41 42 0];

G=tf(sifirlar,kutuplar);
rlocus(G);