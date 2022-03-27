clc;
syms s


%%%%%%%%%%%%%%%%%%%%%%%%%% DE���T�R %%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

Gpay = sym2poly(     (s^0)   );			       % Verilen G(s) pay�
Gpayda = sym2poly(   (s)*(s+2)*(s+2)   );      % Verilen G(s) paydas�

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%



%%%%%%%%%%%%% REEL/SANAL EKSEN NOKTALARI G�R��� %%%%%%%%%%%%%%%%

asimOranigirisi = '??? Soruda %OS (y�zde a��m oran�) ka� olarak verilmi�? ';
yuzdeOS = input(asimOranigirisi);

ksi = (-log(yuzdeOS/100)) / (sqrt(pi^2 + log(yuzdeOS/100)^2));
fprintf('\n\n---Hesaplanan s�n�m oran�: Ksi = %.6f\n\n',ksi);

fprintf('\nK�k yer e�risi �izdiriliyor. L�tfen bekleyiniz.\n');

K=1;
H=1; 

G=tf(Gpay,Gpayda);

root_locus_graph = figure;
rlocus(G*K*H);
T=feedback(G*K,H);
wn=0;
sgrid(ksi,wn);

% pause(1.5);
fprintf('\n??? Grafikteki kesi�im noktas�nda reel k�sm� ka� olarak �l�t�n�z? (Eksi ve nokta kullanarak giriniz.)\n');

reel = input('');
fprintf('\n??? Grafikteki kesi�im noktas�nda sanal k�sm� ka� olarak �l�t�n�z? (i olmadan giriniz.)\n');
img = input('');

% fprintf('\nK�k yer e�risi grafi�ini kapat�n�z.\n\n');
close(root_locus_graph);


%%%%%%%%%%%%%%%%%%%%% KOMPANZAT�R SE��M� %%%%%%%%%%%%%%%%%%%%%%%
kompSecimi = input('\n??? Kompanzat�r tipi giriniz: (PD veya LEAD)\n(Soruda Zc veya Pc verilmeden tepe/y�kselme zaman� d���r�lmesi isteniyorsa PD giriniz.)\n(Soruda Zc veya Pc verilmi� di�erini soruyorsa LEAD giriniz.)\n','s');
kompSecimi = upper(kompSecimi);

