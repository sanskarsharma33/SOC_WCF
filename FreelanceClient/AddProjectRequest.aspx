<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProjectRequest.aspx.cs" Inherits="FreelanceClient.AddProjectRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 54px;
        }
        .auto-style2 {
            width: 231px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <table id="addRequest" class="auto-style1">
                
                <tr>  
                    <td class="auto-style2">User Id</td>  
                    <td><asp:TextBox ID="FreelancerId" runat="server" CssClass="textBox" Enabled="False"  ></asp:TextBox></td>  
                </tr> 
                <tr>
                    <td class="auto-style2">
                        Project
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Title" DataValueField="Id">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProjectRequestConnection %>" SelectCommand="SELECT [Id], [Title] FROM [Project]"></asp:SqlDataSource>
                    </td>
                </tr> 
                 <tr>  
                    <td class="auto-style2">Note</td>  
                    <td><asp:TextBox ID="Note" runat="server" CssClass="textBox" ></asp:TextBox></td>  
                </tr> 
                
                 <tr>  
                    <td class="auto-style2">Deadline</td>  
                    <td><asp:TextBox ID="Deadline" runat="server" CssClass="textBox"  ></asp:TextBox></td>  
                </tr> 
                <tr>  
                    <td class="auto-style2">Bid</td>  
                    <td><asp:TextBox ID="Bid" runat="server" CssClass="textBox" ></asp:TextBox></td>  
                </tr> 
              
                
                
 
                <tr>  
                      <td class="auto-style2">

                          <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Request" />
                          <asp:Label ID="msg" runat="server"></asp:Label>

                      </td>
                </tr>  

            </table>
            </center>    
        </div>
    </form>
</body>
</html>
