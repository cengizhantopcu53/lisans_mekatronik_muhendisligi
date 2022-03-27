  close all
  clear all
  clc 
  
  % K(s+8) = s+8
%------------------------
  % (s+3)(s^2+4s+5) = s^3+7s^2+17s+15

sifirlar= [1 8]; 
kutuplar= [1 7 17 15];

G=tf(sifirlar,kutuplar);
rlocus(G);