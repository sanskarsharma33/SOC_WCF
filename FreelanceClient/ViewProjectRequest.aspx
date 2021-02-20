<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProjectRequest.aspx.cs" Inherits="FreelanceClient.ViewProjectRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <asp:Label ID="pId" runat="server" Text="Project Request Id"></asp:Label>   
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="prId" runat="server"  ></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button2_Click" Text="Show" />
        <br />
                <br />
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
        <br />
                <table class="auto-style1"> 
      </table> 
            </center>
        </div>
    </form>
</body>
</html>
