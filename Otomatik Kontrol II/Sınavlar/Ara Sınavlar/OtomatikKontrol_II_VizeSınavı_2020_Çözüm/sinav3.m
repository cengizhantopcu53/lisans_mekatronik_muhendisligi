  close all
  clear all
  clc 
  
  % K(s+7) = s+7
%------------------------
  % s(s^2+6s+13) = s^3+6s^2+13s+0

sifirlar= [1 7]; 
kutuplar= [1 6 13 0];

G=tf(sifirlar,kutuplar);
rlocus(G);