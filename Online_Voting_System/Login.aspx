<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" Title="Untitled Page" %>

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
    <table>
     <tr >
       <td style="width:100px; height:20px; ">
<img src="images/vote1_NEW.png" alt="vote" style="width: 288px; height: 238px;" /></td>
      <td>
            <table  >
              <h2 align="center" style="color:Green">&nbsp;&nbsp;LOG IN</h2>
                <p align="center" style="color:Green">&nbsp;</p>
                <tr>
                    <td style="text-align: right;" class="style3">
                    <asp:Label ID="l1" runat="server" Text="UserName :" style="position: relative" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="style2">
                    <asp:TextBox ID="txtUserName" runat="server" Width="151px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right;" class="style3">
                    <asp:Label ID="l5" runat="server" Text="Password :" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="style2">
                    <asp:TextBox ID="txtpassword" runat="server"  style="position: relative" Width="152px" 
                            TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtpassword"  ErrorMessage="*"></asp:RequiredFieldValidator>
                      </td>
                </tr>
                <tr>
                    <td >
                    </td>
                    <td class="style2">
                   <asp:Button ID="btnsubmit" runat="server" Text="Submit" style="position: relative" 
                            Font-Bold="True" onclick="btnsubmit_Click"/><br /><asp:Label ID="lblmsg" runat="server"
                                Text="" ForeColor="#99FF66"></asp:Label>
                     
                    </td>
                    
                </tr>
                
            </table>
            
            </td>
             <td style="width:100px; height:20px; ">
                    
                   <img src="images/vote1_NEW.png" alt="vote" style="width: 288px; height: 238px;" /> 
                    </td>
            </tr>
           </table>
</asp:Content>