switch kompSecimi
    case 'PD'
	fprintf('\nPD se�tiniz. Bu kompanzat�r aktif (ideal) bir kompanzat�rd�r.\nTepe/Yerle�me zamanlar�n� (ge�ici cevap) d���rmek i�in kullan�l�r. \nTransfer fonksiyonunun pay�na bir s�f�r (Zc) ekler.\nPD i�in genel form�l: G(s) = (s + Zc)\n\n');
	giris = '??? Tepe zaman� ya da yerle�me zaman�n� ka� kat d���rmek istiyorsunuz? ';
	dusurmeKatsayisi = input(giris);
	reel = dusurmeKatsayisi * reel;
	img = dusurmeKatsayisi * img;
	fprintf('\n////////////////////////////////////////////////////////////\n');
	fprintf('\n---Kompanzasyon sonras� yeni reel k�s�m = %.5f\n',reel);
	fprintf('---Kompanzasyon sonras� yeni sanal k�s�m = %.5f\n',img);
	Wn = (-1)*reel / ksi;			% yeni do�al frekans
	fprintf('---Kompanzasyon sonras� yeni do�al frekans: Wn = %.5f\n',Wn);
	

	%%%%%%% KUTUPLAR ve SIFIRLARI BULMA ��LEM� %%%%%%%
	Psifirlar=roots(Gpay)
	Pkutuplar=roots(Gpayda)
	fprintf('Kompanzasyon �ncesi G(s) transfer fonksiyonunun s�f�rlar� ve kutuplar� yukar�ya yaz�ld�.\n\n');

	sifirSayisi= length(Psifirlar);
	kutupSayisi= length(Pkutuplar);


	for i=1:kutupSayisi
	istenen = Pkutuplar(i);
		if (istenen<reel)
			kutupAcilari(i)=atand(img/(abs(istenen-reel)));
		elseif (istenen>reel)
			kutupAcilari(i)=180-(atand(img/(abs(istenen-reel))));
		else
			kutupAcilari(i)=90;
		end
		fprintf('\nP%d = %.10f derece',i,kutupAcilari(i));
	end

	
	%% E�er G(s) fonksiyonun PAY'�nda s�f�r yoksa �al��mayacak. (PAY=1 ise)
	if not(sifirSayisi==0)
		for i=1:sifirSayisi
		istenen = Psifirlar(i);
			if (istenen<reel)
				sifirAcilari(i)=atand(img/(abs(istenen-reel)));
			elseif (istenen>reel)
				sifirAcilari(i)=180-(atand(img/(abs(istenen-reel))));
			else
				sifirAcilari(i)=90;
			end
			fprintf('\nZ%d = %.10f derece',i,sifirAcilari(i));
		end
	end

	fprintf('\n---G(s) transfer fonksiyonunun s�f�rlar� ve kutuplar�n�n yatayla yapt�klar� a��lar yukar�ya yaz�ld�. (P:kutup, Z:s�f�r)\n');



	%%%%%%% TetaZ BULMA ��LEM� %%%%%%%
	kutupAcilariToplami = 0;
	for i=1:kutupSayisi
		kutupAcilariToplami = kutupAcilariToplami + (-1)*kutupAcilari(i);
	end



	sifirAcilariToplami = 0;
	for i=1:sifirSayisi
		sifirAcilariToplami = sifirAcilariToplami + (+1)*sifirAcilari(i);
	end


    	

	syms tetaZ
	denklem = kutupAcilariToplami + sifirAcilariToplami + tetaZ==-180;
	zcAcisi=solve(denklem,tetaZ);
	tetaZ=vpa(zcAcisi);
	fprintf('\n---Zc nin yatayla yapt��� a�� (tetaZ) = %.5f derece \n',tetaZ);

        % ??? yeni Zc noktas� reel k�sm�n sa��ndaysa 180-zc laz�m m�? Galiba hay�r.




	%%%%%%% Zc BULMA ��LEM� %%%%%%%



	if (tetaZ<90)
		syms zc
		denklemZc = tand(tetaZ) == img/(zc-((-1)*reel));
 		cozumZc = solve(denklemZc, zc);
		zc=vpa(cozumZc); %sadele�tirme i�lemi
		
	elseif (tetaZ>90)
		syms zc
		denklemZc = tand(tetaZ) == img/(((-1)*reel)-zc);
 		cozumZc = solve(denklemZc, zc);
		zc=vpa(cozumZc); %sadele�tirme i�lemi
		
	else
		syms zc
		zc=(-1)*reel;	% a�� 90'dan b�y�k veya k���k de�ilse tam 90'd�r. Zc ise reel k�s�m �zerindedir.
		
	end
	fprintf('\n---Zc nin reel eksendeki konumu = %.5f \n',(-1)*zc);
			
	% zc ekle

	%%%%%%% HESAPLANAN Zc'yi SIFIRLARA EKLEME ��LEM� %%%%%%%
	Psifirlar(end+1) = (-1)*zc;	%Zc'yi art�l� bulduk ama yatay eksende eksi tarafta. eksi ile �arpar�z.
	sifirSayisi= length(Psifirlar);	%S�f�r say�s� g�ncellendi ��nk� yeni s�f�r ekledik. (Zc)
	kutupSayisi= length(Pkutuplar);



	%%%%%%% YEN� KAZAN� (K, GAIN) HESAPLAMA ��LEM� %%%%%%%
	
	for i=1:kutupSayisi
		istenen = Pkutuplar(i);

		if (istenen<reel)
		L_Kutup_Uzunluklari(i) = sqrt( img^2 + ( (-1)*istenen - (-1)*reel )^2 );
		elseif (istenen>reel)
		L_Kutup_Uzunluklari(i) = sqrt( img^2 + ( (-1)*reel - (-1)*istenen )^2 );
		else
		L_Kutup_Uzunluklari(i) = img;
		end
	end

	for i=1:sifirSayisi
		istenen = Psifirlar(i);

		if (istenen<reel)
		L_Sifir_Uzunluklari(i) = sqrt( img^2 + ( (-1)*istenen - (-1)*reel )^2 );
		elseif (istenen>reel)
		L_Sifir_Uzunluklari(i) = sqrt( img^2 + ( (-1)*reel - (-1)*istenen )^2 );
		else
		L_Sifir_Uzunluklari(i) = img;
		end
	end
	
	toplamPCarpimi=1;
	for i=1:kutupSayisi
		toplamPCarpimi = toplamPCarpimi * L_Kutup_Uzunluklari(i);
	end

	toplamZCarpimi=1;
	for i=1:sifirSayisi
		toplamZCarpimi = toplamZCarpimi * L_Sifir_Uzunluklari(i);
	end

	K= toplamPCarpimi / toplamZCarpimi;
	fprintf('\n---Kompanzasyon sonras� kazan� (K, Gain) de�eri = %.5f \n',K);
	


	%%%%%%% KUTUPLAR ve SIFIRLAR ���N GRAF�K ��ZD�RME ��LEM� %%%%%%%
	for i=1:kutupSayisi
    		plot([Pkutuplar(i),reel], [0,img],'-b')
		hold on
		grid on
		axis on
	end

	for i=1:sifirSayisi
    		plot([Psifirlar(i),reel], [0,img],'-r')
		hold on
		grid on
		axis on
	end

	xline(reel,'--k');
	xline(0,'-k')
	yline(0,'-k')

	fprintf('\nKompanze edilen transfer fonksiyonu i�in kutup ve s�f�rlar�n grafi�i �izdirilmi�tir. \nMavi �izgiler kutuplar�, k�rm�z� �izgiler ise s�f�rlar�n konumlar�n� g�stermektedir.\n');

