<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.master" AutoEventWireup="true" CodeBehind="Acceptance.aspx.cs" Inherits="WebApplication10.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 365px; color:snow; text-align:center; padding-top:20px;">
        <p> Click the button to know the information of your leave request.</p>
        <asp:Button ID="btn_acceptance" runat="server" Text="Click_me" OnClick="btn_acceptance_Click" />
        <asp:Label ID="lblresult" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
