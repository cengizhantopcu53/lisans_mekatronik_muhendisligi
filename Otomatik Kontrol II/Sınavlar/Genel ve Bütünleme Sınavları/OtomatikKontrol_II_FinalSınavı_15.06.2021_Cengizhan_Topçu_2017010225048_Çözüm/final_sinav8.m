clc;
syms s


%%%%%%%%%%%%%%%%%%%%%%%%%% DEÐÝÞTÝR %%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

Gpay = sym2poly(     (s^0)   );			       % Verilen G(s) payý
Gpayda = sym2poly(   (s)*(s+2)*(s+2)   );      % Verilen G(s) paydasý

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%



%%%%%%%%%%%%% REEL/SANAL EKSEN NOKTALARI GÝRÝÞÝ %%%%%%%%%%%%%%%%

asimOranigirisi = '??? Soruda %OS (yüzde aþým oraný) kaç olarak verilmiþ? ';
yuzdeOS = input(asimOranigirisi);

ksi = (-log(yuzdeOS/100)) / (sqrt(pi^2 + log(yuzdeOS/100)^2));
fprintf('\n\n---Hesaplanan sönüm oraný: Ksi = %.6f\n\n',ksi);

fprintf('\nKök yer eðrisi çizdiriliyor. Lütfen bekleyiniz.\n');

K=1;
H=1; 

G=tf(Gpay,Gpayda);

root_locus_graph = figure;
rlocus(G*K*H);
T=feedback(G*K,H);
wn=0;
sgrid(ksi,wn);

% pause(1.5);
fprintf('\n??? Grafikteki kesiþim noktasýnda reel kýsmý kaç olarak ölçtünüz? (Eksi ve nokta kullanarak giriniz.)\n');

reel = input('');
fprintf('\n??? Grafikteki kesiþim noktasýnda sanal kýsmý kaç olarak ölçtünüz? (i olmadan giriniz.)\n');
img = input('');

% fprintf('\nKök yer eðrisi grafiðini kapatýnýz.\n\n');
close(root_locus_graph);


%%%%%%%%%%%%%%%%%%%%% KOMPANZATÖR SEÇÝMÝ %%%%%%%%%%%%%%%%%%%%%%%
kompSecimi = input('\n??? Kompanzatör tipi giriniz: (PD veya LEAD)\n(Soruda Zc veya Pc verilmeden tepe/yükselme zamaný düþürülmesi isteniyorsa PD giriniz.)\n(Soruda Zc veya Pc verilmiþ diðerini soruyorsa LEAD giriniz.)\n','s');
kompSecimi = upper(kompSecimi);

