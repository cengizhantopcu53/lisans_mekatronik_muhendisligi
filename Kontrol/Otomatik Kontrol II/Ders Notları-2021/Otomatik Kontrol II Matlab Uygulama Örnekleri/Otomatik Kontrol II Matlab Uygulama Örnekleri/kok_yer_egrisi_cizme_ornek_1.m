close all
clear all
clc 
  
  % (s+3)(s+4) = s^2+7s+12
%------------------------
  % (s+1)(s+2) = s^2+3s+2

% sifirlar= [1 7 12]; 
% kutuplar= [1 3 2];

  
sifirlar= [1]; 
kutuplar= [1 4 4];

G=tf(sifirlar,kutuplar);
rlocus(G);