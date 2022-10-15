﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="Odev6_TicariAlisverisSitesi.LoginRegister" %>

<!DOCTYPE html>
<html>

<head>
<title>Robotistan | Elektronik Malzeme Marketi Online Satış</title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content=" Master  Login Form Widget Tab Form,Login Forms,Sign up Forms,Registration Forms,News letter Forms,Elements"/>
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<link href="Giris/css/style.css" rel="stylesheet" type="text/css" media="all" />
<link href="//fonts.googleapis.com/css?family=Cormorant+SC:300,400,500,600,700" rel="stylesheet">
<link href="//fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i" rel="stylesheet">
</head>

<body>
	<div class="padding-all">

		<div class="header">
			<div style="margin-top:45px">
				<h1>Üye Giriş Sayfası</h1>
			</div>
		</div>

		<div class="design-w3l">
			<div class="mail-form-agile">
				<form action="#" method="post" runat="server">
                    <asp:TextBox ID="TxtMail" runat="server" placeholder="Email"></asp:TextBox>
                    <asp:TextBox ID="TxtSifre" runat="server" placeholder="Şifre" TextMode="Password"></asp:TextBox>
					<div style="margin-top:15px"> 
						<asp:Button ID="BtnGiris" runat="server" Text="Giriş Yap" OnClick="BtnGiris_Click" />
					</div>
					<div style="margin-top:15px">
                        <strong>
                    <asp:Label ID="Label1" runat="server" Font-Size="X-Large" ForeColor="White"></asp:Label>
					    </strong>
					</div>
				</form>
			</div>
		  <div class="clear"> </div>
		</div>
		
		<div class="footer">
         <p>Copyright &copy; <a href="https://www.robotistan.com/">Robotistan Elektronik Ticaret AŞ</a> Tüm hakları saklıdır.</p>
		</div>

	</div>
</body>
</html>