<%@ Page Language="VB" MasterPageFile="~/RTOMASTER.master" AutoEventWireup="false" CodeFile="TEST.aspx.vb" Inherits="TEST" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" 
            Width="1024px">
            <ItemTemplate>
                &nbsp;<asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' 
                    Visible="False" />
                <br />
                question:
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("question", "{0}") %>'></asp:Label>
                <br />
                option1:
                <asp:RadioButton ID="RadioButton1" runat="server" 
                    Text='<%# Eval("option1", "{0}") %>' />
                <br />
                option2:
                <asp:RadioButton ID="RadioButton2" runat="server" 
                    Text='<%# Eval("option2", "{0}") %>' />
                <br />
                option3:
                <asp:RadioButton ID="RadioButton3" runat="server" 
                    Text='<%# Eval("option3", "{0}") %>' />
                <br />
                &nbsp;<asp:Label ID="answerLabel" runat="server" Text='<%# Eval("answer") %>' 
                    Visible="False" />
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT * FROM [question]"></asp:SqlDataSource>
    </p>
</asp:Content>

