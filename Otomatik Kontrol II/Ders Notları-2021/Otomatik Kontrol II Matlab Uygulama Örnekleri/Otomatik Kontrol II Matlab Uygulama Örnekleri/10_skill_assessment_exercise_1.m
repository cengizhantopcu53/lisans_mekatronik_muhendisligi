  % 1 = 1
%------------------------
  % (s+2)(s+4) = s^2+6s+8

sifirlar= [1]; 
kutuplar= [1 6 8];

sys=tf(sifirlar,kutuplar);
bode(sys);

grid on 
h=gcr;
setoptions(h,'MagUnits','abs');

% M=10^(a/20)
% a=1.61;