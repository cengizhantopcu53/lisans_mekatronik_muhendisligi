syms T01 T12 T23 T34 T45 T56 T06 teta1 teta2 teta3 teta4 teta5 teta6 h1 d2 d4 l2
T01=[cos(teta1) -sin(teta1) 0 0;sin(teta1) cos(teta1) 0 0;0 0 1 h1;0 0 0 1];
T12=[cos(teta2) -sin(teta2) 0 0;0 0 1 d2;-sin(teta2) -cos(teta2) 0 0;0 0 0 1];
T23=[cos(teta3) -sin(teta3) 0 l2;sin(teta3) cos(teta3) 0 0;0 0 1 0;0 0 0 1];
T34=[cos(teta4) -sin(teta4) 0 0;0 0 1 d4;-sin(teta4) -cos(teta4) 0 0;0 0 0 1];
T45=[cos(teta5) -sin(teta5) 0 0;0 0 -1 0;sin(teta5) cos(teta5) 0 0;0 0 0 1];
T56=[cos(teta6) -sin(teta6) 0 0;0 0 -1 0;-sin(teta6) -cos(teta6) 0 0;0 0 0 1];
T06=T01*T12*T23*T34*T45*T56