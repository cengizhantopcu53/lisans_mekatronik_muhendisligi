syms T01 T12 T23 T03 teta1 teta2 h1 d2 d3 l2
T01=[cos(teta1) -sin(teta1) 0 0;sin(teta1) cos(teta1) 0 0;0 0 1 h1;0 0 0 1];
T12=[cos(teta2) -sin(teta2) 0 0;0 0 -1 -d2;sin(teta2) cos(teta2) 0 0;0 0 0 1];
T23=[1 0 0 0;0 0 1 l2+d3;0 -1 0 0;0 0 0 1];
T03=T01*T12*T23