<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowProjectRequest.aspx.cs" Inherits="FreelanceClient.ShowProjectRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <center>
        <h1>Show Project Request</h1>
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server">
                  </asp:GridView>
        <br />
        <br />
        <br />
        <br />
           <asp:Label ID="ProjectId" runat="server" Text="Project Id"></asp:Label>   
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="pId" runat="server"  ></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button2_Click" Text="Show" />
        <br />
        <br />
        <br />
        <br />
                  <asp:GridView ID="GridView1" runat="server">
                  </asp:GridView>
    </center>
</body>
</html>
