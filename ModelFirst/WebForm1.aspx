﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ModelFirst.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family:Arial">
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    
        <asp:EntityDataSource ID="EntityDataSource1" runat="server"></asp:EntityDataSource>
    </div>
        </form>
</body>
</html>