switch kompSecimi
    case 'PD'
	fprintf('\nPD seçtiniz. Bu kompanzatör aktif (ideal) bir kompanzatördür.\nTepe/Yerleþme zamanlarýný (geçici cevap) düþürmek için kullanýlýr. \nTransfer fonksiyonunun payýna bir sýfýr (Zc) ekler.\nPD için genel formül: G(s) = (s + Zc)\n\n');
	giris = '??? Tepe zamaný ya da yerleþme zamanýný kaç kat düþürmek istiyorsunuz? ';
	dusurmeKatsayisi = input(giris);
	reel = dusurmeKatsayisi * reel;
	img = dusurmeKatsayisi * img;
	fprintf('\n////////////////////////////////////////////////////////////\n');
	fprintf('\n---Kompanzasyon sonrasý yeni reel kýsým = %.5f\n',reel);
	fprintf('---Kompanzasyon sonrasý yeni sanal kýsým = %.5f\n',img);
	Wn = (-1)*reel / ksi;			% yeni doðal frekans
	fprintf('---Kompanzasyon sonrasý yeni doðal frekans: Wn = %.5f\n',Wn);
	

	%%%%%%% KUTUPLAR ve SIFIRLARI BULMA ÝÞLEMÝ %%%%%%%
	Psifirlar=roots(Gpay)
	Pkutuplar=roots(Gpayda)
	fprintf('Kompanzasyon öncesi G(s) transfer fonksiyonunun sýfýrlarý ve kutuplarý yukarýya yazýldý.\n\n');

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

	
	%% Eðer G(s) fonksiyonun PAY'ýnda sýfýr yoksa çalýþmayacak. (PAY=1 ise)
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

	fprintf('\n---G(s) transfer fonksiyonunun sýfýrlarý ve kutuplarýnýn yatayla yaptýklarý açýlar yukarýya yazýldý. (P:kutup, Z:sýfýr)\n');



	%%%%%%% TetaZ BULMA ÝÞLEMÝ %%%%%%%
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
	fprintf('\n---Zc nin yatayla yaptýðý açý (tetaZ) = %.5f derece \n',tetaZ);

        % ??? yeni Zc noktasý reel kýsmýn saðýndaysa 180-zc lazým mý? Galiba hayýr.




	%%%%%%% Zc BULMA ÝÞLEMÝ %%%%%%%



	if (tetaZ<90)
		syms zc
		denklemZc = tand(tetaZ) == img/(zc-((-1)*reel));
 		cozumZc = solve(denklemZc, zc);
		zc=vpa(cozumZc); %sadeleþtirme iþlemi
		
	elseif (tetaZ>90)
		syms zc
		denklemZc = tand(tetaZ) == img/(((-1)*reel)-zc);
 		cozumZc = solve(denklemZc, zc);
		zc=vpa(cozumZc); %sadeleþtirme iþlemi
		
	else
		syms zc
		zc=(-1)*reel;	% açý 90'dan büyük veya küçük deðilse tam 90'dýr. Zc ise reel kýsým üzerindedir.
		
	end
	fprintf('\n---Zc nin reel eksendeki konumu = %.5f \n',(-1)*zc);
			
	% zc ekle

	%%%%%%% HESAPLANAN Zc'yi SIFIRLARA EKLEME ÝÞLEMÝ %%%%%%%
	Psifirlar(end+1) = (-1)*zc;	%Zc'yi artýlý bulduk ama yatay eksende eksi tarafta. eksi ile çarparýz.
	sifirSayisi= length(Psifirlar);	%Sýfýr sayýsý güncellendi çünkü yeni sýfýr ekledik. (Zc)
	kutupSayisi= length(Pkutuplar);



	%%%%%%% YENÝ KAZANÇ (K, GAIN) HESAPLAMA ÝÞLEMÝ %%%%%%%
	
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
	fprintf('\n---Kompanzasyon sonrasý kazanç (K, Gain) deðeri = %.5f \n',K);
	


	%%%%%%% KUTUPLAR ve SIFIRLAR ÝÇÝN GRAFÝK ÇÝZDÝRME ÝÞLEMÝ %%%%%%%
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

	fprintf('\nKompanze edilen transfer fonksiyonu için kutup ve sýfýrlarýn grafiði çizdirilmiþtir. \nMavi çizgiler kutuplarý, kýrmýzý çizgiler ise sýfýrlarýn konumlarýný göstermektedir.\n');

fprintf('Uzunluklarý öðrenmek isterseniz "L_Sifir_Uzunluklari" veya "L_Kutup_Uzunluklari" yazýnýz.\n\n');


	%%%%%%% KOMPANZATÖR ÝÇÝN G(s) TRANSFER FONKSÝYONU YAZMA ÝÞLEMÝ %%%%%%%
	fprintf('\n/////////////////////////////////////////////////////////////\n');
	fprintf('\nPD kompanzatörün transfer fonksiyonu:    G(s) = (s + %.5f)\n\n',zc);
	fprintf('/////////////////////////////////////////////////////////////\n\n');






