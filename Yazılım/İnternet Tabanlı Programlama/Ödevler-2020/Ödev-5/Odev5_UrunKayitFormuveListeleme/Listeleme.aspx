<%@ Page Title="" Language="C#" MasterPageFile="~/Sablon.Master" AutoEventWireup="true" CodeBehind="Listeleme.aspx.cs" Inherits="Odev5_UrunKayitFormuveListeleme.Listeleme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Image ID="Image2" runat="server" ImageUrl="~/Resimler/LİSTELEME.png" />
    <br />
&nbsp;<br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;
   <strong>
   <asp:Button ID="BtnUrunList" runat="server" Text="Ürünleri Listele" Width="205px" CssClass="auto-style5" BackColor="White" BorderColor="#443B22" Height="46px" OnClick="BtnUrunList_Click" style="font-weight: bold" />
    </strong>&nbsp;<br />
&nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="UrunAD" HeaderText="UrunAD" SortExpression="UrunAD" />
            <asp:BoundField DataField="UrunMarkası" HeaderText="UrunMarkası" SortExpression="UrunMarkası" />
            <asp:BoundField DataField="UrunFiyat" HeaderText="UrunFiyat" SortExpression="UrunFiyat" />
            <asp:BoundField DataField="UrunSatısTarihi" HeaderText="UrunSatısTarihi" SortExpression="UrunSatısTarihi" />
            <asp:BoundField DataField="MusteriAd" HeaderText="MusteriAd" SortExpression="MusteriAd" />
            <asp:BoundField DataField="MusteriTelefon" HeaderText="MusteriTelefon" SortExpression="MusteriTelefon" />
            <asp:CheckBoxField DataField="UrunTeslimEdildi" HeaderText="UrunTeslimEdildi" SortExpression="UrunTeslimEdildi" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UrunVeriTabaniConnectionString %>" ProviderName="<%$ ConnectionStrings:UrunVeriTabaniConnectionString.ProviderName %>" SelectCommand="SELECT [UrunAD], [UrunMarkası], [UrunFiyat], [UrunSatısTarihi], [MusteriAd], [MusteriTelefon], [UrunTeslimEdildi] FROM [TBL_URUNLER]"></asp:SqlDataSource>
    <br />
    <br />
    <br />
&nbsp;
</asp:Content>
