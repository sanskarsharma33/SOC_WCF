<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRegister.aspx.cs" Inherits="FreelanceClient.UserRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 306px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>           
  <table class="auto-style1"> 
      <tr>  
    <td>  
    <asp:Label ID="nm" runat="server" Text="Name"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="name" runat="server" required="true"></asp:TextBox></td>  
    </tr>  
    
    <tr>  
    <td>  
    <asp:Label ID="Label2" runat="server" Text="User Name"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="username" runat="server" required="true" ></asp:TextBox></td>  
    </tr>  
    <tr>  
    <td>  
    <asp:Label ID="Label6" runat="server" Text="Email ID"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="EmailID" runat="server" TextMode="Email"></asp:TextBox></td>  
    </tr>  
      <tr>  
    <td>  
    <asp:Label ID="ph" runat="server" Text="Phone No."></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="phone" runat="server" required="true"></asp:TextBox></td>  
    </tr>  
      <tr>  
    <td>  
    <asp:Label ID="doblbl" runat="server" Text="DOB"></asp:Label>  
    </td>  
    <td>  
        <asp:Calendar ID="dob" runat="server"></asp:Calendar>
    </tr>  
    
    
    <tr>  
    <td>  
    <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label></td>  
    <td>  
    <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox></td>  
    </tr>  
    <tr>  
    <td>  
    <asp:Label ID="Label4" runat="server" Text="Confirm Password"></asp:Label></td>  
    <td>  
    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox></td>  
    </tr>  
    <tr>  
    <td>  
    <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label></td>  
    <td>  
    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Male" OnCheckedChanged="RadioButton1_CheckedChanged" />  
    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Female" OnCheckedChanged="RadioButton2_CheckedChanged" /></td>  
    </tr>  
      <tr>  
    <td>  
    <asp:Label ID="ds" runat="server" Text="User description"></asp:Label></td>  
    <td>  
        <asp:TextBox ID="usrDescription" runat="server" Height="101px" Width="326px"></asp:TextBox>
    </tr>
    <tr>  
    <td>  
    </td>  
    <td>  
    <br />  
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" CssClass="btn btn-primary" Text="Register" />
        <br />
        
    </td>  
    </tr>  
    </table>  
    <asp:Label ID="msg" runat="server"></asp:Label>  
    </div>  

    </form>
</body>
</html>