%%%%%%%%%%%%%%%%%%%%% LEAD SEÇÝLÝRSE %%%%%%%%%%%%%%%%%%%%%%%


    case 'LEAD'
	fprintf('\nLEAD seçtiniz. Bu kompanzatör pasif bir kompanzatördür.\nTepe/Yerleþme zamanlarýný (geçici cevap) düþürmek için kullanýlýr. \nTransfer fonksiyonunun payýna bir sýfýr (Zc) ve paydasýna bir kutup (Pc) ekler.\nLEAD için genel formül: G(s) = (s + Zc) / (s + Pc)\n\n');
	giris = '??? Tepe zamaný ya da Yerleþme zamanýný kaç kat düþürmek istiyorsunuz? ';
	dusurmeKatsayisi = input(giris);


	reel = dusurmeKatsayisi * reel;
	img = dusurmeKatsayisi * img;
	Wn = (-1)*reel / ksi;			% yeni doðal frekans

	Psifirlar=roots(Gpay);
	Pkutuplar=roots(Gpayda);


	%%%%%%% SORUDA VERÝLEN ZC veya PC'yi KUTUPLARA veya SIFIRLARA EKLEME ÝÞLEMÝ %%%%%%%

	giris2 = '??? Soruda hangisi verilmiþ?  (ZC veya PC) ';
	zc_pc_tercihi = input(giris2,'s');
	zc_pc_tercihi = upper(zc_pc_tercihi);

	if (zc_pc_tercihi=='ZC')
		giris3 = '??? Soruda verilen ZC (sýfýr) deðerini eksi ve nokta kullanarak giriniz:  ';
		verilen_zc = input(giris3);
		Psifirlar(end+1)=verilen_zc;
	elseif (zc_pc_tercihi=='PC')
		giris3 = '??? Soruda verilen PC (kutup) deðerini eksi ve nokta kullanarak giriniz:  ';
		verilen_pc = input(giris3);
		Pkutuplar(end+1)=verilen_pc;
	end

	

	%%%%%%% KUTUPLAR ve SIFIRLARI BULMA ÝÞLEMÝ %%%%%%%
	Psifirlar
	Pkutuplar
	fprintf('Kompanzasyon öncesi G(s) transfer fonksiyonunun sýfýrlarý ve kutuplarý yukarýya yazýldý. (Soruda verilen PC veya ZC dahil edilerek)\n');

	sifirSayisi= length(Psifirlar);
	kutupSayisi= length(Pkutuplar);


	fprintf('\n---Kompanzasyon sonrasý yeni reel kýsým = %.5f\n',reel);
	fprintf('---Kompanzasyon sonrasý yeni sanal kýsým = %.5f\n',img);
	fprintf('---Kompanzasyon sonrasý yeni doðal frekans: Wn = %.5f\n',Wn);


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

	
	%% Eðer G(s) fonksiyonun PAY'ýnda sýfýr yoksa çalýþmayacak. (PAY=1 ise)
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

	fprintf('\n---G(s) transfer fonksiyonunun sýfýrlarý ve kutuplarýnýn yatayla yaptýklarý açýlar yukarýya yazýldý. (P:kutup, Z:sýfýr)\n');



	%%%%%%% TOPLAM KUTUP/SIFIR AÇILARI BULMA ÝÞLEMÝ %%%%%%%
	kutupAcilariToplami = 0;
	for i=1:kutupSayisi
		kutupAcilariToplami = kutupAcilariToplami + (-1)*kutupAcilari(i);
	end



	sifirAcilariToplami = 0;
	for i=1:sifirSayisi
		sifirAcilariToplami = sifirAcilariToplami + (+1)*sifirAcilari(i);
	end


	%%%%%%% TETAC YA DA TETAP AÇILARI BULMA ÝÞLEMÝ %%%%%%%

	if (zc_pc_tercihi=='ZC')	%Zc verilmiþ Pc isteniyor.
		syms tetaP
		denklem = kutupAcilariToplami + sifirAcilariToplami - tetaP == -180;
		pcAcisi=solve(denklem,tetaP);
		tetaP=vpa(pcAcisi);
		fprintf('\n---Pc nin yatayla yaptýðý açý (tetaP) = %.5f derece \n',tetaP);
	elseif (zc_pc_tercihi=='PC')	%Pc verilmiþ Zc isteniyor.
		syms tetaZ
		denklem = kutupAcilariToplami + sifirAcilariToplami + tetaZ == -180;
		zcAcisi=solve(denklem,tetaZ);
		tetaZ=vpa(zcAcisi);
		fprintf('\n---Zc nin yatayla yaptýðý açý (tetaZ) = %.5f derece \n',tetaZ);
	end





	%%%%%%% ZC YA DA PC BULMA ÝÞLEMÝ %%%%%%%


	if (zc_pc_tercihi=='ZC')	%Zc verilmiþ Pc isteniyor.
		if (tetaP<90)
			syms pc
			denklemPc = tand(tetaP) == img/(pc-((-1)*reel));
 			cozumPc = solve(denklemPc, pc);
			pc=vpa(cozumPc); %sadeleþtirme iþlemi
		
		elseif (tetaP>90)
			syms pc
			denklemPc = tand(tetaP) == img/(((-1)*reel)-pc);
 			cozumPc = solve(denklemPc, pc);
			pc=vpa(cozumPc); %sadeleþtirme iþlemi
		
		else
			syms pc
			pc=(-1)*reel;	% açý 90'dan büyük veya küçük deðilse tam 90'dýr. Zc ise reel kýsým üzerindedir.
		
		end
		fprintf('\n---Pc nin reel eksendeki konumu = %.5f \n',(-1)*pc);	

	elseif (zc_pc_tercihi=='PC')	%Pc verilmiþ Zc isteniyor.
		if (tetaZ<90)
			syms zc
			denklemZc = tand(tetaZ) == img/(zc-((-1)*reel));
 			cozumZc = solve(denklemZc, zc);
			zc=vpa(cozumZc); %sadeleþtirme iþlemi
		
		elseif (tetaZ>90)
			syms zc
			denklemZc = tand(tetaZ) == img/(((-1)*reel)-zc);
 			cozumZc = solve(denklemZc, zc);
			zc=vpa(cozumZc); %sadeleþtirme iþlemi
		
		else
			syms zc
			zc=(-1)*reel;	% açý 90'dan büyük veya küçük deðilse tam 90'dýr. Zc ise reel kýsým üzerindedir.
		
		end
		fprintf('\n---Zc nin reel eksendeki konumu = %.5f \n',(-1)*zc);
	end




	%%%%%%% HESAPLANAN Zc'yi SIFIRLARA EKLEME ÝÞLEMÝ %%%%%%%

	if (zc_pc_tercihi=='ZC')	%Zc verilmiþ Pc isteniyor.
		Pkutuplar(end+1) = (-1)*pc;	%Pc'yi artýlý bulduk ama yatay eksende eksi tarafta. eksi ile çarparýz.	
	elseif (zc_pc_tercihi=='PC')	%Pc verilmiþ Zc isteniyor.
		Psifirlar(end+1) = (-1)*zc;	%Zc'yi artýlý bulduk ama yatay eksende eksi tarafta. eksi ile çarparýz.	
	end


	sifirSayisi= length(Psifirlar);	%Sýfýr sayýsý güncellendi çünkü yeni sýfýr ekledik. (Zc)
	kutupSayisi= length(Pkutuplar);	%Kutup sayýsý güncellendi çünkü yeni kutup ekledik. (Pc)



	%%%%%%% YENÝ KAZANÇ (K, GAIN) HESAPLAMA ÝÞLEMÝ %%%%%%%
	
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
	fprintf('\n---Kompanzasyon sonrasý kazanç (K, Gain) deðeri = %.5f \n',K);
	


