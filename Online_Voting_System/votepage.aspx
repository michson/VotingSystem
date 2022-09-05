<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="votepage.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
    <asp:Label ID="lblAd" runat="server" Text="Label"></asp:Label>
    <table cellpadding="20px">
     <tr style="width:1000px">
      
<td>

<h2 align="center" style="color:Green" >WELCOME TO APPLIED SCIENCE VOTING SYSTEM 2017</h2>
            &nbsp;<h2 align="center" style="color:Green">VOTE FOR YOUR CANDIDATE</h2>
           
                 <center> 
                  <table border="1px">
                  <tr><th>Post</th><th>Department</th></tr>
                  <tr>
                  <td>President</td>
                  <td>
                      <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
                      <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
                  <td><asp:RadioButtonList ID="RadioButtonList1" runat="server">
                     <asp:ListItem>Candidate1</asp:ListItem>
                     <asp:ListItem>Candidate2</asp:ListItem>
                     </asp:RadioButtonList></td>
                     <td>   
                         <asp:Image ID="Image2" runat="server" Height="40" Width="40" /><br /><hr /><asp:Image ID="Image3" runat="server" Height="40" Width="40" /></td>
                  </tr>
                  <tr>
                  <td>P.R.O.</td>
                  <td>  <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><br />
                      <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>
                  <td><asp:RadioButtonList ID="RadioButtonList2" runat="server">
                     <asp:ListItem>Candidate1</asp:ListItem>
                     <asp:ListItem>Candidate2</asp:ListItem>
                     </asp:RadioButtonList></td>
                     <td>   
                         <asp:Image ID="Image1" runat="server" Height="40" Width="40" /><br /><hr /><asp:Image ID="Image4" runat="server" Height="40" Width="40" /></td>
                  </tr>
                  
                  
                  <tr>
                  <td>Editor In Chief</td>
                  <td>
                      <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label><br />
                      <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></td>
                  <td><asp:RadioButtonList ID="RadioButtonList3" runat="server">
                     <asp:ListItem>Candidate1</asp:ListItem>
                     <asp:ListItem>Candidate2</asp:ListItem>
                     </asp:RadioButtonList></td>
                     <td>   
                         <asp:Image ID="Image5" runat="server" Height="40" Width="40" /><br /><hr /><asp:Image ID="Image6" runat="server" Height="40" Width="40" /></td>
                  </tr>
                  <tr>
                  <td>A.G.S.</td>
                  <td>  <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label><br />
                      <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></td>
                  <td><asp:RadioButtonList ID="RadioButtonList4" runat="server">
                     <asp:ListItem>Candidate1</asp:ListItem>
                     <asp:ListItem>Candidate2</asp:ListItem>
                     </asp:RadioButtonList></td>
                     <td>   
                         <asp:Image ID="Image7" runat="server" Height="40" Width="40" /><br /><hr /><asp:Image ID="Image8" runat="server" Height="40" Width="40" /></td>
                  </tr>
                  </table>
                 
                 
                
                 
                 
                 
                 
                 
                 
               <p>
                 <asp:CheckBox ID="Chkconfirm" runat="server" Text="I am confident with my selection" />
                </p>
                <asp:Button ID="btnsubmit" runat="server" Text="Submit" style="position: relative" 
                            Font-Bold="True" onclick="btnsubmit_Click"/>
                            </center>
</td>
      </tr>
                
                
           </table>
           </center>
    </asp:Content>

