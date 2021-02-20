<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FreelanceClient.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <header><center><h1>LOGIN</h1></center></header>
    <form id="form1" runat="server">
        <div>
            <center>
  <table class="auto-style1"> 
          
    <tr>  
    <td>  
    <asp:Label ID="Label2" runat="server" Text="User Name"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="username" runat="server" required="true" ></asp:TextBox></td>  
    </tr>  
    
    
    <tr>  
    <td>  
    <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label></td>  
    <td>  
    <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox></td>  
    </tr>  
    <tr>  
    <td>  
    </td>  
    <td>  
    <br />  
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" CssClass="btn btn-primary" Text="Login" />
        <br />
        
    </td>  
    </tr>  
    </table>  
    <asp:Label ID="msg" runat="server"></asp:Label>  
    </center>
                </div>  
    </form>
</body>
</html>
