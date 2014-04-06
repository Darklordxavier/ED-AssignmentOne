<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="Supervisor_Screen.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        Sampe Report<br /> Location:
        <asp:Label ID="lblLocation" runat="server"></asp:Label>
        <br />
        Description:
        <asp:Label ID="lblDescription" runat="server"></asp:Label>
        <br />
        Amount:
        <asp:Label ID="lblAmount" runat="server"></asp:Label>
        <br />
        Currency:
        <asp:Label ID="lblCurrency" runat="server"></asp:Label>
        <br />
        Expenses:<br />
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem>Expense1</asp:ListItem>
        </asp:ListBox>
        <br />
        Receipts: None<br /> Submitter:
        <asp:Label ID="lblSubmitter" runat="server"></asp:Label>
    </asp:Panel>
</asp:Content>
