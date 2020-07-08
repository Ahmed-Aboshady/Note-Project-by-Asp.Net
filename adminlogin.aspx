<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="Note_Project.adminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="maincontent" runat="server">
    <table class="auto-style1" style="width: 523px; margin-bottom: 71px; color: #CC33FF; background-color: #6600CC;">
                <tr>
                    <td>userName</td>
                    <td>
                        <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="txt_pass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    
                    <td>&nbsp;</td>
                    <td>
                        <asp:CheckBox ID="chb_remeberme" runat="server" Text="remeber me" />
                    </td>
                    <td>
                        <asp:Label ID="lbl_status" runat="server"></asp:Label>
                    </td>
                
                </tr>
                <tr>
                    <td style="height: 56px"></td>
                    <td style="height: 56px">
                       <asp:Button ID="btn_login" runat="server" OnClick="btn_login_Click" Text="login" style="height: 30px;width:100px" BackColor="#6699FF" BorderColor="#CC00FF"  />
                        
                    </td>
                    <td style="height: 56px"></td>
                </tr>
            </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
