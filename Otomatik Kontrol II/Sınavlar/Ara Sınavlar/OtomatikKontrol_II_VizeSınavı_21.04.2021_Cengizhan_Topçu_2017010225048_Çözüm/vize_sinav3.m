  close all
  clear all
  clc 
  
  % K = 1
%------------------------
  % (s+4)^2 = s^2+8s+16

sifirlar= [1]; 
kutuplar= [1 8 16];

G=tf(sifirlar,kutuplar);
rlocus(G);