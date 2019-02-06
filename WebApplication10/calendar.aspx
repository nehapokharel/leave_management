<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="WebApplication10.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
           margin:0px auto;
            background-color:cadetblue;
        }
        .calenderbody{
            margin-top:13%;
            margin-bottom:13%;
            width:100%;
            
        }
       
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPH1" runat="server">
    <div class="calenderbody">           
    <asp:Calendar ID="Calendar1" runat="server" CssClass="auto-style1" Width="735px" ></asp:Calendar>
        </div> 
</asp:Content>