fprintf('Uzunluklar� ��renmek isterseniz "L_Sifir_Uzunluklari" veya "L_Kutup_Uzunluklari" yaz�n�z.\n\n');


	%%%%%%% KOMPANZAT�R ���N G(s) TRANSFER FONKS�YONU YAZMA ��LEM� %%%%%%%
	fprintf('\n/////////////////////////////////////////////////////////////\n');
	fprintf('\nPD kompanzat�r�n transfer fonksiyonu:    G(s) = (s + %.5f)\n\n',zc);
	fprintf('/////////////////////////////////////////////////////////////\n\n');






%%%%%%%%%%%%%%%%%%%%% LEAD SE��L�RSE %%%%%%%%%%%%%%%%%%%%%%%


    case 'LEAD'
	fprintf('\nLEAD se�tiniz. Bu kompanzat�r pasif bir kompanzat�rd�r.\nTepe/Yerle�me zamanlar�n� (ge�ici cevap) d���rmek i�in kullan�l�r. \nTransfer fonksiyonunun pay�na bir s�f�r (Zc) ve paydas�na bir kutup (Pc) ekler.\nLEAD i�in genel form�l: G(s) = (s + Zc) / (s + Pc)\n\n');
	giris = '??? Tepe zaman� ya da Yerle�me zaman�n� ka� kat d���rmek istiyorsunuz? ';
	dusurmeKatsayisi = input(giris);


	reel = dusurmeKatsayisi * reel;
	img = dusurmeKatsayisi * img;
	Wn = (-1)*reel / ksi;			% yeni do�al frekans

	Psifirlar=roots(Gpay);
	Pkutuplar=roots(Gpayda);


	%%%%%%% SORUDA VER�LEN ZC veya PC'yi KUTUPLARA veya SIFIRLARA EKLEME ��LEM� %%%%%%%

	giris2 = '??? Soruda hangisi verilmi�?  (ZC veya PC) ';
	zc_pc_tercihi = input(giris2,'s');
	zc_pc_tercihi = upper(zc_pc_tercihi);

	if (zc_pc_tercihi=='ZC')
		giris3 = '??? Soruda verilen ZC (s�f�r) de�erini eksi ve nokta kullanarak giriniz:  ';
		verilen_zc = input(giris3);
		Psifirlar(end+1)=verilen_zc;
	elseif (zc_pc_tercihi=='PC')
		giris3 = '??? Soruda verilen PC (kutup) de�erini eksi ve nokta kullanarak giriniz:  ';
		verilen_pc = input(giris3);
		Pkutuplar(end+1)=verilen_pc;
	end

	

	%%%%%%% KUTUPLAR ve SIFIRLARI BULMA ��LEM� %%%%%%%
	Psifirlar
	Pkutuplar
	fprintf('Kompanzasyon �ncesi G(s) transfer fonksiyonunun s�f�rlar� ve kutuplar� yukar�ya yaz�ld�. (Soruda verilen PC veya ZC dahil edilerek)\n');

	sifirSayisi= length(Psifirlar);
	kutupSayisi= length(Pkutuplar);


	fprintf('\n---Kompanzasyon sonras� yeni reel k�s�m = %.5f\n',reel);
	fprintf('---Kompanzasyon sonras� yeni sanal k�s�m = %.5f\n',img);
	fprintf('---Kompanzasyon sonras� yeni do�al frekans: Wn = %.5f\n',Wn);


	for i=1:kutupSayisi
	istenen = Pkutuplar(i);
		if (istenen<reel)
			kutupAcilari(i)=atand(img/(abs(istenen-reel)));
		elseif (istenen>reel)
			kutupAcilari(i)=180-(atand(img/(abs(istenen-reel))));
		else
			kutupAcilari(i)=90;
		end
		fprintf('\nP%d = %.10f derece',i,kutupAcilari(i));
	end

	
	%% E�er G(s) fonksiyonun PAY'�nda s�f�r yoksa �al��mayacak. (PAY=1 ise)
	if not(sifirSayisi==0)
		for i=1:sifirSayisi
		istenen = Psifirlar(i);
			if (istenen<reel)
				sifirAcilari(i)=atand(img/(abs(istenen-reel)));
			elseif (istenen>reel)
				sifirAcilari(i)=180-(atand(img/(abs(istenen-reel))));
			else
				sifirAcilari(i)=90;
			end
			fprintf('\nZ%d = %.10f derece',i,sifirAcilari(i));
		end
	end

	fprintf('\n---G(s) transfer fonksiyonunun s�f�rlar� ve kutuplar�n�n yatayla yapt�klar� a��lar yukar�ya yaz�ld�. (P:kutup, Z:s�f�r)\n');



	%%%%%%% TOPLAM KUTUP/SIFIR A�ILARI BULMA ��LEM� %%%%%%%
	kutupAcilariToplami = 0;
	for i=1:kutupSayisi
		kutupAcilariToplami = kutupAcilariToplami + (-1)*kutupAcilari(i);
	end



	sifirAcilariToplami = 0;
	for i=1:sifirSayisi
		sifirAcilariToplami = sifirAcilariToplami + (+1)*sifirAcilari(i);
	end


	%%%%%%% TETAC YA DA TETAP A�ILARI BULMA ��LEM� %%%%%%%

	if (zc_pc_tercihi=='ZC')	%Zc verilmi� Pc isteniyor.
		syms tetaP
		denklem = kutupAcilariToplami + sifirAcilariToplami - tetaP == -180;
		pcAcisi=solve(denklem,tetaP);
		tetaP=vpa(pcAcisi);
		fprintf('\n---Pc nin yatayla yapt��� a�� (tetaP) = %.5f derece \n',tetaP);
	elseif (zc_pc_tercihi=='PC')	%Pc verilmi� Zc isteniyor.
		syms tetaZ
		denklem = kutupAcilariToplami + sifirAcilariToplami + tetaZ == -180;
		zcAcisi=solve(denklem,tetaZ);
		tetaZ=vpa(zcAcisi);
		fprintf('\n---Zc nin yatayla yapt��� a�� (tetaZ) = %.5f derece \n',tetaZ);
	end





	%%%%%%% ZC YA DA PC BULMA ��LEM� %%%%%%%


	if (zc_pc_tercihi=='ZC')	%Zc verilmi� Pc isteniyor.
		if (tetaP<90)
			syms pc
			denklemPc = tand(tetaP) == img/(pc-((-1)*reel));
 			cozumPc = solve(denklemPc, pc);
			pc=vpa(cozumPc); %sadele�tirme i�lemi
		
		elseif (tetaP>90)
			syms pc
			denklemPc = tand(tetaP) == img/(((-1)*reel)-pc);
 			cozumPc = solve(denklemPc, pc);
			pc=vpa(cozumPc); %sadele�tirme i�lemi
		
		else
			syms pc
			pc=(-1)*reel;	% a�� 90'dan b�y�k veya k���k de�ilse tam 90'd�r. Zc ise reel k�s�m �zerindedir.
		
		end
		fprintf('\n---Pc nin reel eksendeki konumu = %.5f \n',(-1)*pc);	

	elseif (zc_pc_tercihi=='PC')	%Pc verilmi� Zc isteniyor.
		if (tetaZ<90)
			syms zc
			denklemZc = tand(tetaZ) == img/(zc-((-1)*reel));
 			cozumZc = solve(denklemZc, zc);
			zc=vpa(cozumZc); %sadele�tirme i�lemi
		
		elseif (tetaZ>90)
			syms zc
			denklemZc = tand(tetaZ) == img/(((-1)*reel)-zc);
 			cozumZc = solve(denklemZc, zc);
			zc=vpa(cozumZc); %sadele�tirme i�lemi
		
		else
			syms zc
			zc=(-1)*reel;	% a�� 90'dan b�y�k veya k���k de�ilse tam 90'd�r. Zc ise reel k�s�m �zerindedir.
		
		end
		fprintf('\n---Zc nin reel eksendeki konumu = %.5f \n',(-1)*zc);
	end




	%%%%%%% HESAPLANAN Zc'yi SIFIRLARA EKLEME ��LEM� %%%%%%%

	if (zc_pc_tercihi=='ZC')	%Zc verilmi� Pc isteniyor.
		Pkutuplar(end+1) = (-1)*pc;	%Pc'yi art�l� bulduk ama yatay eksende eksi tarafta. eksi ile �arpar�z.	
	elseif (zc_pc_tercihi=='PC')	%Pc verilmi� Zc isteniyor.
		Psifirlar(end+1) = (-1)*zc;	%Zc'yi art�l� bulduk ama yatay eksende eksi tarafta. eksi ile �arpar�z.	
	end


	sifirSayisi= length(Psifirlar);	%S�f�r say�s� g�ncellendi ��nk� yeni s�f�r ekledik. (Zc)
	kutupSayisi= length(Pkutuplar);	%Kutup say�s� g�ncellendi ��nk� yeni kutup ekledik. (Pc)



	%%%%%%% YEN� KAZAN� (K, GAIN) HESAPLAMA ��LEM� %%%%%%%
	
	for i=1:kutupSayisi
		istenen = Pkutuplar(i);

		if (istenen<reel)
		L_Kutup_Uzunluklari(i) = sqrt( img^2 + ( (-1)*istenen - (-1)*reel )^2 );
		elseif (istenen>reel)
		L_Kutup_Uzunluklari(i) = sqrt( img^2 + ( (-1)*reel - (-1)*istenen )^2 );
		else
		L_Kutup_Uzunluklari(i) = img;
		end
	end

	for i=1:sifirSayisi
		istenen = Psifirlar(i);

		if (istenen<reel)
		L_Sifir_Uzunluklari(i) = sqrt( img^2 + ( (-1)*istenen - (-1)*reel )^2 );
		elseif (istenen>reel)
		L_Sifir_Uzunluklari(i) = sqrt( img^2 + ( (-1)*reel - (-1)*istenen )^2 );
		else
		L_Sifir_Uzunluklari(i) = img;
		end
	end
	
	toplamPCarpimi=1;
	for i=1:kutupSayisi
		toplamPCarpimi = toplamPCarpimi * L_Kutup_Uzunluklari(i);
	end

	toplamZCarpimi=1;
	for i=1:sifirSayisi
		toplamZCarpimi = toplamZCarpimi * L_Sifir_Uzunluklari(i);
	end

	K= toplamPCarpimi / toplamZCarpimi;
	fprintf('\n---Kompanzasyon sonras� kazan� (K, Gain) de�eri = %.5f \n',K);
	


