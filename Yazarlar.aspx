<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Yazarlar.aspx.cs" Inherits="eTicaretSayfasi.Yazarlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList2" runat="server" Height="83px" Width="742px" 
    BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
    CellPadding="4" GridLines="Both" CellSpacing="2" ForeColor="Black" 
        RepeatColumns="2" style="margin-left: 160px" 
    onitemcommand="DataList2_ItemCommand">

        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <ItemStyle BackColor="White" />

      <ItemTemplate>
          <asp:LinkButton ID="LinkButton1" runat="server" Text='<%#Eval("YazarAd") %>' CommandName='<%#Eval("YazarAd") %>' CommandArgument='<%#Eval("YazarID") %>'>LinkButton</asp:LinkButton>
          </ItemTemplate>
        <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
      <SeparatorTemplate>
          <br />
      </SeparatorTemplate>
    </asp:DataList>
</asp:Content>
