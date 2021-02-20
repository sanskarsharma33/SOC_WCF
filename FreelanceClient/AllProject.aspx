<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllProject.aspx.cs" Inherits="FreelanceClient.AllProject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                 <!--<tr>  
                           <td><asp:Label ID="Label8" runat="server" Text="Project Id"></asp:Label></td>   
                           <td><asp:TextBox ID="ID" runat="server"  ></asp:TextBox></td>  
                      </tr> -->
                  <table class="auto-style1"> 
                      <tr>  
                           <td><asp:Label ID="ProjectId" runat="server" Text="Project Id"></asp:Label></td>   
                           <td><asp:TextBox ID="pId" runat="server"  ></asp:TextBox></td>  
                      </tr> 
                      <tr>  
                           <td><asp:Label ID="Label1" runat="server" Text="OwnerId"></asp:Label></td>   
                           <td><asp:TextBox ID="ownerId" runat="server"  ></asp:TextBox></td>  
                      </tr>  
                       <tr>  
                           <td><asp:Label ID="Label2" runat="server" Text="Type"></asp:Label></td>   
                           <td><asp:TextBox ID="type" runat="server"></asp:TextBox></td>  
                      </tr>  
                       <tr>  
                           <td><asp:Label ID="Label3" runat="server" Text="Details"></asp:Label></td>   
                           <td><asp:TextBox ID="details" runat="server" ></asp:TextBox></td>  
                      </tr>  
                       <tr>  
                           <td><asp:Label ID="Label4" runat="server" Text="Title"></asp:Label></td>   
                           <td><asp:TextBox ID="title" runat="server"></asp:TextBox></td>  
                      </tr>  
                       <tr>  
                           <td><asp:Label ID="Label5" runat="server" Text="Deadline"></asp:Label></td>   
                           <td><asp:TextBox ID="deadline" runat="server" TextMode="Date"></asp:TextBox></td>  
                      </tr>  
                        <tr>  
                           <td><asp:Label ID="Label6" runat="server" Text="Budget"></asp:Label></td>   
                           <td><asp:TextBox ID="budget" runat="server"></asp:TextBox></td>  
                      </tr>  
                       <tr>  
                           <td><asp:Label ID="Label7" runat="server" Text="IsOpen"></asp:Label></td> 
                           <td>
                               <asp:RadioButton ID="RadioButton1" runat="server" Text="True" GroupName="IsOpen" />  
                                <asp:RadioButton ID="RadioButton2" runat="server" Text="False" GroupName="IsOpen" />
                           </td>
                       </tr>
                    
                    <tr>  
                             
                        <td colspan="2">  
                            <br />  
                            <asp:Button ID="Button1" runat="server"  CssClass="btn btn-primary" Text="Add" OnClick="Button1_Click" />
                            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Search" />
                            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Update" />
                            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Delete" />
                            <br />
        
                         </td>  
                    </tr>  
                 </table>  
            <asp:Label ID="msg" runat="server"></asp:Label>  
                  <br />
                  <asp:GridView ID="GridView1" runat="server">
                  </asp:GridView>
        </center>
        </div>
    </form>
</body>
</html>
