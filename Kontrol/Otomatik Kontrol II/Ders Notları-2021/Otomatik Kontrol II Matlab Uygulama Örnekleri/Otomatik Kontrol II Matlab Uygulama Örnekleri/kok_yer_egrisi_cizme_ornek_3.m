  close all
  clear all
  clc 
  
  % K(s+8) = s+8
%------------------------
  % (s+3)(s+6)(s+10) = s^3+19s^2+108s+180

sifirlar= [1 8]; 
kutuplar= [1 19 108 180];

G=tf(sifirlar,kutuplar);
rlocus(G);