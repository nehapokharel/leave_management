<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Teacher.aspx.cs" Inherits="WebApplication10.Teacher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 506px;
            height: 225px;
            margin-left: 387px;
            margin-top: 135px;
            margin-bottom: 125px;
            background-color:whitesmoke;
            padding-left:15px;
            padding-bottom:5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPH1" runat="server">
    <div class="auto-style1">
        <br />
        Leave Id:<asp:Label ID="lbllid" runat="server" Text=""></asp:Label><br /> <br/>
        Student Name:<asp:Label ID="lblsname" runat="server" Text=""></asp:Label><br /> <br/>
        No of days:<asp:Label ID="lbldays" runat="server" Text=""></asp:Label><br /> <br/>
        Start Date:<asp:Label ID="lblsdate" runat="server" Text=""></asp:Label><br /> <br/>
        End Date:<asp:Label ID="lbledate" runat="server" Text=""></asp:Label><br /> <br/>
        Reason:<asp:Label ID="lblreason" runat="server" Text=""></asp:Label><br /> <br/>
        <asp:Button ID="btnAccept" runat="server" OnClick="lbAccept_Click" Text="Accept" />
        <asp:Button ID="btnDecline" runat="server" OnClick="lbDecline_Click" Text="Decline" />   
        <br />   
    </div>
</asp:Content>
