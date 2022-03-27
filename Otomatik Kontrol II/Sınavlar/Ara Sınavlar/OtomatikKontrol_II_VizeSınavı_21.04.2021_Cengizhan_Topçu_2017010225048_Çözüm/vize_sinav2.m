  close all
  clear all
  clc 
  
  % K = 1
%------------------------
  % (s+1)(s+2) = s^2+3s+2

sifirlar= [1]; 
kutuplar= [1 3 2];

G=tf(sifirlar,kutuplar);
rlocus(G);