<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <div class="site_ekle_sol" > Site Kategorisi :</div>
            <div class="uyeol_orta" style=" margin-left:13px; text-align:left;"> 
               <asp:DropDownList ID="ddlCategory" Width="160" DataValueField="ID" DataTextField="CategoryName" 
                   OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged"
                    runat="server" AutoPostBack="True"></asp:DropDownList>
            </div>
        <asp:TextBox runat="server" ID="txt"></asp:TextBox>

    </div>
    </form>
</body>
</html>
