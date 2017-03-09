<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UrunDetay.aspx.cs" Inherits="eTicaretSayfasi.UrunDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style type="text/css">
            #dvUrunDetay
             {
                 width:119%;
             }
             
            #dvResim
            {
                width:30%;
                float:left;
            }
            
            #dvDetay
            {
                width:70%;
                float:left;
            }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:DataList ID="DataList2" runat="server" RepeatColumns="4">
    </asp:DataList>
    
</asp:Content>


