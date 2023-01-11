numg=poly([2 4]);
deng=[1 6 25];
G=tf(numg,deng)
rlocus(G)
z=0.5
sgrid(z,0)