<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 180px;
        }
        .style3
        {
            width: 149px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <table cellspacing="20px">
     <tr style="width:1000px">
       <td style="width:100px; height:20px; "><img src="images/vote1_NEW.png" alt="vote" style="width: 288px; height: 238px;" /></td>
      
      <td>
      
       <table align="left" style="width: 316px" >
              <h2 align="center" style="color:Green">VOTERS REGISTRATION</h2>
                <tr>
                    <td style="text-align: right;" class="style3">
                    <asp:Label ID="l1" runat="server" Text="UserName :" style="position: relative" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="style2">
                    <asp:TextBox ID="txtid" runat="server" Width="151px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right;" class="style3">
                    <asp:Label ID="l5" runat="server" Text="Password :" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="style2">
                    <asp:TextBox ID="txtpwd" runat="server"  style="position: relative" Width="152px" 
                            TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtpwd"  ErrorMessage="*"></asp:RequiredFieldValidator>
                      </td>
                </tr>
                 <tr>
                    <td style="text-align: right;" class="style3">
                    <asp:Label ID="Label4" runat="server" Text="Confirm Password" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="style2">
                    <asp:TextBox ID="txtconpwd" runat="server"  style="position: relative" Width="152px" 
                            TextMode="Password"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="password do not match." ControlToCompare="txtpwd" ControlToValidate="txtconpwd"></asp:CompareValidator>
                            
                    </td>
                </tr>
                 <tr>
                    <td style="text-align: right;" class="style3">
                    <asp:Label ID="Label1" runat="server" Text="Matric_No :" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="style2">
                     <asp:TextBox ID="txtmat" runat="server" style="position: relative" Width="152px"></asp:TextBox>
                        </td>
                </tr>
                <tr>
                    <td style="text-align: right;" class="style3">
                    <asp:Label ID="Label5" runat="server" Text="Session :" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="style2">
                    <asp:TextBox ID="txtsesion" runat="server" 
                            style="position: relative" Width="152px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td style="text-align: right;" class="style3">
                    <asp:Label ID="Label2" runat="server" Text="School :" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="style2">
                    <asp:TextBox ID="txtsch" runat="server" style="position: relative" Width="152px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td style="text-align: right;" class="style3">
                    <asp:Label ID="Label3" runat="server" Text="Department :" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="style2">
                    <asp:TextBox ID="txtdep" runat="server" 
                            style="position: relative" Width="152px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right;" class="style3">
                    <asp:Label ID="l3" runat="server" Text="Phone :" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="style2">
                    <asp:TextBox ID="txtphone" runat="server" Width="149px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right;" class="style3">
                    <asp:Label ID="l8" runat="server" Text="Email :" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="style2">
                    <asp:TextBox ID="txtemail" runat="server" Width="152px"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtemail"></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" ControlToValidate="txtemail" ValidationExpression="\w+([-  +.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  ErrorMessage="Invalid EmailAddress"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                    </td>
                    <td class="style2"><br />
                   <asp:Button ID="btnsubmit" runat="server" Text="Submit" style="position: relative" 
                            Font-Bold="True" onclick="btnsubmit_Click"/>
                    </td>
                </tr>
                
            </table>
      
      </td></tr></table>
           
    
</asp:Content>

