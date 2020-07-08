<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ragisteration.aspx.cs" Inherits="Note_Project.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="maincontent" runat="server">
    <table style="width: 100%; color: #FFFF99; background-color: #3366FF; margin-right: 0px;">
    <tr>
        <td style="width: 206px">username</td>
        <td style="width: 228px">
            <asp:TextBox ID="txt_name" runat="server" Width="209px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_name" ErrorMessage="you must enter your name" ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 206px">age</td>
        <td style="width: 228px">
            <asp:TextBox ID="txt_age" runat="server" Width="209px"></asp:TextBox>
        </td>
        <td>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txt_age" Display="Dynamic" ErrorMessage="age must between 20 and 60" ForeColor="Red" MaximumValue="60" MinimumValue="20">invalid age</asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_age" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 206px">password</td>
        <td style="width: 228px">
            <asp:TextBox ID="txt_password" runat="server" TextMode="Password" Width="210px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 206px">confirm-password</td>
        <td style="width: 228px">
            <asp:TextBox ID="txt_confirm" runat="server" TextMode="Password" Width="211px"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txt_password" ControlToValidate="txt_confirm" ErrorMessage="CompareValidator" ForeColor="Red">not match !</asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 206px">email</td>
        <td style="width: 228px">
            <asp:TextBox ID="txt_email" runat="server" Width="210px"></asp:TextBox>
        </td>
        <td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_email" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">invalid email</asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 206px">gender</td>
        <td style="width: 228px">
            <asp:RadioButtonList ID="rbl_gender" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>male</asp:ListItem>
                <asp:ListItem>female</asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="rbl_gender" ErrorMessage="you must enter your gender" ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    
    <tr>
            <td style="width: 206px">
                &nbsp;</td>
        <td style="width: 228px">
            <table style="width: 100%">
                <tr>
                    <td style="width: 28px">
            <asp:Button ID="btn_register" runat="server" OnClick="btn_register_Click" Text="register" BackColor="#FFCC99" ForeColor="#009933" Width="81px" />
                    </td>
                    <td style="width: 15px">&nbsp;</td>
                    <td style="width: 82px">
                        &nbsp;</td>
                </tr>
            </table>
        </td>
    
        <td>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </td>
    </tr>
</table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
