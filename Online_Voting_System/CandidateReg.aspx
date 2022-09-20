<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CandidateReg.aspx.cs" Inherits="Default2" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
     <tr style="width:1000px">
       <td style="width:100px; height:20px; ">
<img src="images/vote1_NEW.png" alt="vote" style="width: 288px; height: 238px;" /></td>
      
      <td>
            <table align="left" style="width: 316px" >
              <h2 align="center" style="color:Green">CANDIDATE REGISTRATION</h2><br />
              <tr>
                    <td style="text-align: right;" class="style1">
                    <asp:Label ID="Label4" runat="server" Text="Name :" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                     <asp:TextBox ID="txtName" runat="server" 
                            style="position: relative; top: 0px; left: 0px; width: 160px;"></asp:TextBox>
                        </td>
                </tr>         
                 <tr>
                    <td style="text-align: right;" class="style1">
                    <asp:Label ID="Label1" runat="server" Text="MatricNo :" Font-Bold="True"></asp:Label>
                    </td>
                    <td >
                     <asp:TextBox ID="txtmat" runat="server" style="position: relative" Width="152px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtmat"></asp:RequiredFieldValidator>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" Display="Dynamic" ControlToValidate="txtmat" ValidationExpression="(\w{1,3}\/\w{1,3}\/\w{3}\/\d{4})"  ErrorMessage="Invalid MatricNo"></asp:RegularExpressionValidator>
                        </td>
                </tr>
                
                 <tr>
                    <td style="text-align: right;" class="style1">
                    <asp:Label ID="Label5" runat="server" Text="Level :" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                    <asp:TextBox ID="txtlevel" runat="server" style="position: relative" Width="152px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td style="text-align: right;" class="style1">
                    <asp:Label ID="Label2" runat="server" Text="Department :" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="148px">
                            <asp:ListItem Selected="True">Computer Science</asp:ListItem>
                            <asp:ListItem>S.L.T.</asp:ListItem>
                            <asp:ListItem>Math&amp;Stat</asp:ListItem>
                            <asp:ListItem>Food Tech</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                
                
               
                 <tr>
                    <td style="text-align: right;" class="style1">
                    <asp:Label ID="Label6" runat="server" Text="Session :" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                    <asp:TextBox ID="txtsession" runat="server" style="position: relative" 
                            Width="152px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td style="text-align: right;" class="style1">
                    <asp:Label ID="Label3" runat="server" Text="Current Grade:" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                    <asp:TextBox ID="txtgrade" runat="server" 
                            style="position: relative" Width="152px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right;" class="style1">
                    <asp:Label ID="l3" runat="server" Text="PhoneNo :" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                    <asp:TextBox ID="txtphone" runat="server" Width="149px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right;" class="style1">
                    <asp:Label ID="l8" runat="server" Text="Email :" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                    <asp:TextBox ID="txtemail" runat="server" Width="152px"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtemail"></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" ControlToValidate="txtemail" ValidationExpression="\w+([-  +.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  ErrorMessage="Invalid EmailAddress"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right;" class="style1">
                    <asp:Label ID="Label7" runat="server" Text="Post :" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:ListBox ID="ListBox1" runat="server" Width="148px" Height="54px"></asp:ListBox><br />
                        <asp:Button ID="Button1" runat="server" Text="Check Post Available" 
                            Width="145px" onclick="Button1_Click" />
                    </td>
                </tr>
                 <tr>
                    <td style="text-align: right;" class="style1">
                    <asp:Label ID="Label8" runat="server" Text="Upload :" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                    </td><br />
                    <td><br />
                   <asp:Button ID="btnsubmit" runat="server" Text="Submit" style="position: relative" 
                            Font-Bold="True" onclick="btnsubmit_Click"/>
                        <asp:Label ID="Label9" runat="server" Text="" Visible="False"></asp:Label></td>
                </tr>
                
            </table>
            
             </td>
            </tr>
           </table>
    </asp:Content>