%%%%%%% KUTUPLAR ve SIFIRLAR ���N GRAF�K ��ZD�RME ��LEM� %%%%%%%
	for i=1:kutupSayisi
    		plot([Pkutuplar(i),reel], [0,img],'-b')
		hold on
		plot(Pkutuplar(i),0,'bx'); hold on;
		grid on
		axis on
	end


	for i=1:sifirSayisi
    		plot([Psifirlar(i),reel], [0,img],'-r')
		hold on
		plot(Psifirlar(i),0,'ro'); hold on;
		grid on
		axis on
	end


	ylabel('Sanal Eksen');
	xlabel('Reel Eksen');
	xline(reel,'--k');
	yline(img,'--k');
	xline(0,'-k')
	yline(0,'-k')
		

		fprintf('\nKompanze edilen transfer fonksiyonu i�in kutup ve s�f�rlar�n grafi�i �izdirilmi�tir. \nMavi �izgiler kutuplar�, k�rm�z� �izgiler ise s�f�rlar�n konumlar�n� g�stermektedir.\n');

fprintf('Uzunluklar� ��renmek isterseniz "L_Sifir_Uzunluklari" veya "L_Kutup_Uzunluklari" yaz�n�z.\n\n');



	%%%%%%% KOMPANZAT�R ���N G(s) TRANSFER FONKS�YONU YAZMA ��LEM� %%%%%%%

	if (zc_pc_tercihi=='ZC')	% Zc verilmi� Pc isteniyor.
		
		fprintf('\n/////////////////////////////////////////////////////////////\n');
		fprintf('\nLEAD kompanzat�r�n transfer fonksiyonu:    G(s) = (s + %.5f) / (s + %.5f)\n\n',(-1)*verilen_zc,pc);
		fprintf('/////////////////////////////////////////////////////////////\n\n');

	elseif (zc_pc_tercihi=='PC')	% Pc verilmi� Zc isteniyor.
		
		fprintf('\n/////////////////////////////////////////////////////////////\n');
		fprintf('\nLEAD kompanzat�r�n transfer fonksiyonu:    G(s) = (s + %.5f) / (s + %.5f)\n\n',zc,(-1)*verilen_pc);
		fprintf('/////////////////////////////////////////////////////////////\n\n');
	end

    otherwise
        disp('Hatal� giri� yapt�n�z. L�tfen en ba�tan ba�lay�n�z.')
	return
end