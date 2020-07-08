<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="loginwriter.aspx.cs" Inherits="Note_Project.loginwriter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="maincontent" runat="server">
      <table class="auto-style1" style="width: 772px; margin-bottom: 71px; color: #FFFFCC; background-color: #3366FF;">
                <tr>
                    <td style="width: 234px">userName</td>
                    <td>
                        <asp:TextBox ID="txt_name" runat="server" Width="238px"></asp:TextBox>
                    </td>
                    <td style="width: 139px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="height: 32px; width: 234px">Password</td>
                    <td style="height: 32px">
                        <asp:TextBox ID="txt_pass" runat="server" TextMode="Password" style="margin-left: 0px" Width="238px"></asp:TextBox>
                    </td>
                    <td style="width: 139px; height: 32px"></td>
                </tr>
                <tr>
                    
                    <td style="width: 234px">&nbsp;</td>
                    <td>
                        <asp:CheckBox ID="chb_remeberme" runat="server" Text="remeber me" />
                    </td>
                    <td style="width: 139px">
                        <asp:Label ID="lbl_status" runat="server"></asp:Label>
                    </td>
                
                </tr>
                <tr>
                    <td style="height: 56px; width: 234px;"></td>
                    <td style="height: 56px">
                       <asp:Button ID="btn_login" runat="server" OnClick="btn_login_Click" Text="login" style="height: 30px;width:100px" BackColor="#66FF33" BorderColor="#CC00FF"  />
                        
                    </td>
                    <td style="height: 56px; width: 139px;"></td>
                </tr>
            </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
