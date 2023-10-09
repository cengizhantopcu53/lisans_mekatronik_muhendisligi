<%@ Page Title="" Language="C#" MasterPageFile="~/Sablon.Master" AutoEventWireup="true" CodeBehind="KayitForm.aspx.cs" Inherits="Odev5_UrunKayitFormuveListeleme.KayitForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4 {
        color: #443B22;
    }
    .auto-style5 {
        font-size: small;
        font-weight: bold;
    }
    .auto-style6 {
        color: #443B22;
        font-weight: bold;
    }
        .auto-style7 {
            color: #CC3300;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Resimler/KAYIT FORMU.png" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
<asp:Image ID="Image5" runat="server" Height="22px" ImageUrl="~/Resimler/icons8_save_100px.png" Width="26px" />
&nbsp;<span class="auto-style4"><strong>MAĞAZA KAYDETME&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></span><br />
&nbsp;&nbsp;&nbsp;<span class="auto-style4">
<strong>Mağaza Adı:</strong></span>
<asp:TextBox ID="TxtMgz" runat="server"></asp:TextBox>
&nbsp;<strong><asp:Button ID="BtnMgzKydt" runat="server" OnClick="BtnMgzKydt_Click" Text="Mağazayı Kaydet" Width="161px" BackColor="White" CssClass="auto-style5" ForeColor="#443B22" BorderColor="#443B22" />
        </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
<br />
&nbsp;&nbsp;&nbsp;
<asp:Image ID="Image4" runat="server" Height="22px" ImageUrl="~/Resimler/icons8_save_100px.png" Width="26px" />
<span class="auto-style4"><strong>&nbsp;KATEGORİ KAYDETME</strong></span><br />
&nbsp;&nbsp;&nbsp;<span class="auto-style4"> </span> <strong><span class="auto-style4">Mağaza Seç:</span> </strong>
&nbsp;<strong><asp:DropDownList ID="DDwnMgzToKtgr" runat="server" Height="20px" Width="209px" CssClass="auto-style6">
</asp:DropDownList>
</strong>&nbsp;<br />
&nbsp;&nbsp;&nbsp; <span class="auto-style4"> <strong>Kategori Adi:</strong></span>
<asp:TextBox ID="TxtKtgr" runat="server"></asp:TextBox>
&nbsp;<strong><asp:Button ID="BtnKtgrKydt" runat="server" OnClick="BtnKtgrKydt_Click" Text="Kategoriyi Kaydet" Width="168px" CssClass="auto-style5" BackColor="White" BorderColor="#443B22" />
        </strong>&nbsp;<br />
        <br />
        &nbsp;&nbsp;&nbsp; <span class="auto-style4"><strong>
<asp:Image ID="Image6" runat="server" Height="22px" ImageUrl="~/Resimler/icons8_save_100px.png" Width="26px" />
&nbsp;ÜRÜN KAYDETME </strong></span><br />
&nbsp;&nbsp;&nbsp;<strong> <span class="auto-style4">Mağaza Seç:</span></strong>
<em><strong>
<asp:DropDownList ID="DDwnMgzToUrun" runat="server" AutoPostBack="True" Height="20px" OnSelectedIndexChanged="DDwnMgzToUrun_SelectedIndexChanged" Width="209px" CssClass="auto-style6">
</asp:DropDownList>
        </strong></em>
        <br />
        &nbsp;&nbsp;&nbsp;<strong> <span class="auto-style4">Kategori Seç:</span></strong>
<strong>
<asp:DropDownList ID="DDwnKtrgrToUrun" runat="server" Height="20px" Width="209px" CssClass="auto-style6">
</asp:DropDownList>
</strong>
<span class="auto-style4"><strong>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Image ID="Image8" runat="server" Height="66px" ImageUrl="~/Resimler/icons8_used_product_100px_1.png" Width="79px" />
ÜRÜN BİLGİLERİ&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Adı:<asp:TextBox ID="TxtUrunAdi" runat="server"></asp:TextBox>
&nbsp;<span class="auto-style7">*</span><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtUrunAdi" CssClass="auto-style7" ErrorMessage="Bu alanın doldurulması zorunludur!" ValidationGroup="KaydetGrup"></asp:RequiredFieldValidator>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Markası:<asp:TextBox ID="TxtUrunMarkasi" runat="server"></asp:TextBox>
&nbsp;<span class="auto-style7">*<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtUrunMarkasi" CssClass="auto-style7" ErrorMessage="Bu alanın doldurulması zorunludur!" ValidationGroup="KaydetGrup"></asp:RequiredFieldValidator>
        </span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Fiyatı:<asp:TextBox ID="TxtUrunFiyati" runat="server"></asp:TextBox>
&nbsp;</span><span class="auto-style7">*<span class="auto-style4"><asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TxtUrunFiyati" CssClass="auto-style7" ErrorMessage="Bu alanın doldurulması zorunludur!" ValidationGroup="KaydetGrup"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span></span><span class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Satış Tarihi:<asp:TextBox ID="TxtUrunSatisTarihi" runat="server"></asp:TextBox>
&nbsp;<span class="auto-style7">*</span></span><asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="TxtUrunSatisTarihi" CssClass="auto-style7" ErrorMessage="Tarih formatı yanlıştır!" Operator="DataTypeCheck" Type="Date" ValidationGroup="KaydetGrup"></asp:CompareValidator>
        <span class="auto-style4"><span class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Fotoğraf:&nbsp;<asp:FileUpload ID="FileUploadFoto" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
&nbsp;&nbsp;&nbsp; Teslim Edildi:<asp:RadioButton ID="RadioButton1" runat="server" Text="Evet" />
&nbsp;<asp:RadioButton ID="RadioButton2" runat="server" Text="Hayır" />
&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        &nbsp;&nbsp;&nbsp;
<asp:Image ID="Image11" runat="server" Height="66px" ImageUrl="~/Resimler/icons8_customer_100px.png" Width="79px" />
MÜŞTERİ BİLGİLERİ<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Adı:<asp:TextBox ID="TxtMusteriAdi" runat="server"></asp:TextBox>
&nbsp;<span class="auto-style7">*<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtMusteriAdi" CssClass="auto-style7" ErrorMessage="Bu alanın doldurulması zorunludur!" ValidationGroup="KaydetGrup"></asp:RequiredFieldValidator>
        </span>
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Soyadı:<asp:TextBox ID="TxtMusteriSoyadi" runat="server"></asp:TextBox>
&nbsp;<span class="auto-style7">*<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TxtMusteriSoyadi" CssClass="auto-style7" ErrorMessage="Bu alanın doldurulması zorunludur!" ValidationGroup="KaydetGrup"></asp:RequiredFieldValidator>
        </span>
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Telefon No:<asp:TextBox ID="TxtMusteriTlfNo" runat="server"></asp:TextBox>
&nbsp;<span class="auto-style7">*</span><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TxtMusteriTlfNo" CssClass="auto-style7" ErrorMessage="Telefon formatı yanlıştır!" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" ValidationGroup="KaydetGrup"></asp:RegularExpressionValidator>
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Mail:<asp:TextBox ID="TxtMusteriMail" runat="server"></asp:TextBox>
        &nbsp;<span class="auto-style7">*</span><asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TxtMusteriMail" CssClass="auto-style7" ErrorMessage="Mail formatı yanlıştır!" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="KaydetGrup"></asp:RegularExpressionValidator>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
<br />
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:Button ID="BtnUrunKydt" runat="server" OnClick="BtnUrunKydt_Click" Text="Ürünü Kaydet" Width="170px" CssClass="auto-style5" BackColor="White" BorderColor="#443B22" Height="49px" ValidationGroup="KaydetGrup" />
<br />
        </span>
</strong>
        <br />
</asp:Content>
