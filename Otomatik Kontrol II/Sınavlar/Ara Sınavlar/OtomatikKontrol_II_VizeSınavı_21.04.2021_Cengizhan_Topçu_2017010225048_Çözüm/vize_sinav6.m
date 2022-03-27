  close all
  clear all
  clc 
  
  % K = 1
%------------------------
  % (s+3)^2 = s^2+6s+9

sifirlar= [1]; 
kutuplar= [1 6 9];

G=tf(sifirlar,kutuplar);
rlocus(G);