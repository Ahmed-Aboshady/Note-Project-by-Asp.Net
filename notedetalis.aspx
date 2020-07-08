<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="notedetalis.aspx.cs" Inherits="Note_Project.notedetalis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="maincontent" runat="server">
     <table style="width: 100%; color: #FFFF99; background-color: #3366FF; margin-right: 0px;">
    <tr>
        <td style="width: 163px">Titel</td>
        <td style="width: 311px">
            <asp:TextBox ID="txt_name" runat="server" Width="209px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_name" ErrorMessage="you must enter TItel" ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 163px">bref</td>
        <td style="width: 311px">
            <asp:TextBox ID="txt_bref" runat="server" Width="209px"></asp:TextBox>
        </td>
        <td>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_name" ErrorMessage="you must enter bref" ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 163px">describe</td>
        <td style="width: 311px">
            <asp:TextBox ID="txt_descibe" runat="server" Width="281px" Height="136px" style="margin-right: 10px"></asp:TextBox>
        </td>
        <td>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_name" ErrorMessage="you must enter describe" ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 163px">datatime</td>
        <td style="width: 311px">
            <table style="width: 100%">
                <tr>
                    <td style="width: 96px">Day&nbsp; </td>
                    <td style="width: 103px">Month</td>
                    <td>Year </td>
                </tr>
                <tr>
                    
                                <td class="auto-style2" style="width: 96px">
                                    <asp:DropDownList ID="DropDownList1" runat="server" >
                                    </asp:DropDownList>
                                </td>
                                <td class="auto-style4" style="width: 103px">
                                    <asp:DropDownList ID="DropDownList2" runat="server">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList3" runat="server">
                                    </asp:DropDownList>
                                </td>
                           
                </tr>
            </table>
        </td>
        <td>

        </td>
    </tr>
    <tr>
        <td style="width: 163px">catalogs</td>
        <td style="width: 311px">
            <asp:DropDownList ID="ddl_cat" runat="server">
            </asp:DropDownList>
        </td>
        
    </tr>
    <tr>
        <td style="width: 163px">tour name</td>
        <td style="width: 311px">
            <asp:DropDownList ID="ddl_user" runat="server">
            </asp:DropDownList>
        </td>
        
            </tr>
    
    <tr>
            <td style="width: 163px">
                &nbsp;</td>
        <td style="width: 311px">
            <table style="width: 100%">
                <tr>
                   
                    <td style="width: 15px">
            <asp:Button ID="btn_register" runat="server" OnClick="btn_register_Click" Text="Add" BackColor="#FFCC99" ForeColor="#009933" Width="81px" />
                    </td>
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