%%%%%%% KUTUPLAR ve SIFIRLAR ÝÇÝN GRAFÝK ÇÝZDÝRME ÝÞLEMÝ %%%%%%%
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
		

		fprintf('\nKompanze edilen transfer fonksiyonu için kutup ve sýfýrlarýn grafiði çizdirilmiþtir. \nMavi çizgiler kutuplarý, kýrmýzý çizgiler ise sýfýrlarýn konumlarýný göstermektedir.\n');

fprintf('Uzunluklarý öðrenmek isterseniz "L_Sifir_Uzunluklari" veya "L_Kutup_Uzunluklari" yazýnýz.\n\n');



	%%%%%%% KOMPANZATÖR ÝÇÝN G(s) TRANSFER FONKSÝYONU YAZMA ÝÞLEMÝ %%%%%%%

	if (zc_pc_tercihi=='ZC')	% Zc verilmiþ Pc isteniyor.
		
		fprintf('\n/////////////////////////////////////////////////////////////\n');
		fprintf('\nLEAD kompanzatörün transfer fonksiyonu:    G(s) = (s + %.5f) / (s + %.5f)\n\n',(-1)*verilen_zc,pc);
		fprintf('/////////////////////////////////////////////////////////////\n\n');

	elseif (zc_pc_tercihi=='PC')	% Pc verilmiþ Zc isteniyor.
		
		fprintf('\n/////////////////////////////////////////////////////////////\n');
		fprintf('\nLEAD kompanzatörün transfer fonksiyonu:    G(s) = (s + %.5f) / (s + %.5f)\n\n',zc,(-1)*verilen_pc);
		fprintf('/////////////////////////////////////////////////////////////\n\n');
	end

    otherwise
        disp('Hatalý giriþ yaptýnýz. Lütfen en baþtan baþlayýnýz.')
	return
end