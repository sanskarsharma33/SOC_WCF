<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="FreelanceClient.UpdateProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
  <table class="auto-style1"> 
      <tr>  
    <td>  
    <asp:Label ID="nm" runat="server" Text="Name"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="name" runat="server" required="True" ></asp:TextBox></td>  
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
        <asp:Calendar ID="dob" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
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
    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Male"  />  
    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Female"  /></td>  
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
    </center>
                </div> 
    </form>
</body>
</html>
