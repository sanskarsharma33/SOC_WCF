<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProject.aspx.cs" Inherits="FreelanceClient.UpdateProject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
            <table id="panSearch" class="auto-style1">
                <tr>  
                    <td>Enter Project ID</td>  
                    <td><asp:TextBox ID="txtSearch" runat="server" CssClass="textBox"  ></asp:TextBox></td>  
                    <td>
                        <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="button" OnClick="btnSearch_Click"></asp:Button>

                    </td>  
                 </tr> 

                <tr>
                    <td colspan="3" ><asp:Label ID="lblSearchResult" runat="server" Font-Size="Medium" ></asp:Label>

                    </td>

                </tr>  
             </table>  
  
            <table id="panUpdate" runat="server"   >  
                <tr>  
                    <td colspan="2"><asp:Label ID="lblMsg" runat="server" Font-Size="Medium" ></asp:Label></td>  
                </tr>  
                <tr>  
                    <td>Project ID</td>  
                    <td><asp:Label ID="lblProjectID" runat="server" ></asp:Label></td>  
                </tr>  
                <tr>  
                    <td>OwnerId</td>  
                    <td><asp:TextBox ID="OwnerId" runat="server" CssClass="textBox" ></asp:TextBox></td>  
                </tr> 
                 <tr>  
                    <td>Type</td>  
                    <td><asp:TextBox ID="Type" runat="server" CssClass="textBox" ></asp:TextBox></td>  
                </tr> 
                 <tr>  
                    <td>Details</td>  
                    <td><asp:TextBox ID="Details" runat="server" CssClass="textBox" ></asp:TextBox></td>  
                </tr> 
                 <tr>  
                    <td>Title</td>  
                    <td><asp:TextBox ID="Title" runat="server" CssClass="textBox" ></asp:TextBox></td>  
                </tr> 
                 <tr>  
                    <td>Deadline</td>  
                    <td><asp:TextBox ID="Deadline" runat="server" CssClass="textBox"  ></asp:TextBox></td>  
                </tr> 
                <tr>  
                    <td>Budget</td>  
                    <td><asp:TextBox ID="Budget" runat="server" CssClass="textBox" ></asp:TextBox></td>  
                </tr> 
              
                <tr> 
                    <td>IsOpen</td> 
                     <td>
                            <asp:RadioButton ID="RadioButton1" runat="server" Text="True" GroupName="IsOpen" />  
                            <asp:RadioButton ID="RadioButton2" runat="server" Text="False" GroupName="IsOpen" />
                     </td>
                </tr>
 
                <tr>  
                    <td colspan="2">  
                    <asp:Button ID="bntUpdated" runat="server" Text="Update" CssClass="button" OnClick="bntUpdated_Click"    
                             />  
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="button" OnClick="btnCancel_Click"    
                            />  
                    </td>  
                </tr>  

            </table>
        </center>
        </div>
    </form>
</body>
</html>
