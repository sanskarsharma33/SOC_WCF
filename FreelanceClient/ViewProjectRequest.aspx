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
                <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
                <table class="auto-style1"> 
      <tr>  
    <td>  
    <asp:Label ID="fi" runat="server" Text="Freelancer Id"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="freelancer" runat="server"  ></asp:TextBox></td>  
    </tr>  
    
    <tr>  
    <td>  
    <asp:Label ID="pi" runat="server" Text="Project Id"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="project" runat="server"  ></asp:TextBox></td>  
    </tr>  
    <tr>  
    <td>  
    <asp:Label ID="nt" runat="server" Text="Note"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="note" runat="server" ></asp:TextBox></td>  
    </tr>    
                    <tr>  
    <td>  
    <asp:Label ID="bd" runat="server" Text="Bid"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="bid" runat="server" ></asp:TextBox></td>  
    </tr>    
     <tr>

         <td>
             <br />
&nbsp;</td>

     </tr>
    </table> 
            </center>
        </div>
    </form>
</body>
</html>
