<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="profilewriter.aspx.cs" Inherits="Note_Project.profilewriter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="maincontent" runat="server">
    <div style="text-align:center; color: #FF99FF; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; background-color: #0033CC;">
            <h1>profile</h1>
            <p>your name&nbsp;
                <asp:Label ID="lbl_name" runat="server"></asp:Label>
            </p>
            <p>age:
                <asp:Label ID="lbl_age" runat="server" Text="Label"></asp:Label>
            </p>
            <p>address :
                <asp:Label ID="lbl_address" runat="server" Text="Label"></asp:Label>
                  &nbsp;</p>
            <p>email:<asp:Label ID="lbl_email" runat="server" Text="Label"></asp:Label>&nbsp;</p>

        <p>   gender:<asp:Label ID="lbl_gender" runat="server" Text="Label"></asp:Label>&nbsp;</p>
             <tr>
        <td style="width: 206px">password</td>
        <td style="width: 228px">
            <asp:TextBox ID="txt_password" runat="server" TextMode="Password" Width="210px"></asp:TextBox>
        </td>
        <td><asp:Button ID="btn_login" runat="server" OnClick="btn_update_Click" Text="update" ValidationGroup="g1" BackColor="#FF3399" ForeColor="#003366" BorderColor="#CC66FF" style="left: 0px; top: 0px; width: 106px; margin-left: 31px" /></td>
    </tr>
            <p><asp:Button ID="Button1" runat="server" OnClick="btn_add_Click" Text="AddNote" ValidationGroup="g1" BackColor="#CCFFFF" ForeColor="#003366" BorderColor="#CC66FF" style="left: 0px; top: 0px; width: 106px; margin-left: 31px" /></p>
            
        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
