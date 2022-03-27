  % 5(s+2) = 5s+10
%------------------------
  % s^2+4s = s^2+4s

sifirlar= [5 10]; 
kutuplar= [1 4 0];

sys=tf(sifirlar,kutuplar);
bode(sys);

grid on 
h=gcr;
setoptions(h,'MagUnits','abs');

% M=10^(a/20)
% a=1.61;