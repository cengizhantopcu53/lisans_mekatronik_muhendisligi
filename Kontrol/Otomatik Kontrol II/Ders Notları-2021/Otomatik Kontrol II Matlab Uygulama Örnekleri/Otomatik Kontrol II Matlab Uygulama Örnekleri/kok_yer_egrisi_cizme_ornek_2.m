close all
clear all
clc 
  
  % K = 1
%--------------------------------
  % s(s+4)(s+6) = s^3+10s^2+24s+0

sifirlar= [1]; 
kutuplar= [1 10 24 0];

G=tf(sifirlar,kutuplar);
rlocus(G);