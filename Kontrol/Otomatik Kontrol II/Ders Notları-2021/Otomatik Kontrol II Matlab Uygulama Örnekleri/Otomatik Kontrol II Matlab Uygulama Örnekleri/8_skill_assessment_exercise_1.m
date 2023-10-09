close all
clear all
clc 

s=2+6j;
G=(s-2)/((s+3));
Theta=(180/pi)*angle(G)
M=abs(G)