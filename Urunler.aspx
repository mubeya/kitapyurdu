<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="eTicaretSayfasi.Urunler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
.dvUrun
{
    border: 2px dotted Red;
    text-align: center;
    padding: 5px;
    margin:5px;
    color:Black;
    background-color:White;
}
.dvUrun:hover
{
    background-color:White;
}    

img
{
    width:150px;
    height:150px;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <asp:DataList ID="DataList1" runat="server" RepeatColumns="5" Height="278px" 
        Width="81px">
        <ItemTemplate>
            <div class="dvUrun">
            <div style="height:100px; width:200px"> <%#Eval("UrunAd") %> </div>
                <a href="WebForm1.aspx?cid=<%#Eval("UrunID") %>"> <asp:Image ID="Image1" ImageUrl='<%#Eval("ResimAdres")%>' runat="server" /></a> <br />
                <%#Eval("UrunUcret") %> TL
            </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>


 
