<%@ Page Title="" Language="C#" MasterPageFile="~/Sablon.Master" AutoEventWireup="true" CodeBehind="IdealKiloHesaplama.aspx.cs" Inherits="Odev3_PopulerUygulamalarWebSayfasi.IdealKiloHesaplama" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Image ID="Image2" runat="server" ImageUrl="~/Resimler/İDEAL KİLO HESAPLAMA.png" />
    <br />
    &nbsp;<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Kilonuzu Girin:"></asp:Label>
&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Boyunuzu Girin:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button1" runat="server" CssClass="auto-style18" Height="38px" Text="GÖSTER" Width="130px" OnClick="Button1_Click" style="margin-left: 153px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" BackColor="#33CC33" Height="38px" OnClick="Button2_Click" Text="Temizle" Width="91px" />
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Label ID="Label2" runat="server" Text="SONUCUNUZ HESAPLANIYOR ..."></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Image ID="Image3" runat="server" Height="80px" ImageUrl="~/Resimler/İDEAL KİLO HESAPLAMA-GÖRSEL1.jpg" Visible="False" Width="100px" />
&nbsp;
    <asp:Image ID="Image4" runat="server" Height="80px" ImageUrl="~/Resimler/İDEAL KİLO HESAPLAMA-GÖRSEL2.jpg" Visible="False" Width="100px" />
&nbsp;
    <asp:Image ID="Image5" runat="server" Height="80px" ImageUrl="~/Resimler/İDEAL KİLO HESAPLAMA-GÖRSEL3.jpg" Visible="False" Width="100px" />
    <br />
&nbsp; 
</asp:Content>
