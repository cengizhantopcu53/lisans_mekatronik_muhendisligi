<%@ Page Title="" Language="C#" MasterPageFile="~/Sablon.Master" AutoEventWireup="true" CodeBehind="HesapMakinasi.aspx.cs" Inherits="Odev3_PopulerUygulamalarWebSayfasi.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style21 {
            width: 61%;
            margin-left: 110px;
        }
        .auto-style22 {
            width: 31px;
        }
        .auto-style34 {
            width: 50px;
            height: 28px;
        }
        .auto-style35 {
            width: 50px;
        }
        .auto-style41 {
            width: 50px;
            height: 27px;
        }
        .auto-style44 {
            text-align: left;
        }
        .auto-style45 {
            width: 59px;
            height: 27px;
        }
        .auto-style46 {
            width: 59px;
            height: 28px;
        }
        .auto-style47 {
            width: 59px;
        }
        .auto-style48 {
            width: 61px;
            height: 27px;
        }
        .auto-style49 {
            width: 61px;
            height: 28px;
        }
        .auto-style50 {
            width: 61px;
        }
        .auto-style51 {
            width: 57px;
            height: 27px;
        }
        .auto-style52 {
            width: 57px;
            height: 28px;
        }
        .auto-style53 {
            width: 57px;
        }
        .auto-style54 {
            width: 60px;
            height: 27px;
        }
        .auto-style55 {
            width: 60px;
            height: 28px;
        }
        .auto-style56 {
            width: 60px;
        }
        .auto-style57 {
            font-weight: bold;
        }
        .auto-style58 {
            font-weight: bold;
            color: #FF0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Image ID="Image2" runat="server" ImageUrl="~/Resimler/HESAP MAKİNASI.png" />
    <br />
    &nbsp;<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtEkran" runat="server" Height="37px" Width="306px"></asp:TextBox>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <table class="auto-style21">
        <tr>
            <td class="auto-style54">
                <strong>
                <asp:Button ID="Btn1" runat="server" Height="40px" Text="1" Width="60px" CssClass="auto-style57" Font-Size="Larger" OnClick="Button10_Click" />
                </strong>
            </td>
            <td class="auto-style41">
                <strong>
                <asp:Button ID="Btn2" runat="server" Height="40px" Text="2" Width="60px" CssClass="auto-style57" Font-Size="Larger" OnClick="Button13_Click" />
                </strong>
            </td>
            <td class="auto-style45">
                <strong>
                <asp:Button ID="Btn3" runat="server" Height="40px" Text="3" Width="60px" CssClass="auto-style57" Font-Size="Larger" OnClick="Button16_Click" />
                </strong>
            </td>
            <td class="auto-style22" rowspan="4">&nbsp;</td>
            <td class="auto-style48">
                <strong>
                <asp:Button ID="BtnTopla" runat="server" Height="40px" Text="+" Width="60px" CssClass="auto-style58" Font-Size="Larger" OnClick="BtnTopla_Click" />
                </strong>
            </td>
            <td class="auto-style51">
                <strong>
                <asp:Button ID="BtnSilme" runat="server" Height="40px" Text="C" Width="60px" CssClass="auto-style58" Font-Size="Larger" OnClick="BtnSilme_Click" />
                </strong>
            </td>
        </tr>
        <tr>
            <td class="auto-style55">
                <strong>
                <asp:Button ID="Btn4" runat="server" Height="40px" Text="4" Width="60px" CssClass="auto-style57" Font-Size="Larger" OnClick="Button11_Click" />
                </strong>
            </td>
            <td class="auto-style34">
                <strong>
                <asp:Button ID="Btn5" runat="server" Height="40px" Text="5" Width="60px" CssClass="auto-style57" Font-Size="Larger" OnClick="Button14_Click" />
                </strong>
            </td>
            <td class="auto-style46">
                <strong>
                <asp:Button ID="Btn6" runat="server" Height="40px" Text="6" Width="60px" CssClass="auto-style57" Font-Size="Larger" OnClick="Button17_Click" />
                </strong>
            </td>
            <td class="auto-style49">
                <strong>
                <asp:Button ID="BtnCikarma" runat="server" Height="40px" Text="-" Width="60px" CssClass="auto-style58" Font-Size="Larger" OnClick="BtnCikarma_Click" />
                </strong>
            </td>
            <td class="auto-style52">
                <strong>
                <asp:Button ID="BtnHaneSilme" runat="server" Height="40px" Text="&lt;--" Width="60px" CssClass="auto-style58" Font-Size="Larger" OnClick="BtnHaneSilme_Click" />
                </strong>
            </td>
        </tr>
        <tr>
            <td class="auto-style56">
                <strong>
                <asp:Button ID="Btn7" runat="server" Height="40px" Text="7" Width="60px" CssClass="auto-style57" Font-Size="Larger" OnClick="Button12_Click" />
                </strong>
            </td>
            <td class="auto-style35">
                <strong>
                <asp:Button ID="Btn8" runat="server" Height="40px" Text="8" Width="60px" CssClass="auto-style57" Font-Size="Larger" OnClick="Button15_Click" />
                </strong>
            </td>
            <td class="auto-style47">
                <strong>
                <asp:Button ID="Btn9" runat="server" Height="40px" Text="9" Width="60px" CssClass="auto-style57" Font-Size="Larger" OnClick="Button18_Click" />
                </strong>
            </td>
            <td class="auto-style50">
                <strong>
                <asp:Button ID="BtnCarpma" runat="server" Height="40px" Text="*" Width="60px" CssClass="auto-style58" Font-Size="Larger" OnClick="BtnCarpma_Click" />
                </strong>
            </td>
            <td class="auto-style53" rowspan="2">
                <strong>
                <asp:Button ID="BtnEsittir" runat="server" Height="80px" Text="=" Width="60px" CssClass="auto-style58" Font-Size="Larger" OnClick="BtnEsittir_Click" />
                </strong>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="auto-style44">
                <strong>
                <asp:Button ID="Btn0" runat="server" Height="40px" Text="0" Width="128px" CssClass="auto-style57" Font-Size="Larger" OnClick="Button25_Click" />
                </strong>
            </td>
            <td class="auto-style47">
                <strong>
                <asp:Button ID="BtnNokta" runat="server" Height="40px" Text="." Width="60px" CssClass="auto-style57" Font-Size="Larger" OnClick="Button26_Click" />
                </strong>
            </td>
            <td class="auto-style50">
                <strong>
                <asp:Button ID="BtnBolme" runat="server" Height="40px" Text="/" Width="60px" CssClass="auto-style58" Font-Size="Larger" OnClick="BtnBolme_Click" />
                </strong>
            </td>
        </tr>
    </table>
    <br />
&nbsp;
</asp:Content>
