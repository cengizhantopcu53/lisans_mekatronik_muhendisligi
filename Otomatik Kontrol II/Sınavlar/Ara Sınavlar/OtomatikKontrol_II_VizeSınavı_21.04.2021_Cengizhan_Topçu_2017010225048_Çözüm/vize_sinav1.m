  close all
  clear all
  clc 
  
  % K = 1
%------------------------
  % (s+2)^2 = s^2+4s+4

sifirlar= [1]; 
kutuplar= [1 4 4 ];

G=tf(sifirlar,kutuplar);
rlocus(G);