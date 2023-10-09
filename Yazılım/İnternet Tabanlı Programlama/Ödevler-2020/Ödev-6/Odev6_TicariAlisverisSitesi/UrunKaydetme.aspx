<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UrunKaydetme.aspx.cs" Inherits="Odev6_TicariAlisverisSitesi.UrunKaydetme" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>Robotistan | Elektronik Malzeme Marketi Online Satış</title>

    <!-- Meta-Tags -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8">
    <meta name="keywords" content="Space Register Form a Responsive Web Template, Bootstrap Web Templates, Flat Web Templates, Android Compatible Web Template, Smartphone Compatible Web Template, Free Webdesigns for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design">
    <script>
        addEventListener("load", function () {
            setTimeout(hideURLbar, 0);
        }, false);

        function hideURLbar() {
            window.scrollTo(0, 1);
        }
    </script>
    <!-- //Meta-Tags -->

    <!-- css files -->
    <link href="Guncelle/css/style.css" rel="stylesheet" type="text/css" media="all" />
    <!-- css files -->

    <!-- Online-fonts -->
    <link href="//fonts.googleapis.com/css?family=Montserrat:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i&amp;subset=latin-ext,vietnamese" rel="stylesheet">
    <!-- //Online-fonts -->

    <style type="text/css">
        .auto-style1 {
            color: #FFFFFF;
        }
        .auto-style2 {
            font-weight: bold;
        }
    </style>

</head>
<body>

    <!-- Main Content -->
    <div class="main">
        <div class="main-w3l">
            <h1 class="logo-w3"></h1>
            <div class="w3layouts-main">
                <h2><span>Ürün Kaydetme Sayfası</span></h2>
                <form action="#" method="post" runat="server">
                    <strong>
                    <asp:TextBox ID="TxtAd" runat="server" placeholder="AD" Font-Size="Large"></asp:TextBox>
                    <asp:TextBox ID="TxtKategori" runat="server" placeholder="KATEGORİ" Font-Size="Large"></asp:TextBox>
                    <asp:TextBox ID="TxtMarka" runat="server" placeholder="MARKA" Font-Size="Large"></asp:TextBox>
                    <asp:TextBox ID="TxtFiyat" runat="server" placeholder="FİYAT" Font-Size="Large"></asp:TextBox>
                    <asp:TextBox ID="TxtOzellik" runat="server" placeholder="ÖZELLİK" Font-Size="Large"></asp:TextBox>
                        <asp:TextBox ID="TxtResim" runat="server" placeholder="RESİM" Font-Size="Large"></asp:TextBox>
                    <asp:Button ID="BtnGuncelle" runat="server" Text="Kaydet" OnClick="BtnKaydet_Click" CssClass="auto-style2" Font-Size="Large"/>
                    </strong>
                    <br />
                    <br />
                    <strong>
                    <asp:Label ID="LblAcıklama" runat="server" CssClass="auto-style1" Font-Size="Large"></asp:Label>
                    </strong>
                </form>
            </div>
        <!-- //main -->

        <!--footer-->
        <div class="footer-w3l">
            <p>Copyright &copy; <a href="https://www.robotistan.com/"><span class="auto-style1">Robotistan Elektronik Ticaret AŞ</span></a> Tüm hakları saklıdır.</p>
        </div>
        <!--//footer-->

        </div>
    </div>
    <!-- //Main Content -->

</body>
</html>
