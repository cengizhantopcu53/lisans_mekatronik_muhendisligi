%   K = 1
% ------------------------
%   s(s+5) = s^2+5s

sifirlar= [1]; 
kutuplar= [1 5 0];

G=tf(sifirlar,kutuplar);
rlocus(G);

% sifirlar= [1]; 
% kutuplar= [1 3 2];
% 
% G=tf(sifirlar,kutuplar);
% rlocus(G);