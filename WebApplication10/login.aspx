<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication10.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
        .auto-style1 {
            width: 37%;
            height: 274px;
            margin:9% 30% ;
            
            background-color:gainsboro;

        }
        .auto-style6 {
            width: 310px;
        }
        .auto-style9 {
            width: 134px;
            height: 40px;
        }
        .auto-style10 {
            height: 40px;
            width: 641px;
        }
        .auto-style12 {
            width: 134px;
            height: 33px;
        }
        .auto-style13 {
            width: 641px;
            height: 33px;
        }
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPH1" runat="server">
     
            <table class="auto-style1">
                <tr>
                    <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; EASY-LEAVE&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">ID Number:</td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtid" runat="server" Width="310px"></asp:TextBox>
                    </td> 
                </tr>
                <tr>
                    <td class="auto-style12">Full Name:</td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtfname" runat="server" Width="310px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">Password:</td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtpassword" runat="server" Width="310px" TextMode="Password" /></td>
                </tr>
                <tr>
                    <td class="auto-style12">Department:</td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtdepartment" runat="server" Width="310px"></asp:TextBox>
                    </td>
                </tr>
               
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style10">
                        <asp:Button ID="txtteacher" runat="server" Text="Login as Teacher" Width="168px" OnClick="txtteacher_Click" />
&nbsp;&nbsp;
                        <asp:Button ID="txtstudent" runat="server" Text="Login as Student" Width="155px" OnClick="txtstudent_Click" />
                    </td>
                </tr>
               
                </table>
</asp:Content>
