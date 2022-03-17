<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="secretAgent.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <center><h1>SECRET AGENT...</h1></center>
<div id="all">
<div id="container1">
            <br />
            <br />
            <br />
            <br />
            <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LabelID" runat="server" Text="ID"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBoxCodename" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="LabelCodename" runat="server" Text="Codename"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBoxLang1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="LabelLang1" runat="server" Text="First lang"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBoxLang2" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="LabelLang2" runat="server" Text="Second lang"></asp:Label>



            <br />
            <br />
            <asp:Button ID="ButtonCreate" runat="server" Text="Create Agent" Width="167px" OnClick="ButtonCreate_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonShow" runat="server" Text="Show Agent" Width="165px" OnClick="ButtonShow_Click" />
            <br />
            <br />
            <asp:ListBox ID="ListBoxShow" runat="server" Height="220px" Width="470px"></asp:ListBox>
            <br />

</div>
    <div id="container2">       
            <br />
            <h3>Handle Agent</h3>
            <asp:TextBox ID="TextBoxName0" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="LabelName0" runat="server" Text="Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:TextBox ID="TextBoxLang3" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="LabelLang3" runat="server" Text="First lang"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBoxLang4" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="LabelLang4" runat="server" Text="Second lang"></asp:Label>

            <br />
            <br />


            <br />
            <br />


            <br />
            <br />
            <asp:Button ID="ButtonEncrypt" runat="server" Text="Handel Agent" Width="162px" OnClick="ButtonEncrypt_Click" />
            <br />
            <br />
            <asp:ListBox ID="ListBoxEncrypt" runat="server" Height="220px" Width="470px"></asp:ListBox>
            <br />
        </div> 

    </div>
        </div>
    </form>
</body>
</html>
