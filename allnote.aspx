<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="allnote.aspx.cs" Inherits="Note_Project.allnote" %>
<asp:Content ID="Content1" ContentPlaceHolderID="maincontent" runat="server">
    <p style="color: #00FF00; background-color: #FFFF99; font-size: x-large; width: 787px; font-family: 'Agency FB';text-align:center">
     This is show Notes</p>
    <table style="width: 100%">
    <tr>
        <td style="width: 377px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Catalogs</td>
        <td>
           <asp:DropDownList ID="ddl_cat" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_cat_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        
    </tr>
</table>
<br />
<asp:GridView ID="gv_note" runat="server" CellPadding="2" ForeColor="Black" GridLines="None" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" Height="172px" Width="828px" OnSelectedIndexChanged="gv_note_SelectedIndexChanged" style="margin-left: 0px">
    <AlternatingRowStyle BackColor="PaleGoldenrod" />
    <FooterStyle BackColor="Tan" />
    <HeaderStyle BackColor="Tan" Font-Bold="True" />
    <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
    <SortedAscendingCellStyle BackColor="#FAFAE7" />
    <SortedAscendingHeaderStyle BackColor="#DAC09E" />
    <SortedDescendingCellStyle BackColor="#E1DB9C" />
    <SortedDescendingHeaderStyle BackColor="#C2A47B" />
</asp:GridView>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
