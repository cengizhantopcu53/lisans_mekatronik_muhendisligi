  % 10(s+1) = 10s+10
%------------------------
  % 5(s+5) = 5s+25

sifirlar= [10 10]; 
kutuplar= [5 25];

sys=tf(sifirlar,kutuplar);
bode(sys);

grid on 
h=gcr;
setoptions(h,'MagUnits','abs');

% M=10^(a/20)
% a=1.61;