<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.master" AutoEventWireup="true" CodeBehind="Apply.aspx.cs" Inherits="WebApplication10.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    <table style="width:80%; background-color:gainsboro; height:300px; margin-left:10%;">
        <tr>
            <td>Student Name:</td>
            <td><asp:TextBox runat="server" ID="sname"></asp:TextBox></td>
          
        </tr>
        <tr>
            <td>Number of days:</td>
            <td><asp:TextBox runat="server" ID="days"></asp:TextBox></td>
          
        </tr>
        <tr>
            <td>Start-date:</td>
            <td><asp:TextBox runat="server" ID="startdate" ></asp:TextBox></td> 
        </tr>
        <tr>
            <td>End-date:</td>
            <td><asp:TextBox runat="server" ID="enddate"></asp:TextBox></td> 
        </tr>
        <tr>
            <td>Reason for leave:</td>
            <td><asp:TextBox runat="server" ID="reason" Height="100px"></asp:TextBox></td> 
        </tr>
        <tr>
           <td><asp:Button runat="server" ID="btnsubmit" Text="Submit"  OnClick="btnsubmit_Click"/></td> 
        </tr>
    </table>
   

</asp:Content>
