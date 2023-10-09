<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UrunSatis.aspx.cs" Inherits="Odev6_TicariAlisverisSitesi.UrunSatis" %>

<!DOCTYPE html>
<html lang="en">
<head>
<title>Robotistan | Elektronik Malzeme Marketi Online Satış</title>
<!-- Meta tag Keywords -->
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Fare Payment Widget Responsive Widget,Login form widgets, Sign up Web forms , Login signup Responsive web form,Flat Pricing table,Flat Drop downs,Registration Forms,News letter Forms,Elements" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false);
function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- Meta tag Keywords -->

<!-- css files -->
<link href="Satıs/css/style.css" rel="stylesheet" type="text/css" media="all">
<link rel="stylesheet" href="css/creditly.css" type="text/css" media="all" /> <!-- credit-card-CSS -->
<!-- //css files -->

<!-- online-fonts -->
<link href="//fonts.googleapis.com/css?family=Josefin+Sans:100,100i,300,300i,400,400i,600,600i,700,700i&amp;subset=latin-ext" rel="stylesheet">
<!--//online-fonts -->

</head>
<body>
<div class="header">
	<h1>ÜRÜN SATIŞ SAYFASI</h1>
</div>

<div class="w3-main">
	<!-- Main -->
	<div class="about-bottom">
		<div class="w3l_about_bottom_left">
			<div class="book-form b2">
				<div class="agile-form">
				<h3 class="cat-w3l"></h3>
				<h3 class="cat2-w3l"></h3>
				<div class="clear"></div>
			    <form action="#" method="post" runat="server">
					<div class="form-date-w3-agileits2 w3l1">
						<asp:TextBox ID="TxtAd" runat="server" placeholder="AD" Font-Size="Large"></asp:TextBox>
						<asp:TextBox ID="TxtKategori" runat="server" placeholder="KATEGORİ" Font-Size="Large"></asp:TextBox>
                    <asp:TextBox ID="TxtMarka" runat="server" placeholder="MARKA" Font-Size="Large"></asp:TextBox>
                    <asp:TextBox ID="TxtFiyat" runat="server" placeholder="FİYAT" Font-Size="Large"></asp:TextBox>
                    <asp:TextBox ID="TxtOzellik" runat="server" placeholder="ÖZELLİK" Font-Size="Large"></asp:TextBox>
                        <asp:TextBox ID="TxtResim" runat="server" placeholder="RESİM" Font-Size="Large"></asp:TextBox>
					</div>
				</form>
			</div>
			</div>
		</div>
		<div class="w3l_about_bottom_right two">
			<div class="book-form">
				<h2 class="tittle">Ödeme Formu</h2>
			    <form action="#" method="post" class="creditly-card-form agileinfo_form">
				<section class="creditly-wrapper wthree, w3_agileits_wrapper">
					<div class="form-date-w3-agileits">
						<label> Kartın Üzerindeki Ad Soyad:</label>
						<input type="text" name="name" placeholder="Ad Soyad" required="">
					</div>
					<div class="form-date-w3-agileits">
						<label> Email :</label>
						<input type="email" name="email" placeholder="Email" required="">
					</div>
					<div class="form-date-w3-agileits">
						<label class="control-label">Kart Numarası</label>
						<input class="number credit-card-number form-control" type="text" name="number"
							inputmode="numeric" autocomplete="cc-number" autocompletetype="cc-number" x-autocompletetype="cc-number"
							placeholder="&#149;&#149;&#149;&#149; &#149;&#149;&#149;&#149; &#149;&#149;&#149;&#149; &#149;&#149;&#149;&#149;">
					</div>
					<div class="form-date-w3-agileits">
						<label> Son Kullanma Tarihi :</label>
						<input class="expiration-month-and-year form-control" type="text" name="expiration-month-and-year" placeholder="AA / YY">		
					</div>
					<div class="form-date-w3-agileits">
						<label> CVV Numarası :</label>
						<input class="security-code form-control"Â·
							inputmode="numeric"
							type="text" name="security-code"
							placeholder="&#149;&#149;&#149;">			
					</div>
					<div class="make wow shake">
						  <input type="submit" name="submit" value="ÖDE">
					</div>
					</section>

				</form>
			</div>

		</div>
		
		<div class="clear"> </div>
	</div>
</div>
<!-- //Main -->

<!-- footer -->
<div class="footer-w3l">
	<p>Copyright &copy; <a href="https://www.robotistan.com/">Robotistan Elektronik Ticaret AŞ</a> Tüm hakları saklıdır.</p>
</div>
<!-- //footer -->

	<!-- js-scripts-->
		<script type="text/javascript" src="js/jquery-2.1.4.min.js"></script>
		
	<!-- credit-card -->
		<script type="text/javascript" src="js/creditly.js"></script>
		<script type="text/javascript">
            $(function () {
                var creditly = Creditly.initialize(
                    '.creditly-wrapper .expiration-month-and-year',
                    '.creditly-wrapper .credit-card-number',
                    '.creditly-wrapper .security-code',
                    '.creditly-wrapper .card-type');

                $(".creditly-card-form .submit").click(function (e) {
                    e.preventDefault();
                    var output = creditly.validate();
                    if (output) {
                        // Your validated credit card output
                        console.log(output);
                    }
                });
            });
        </script>
	<!-- //credit-card -->

	<!-- //js-scripts-->
</body>
</html>