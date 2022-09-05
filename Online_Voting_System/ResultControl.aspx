<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ResultControl.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table>
     <tr >
       <td style="width:100px; height:20px; ">
<img src="images/vote1_NEW.png" alt="vote" style="width: 288px; height: 238px;" /></td>
      
      <td>
            <table  >
              <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Admin.aspx">Back to Menu</asp:LinkButton></td>
    
              <h2 align="center" style="color:Green">&nbsp;&nbsp;Declare The Winner and Show Result</h2>
                <p align="center" style="color:Green">&nbsp;</p>
              
                <tr>
                    <td  align="center">
                        <asp:Button ID="btnDeclarewin" runat="server" Text="Declare Winner" 
                            Width="131px" onclick="btnDeclarewin_Click" Height="35px" /><br />
                        <asp:Button ID="Button13" runat="server" Text="Show Result" Width="131px" 
                            Height="35px" onclick="Button13_Click" />
                    <asp:Button ID="Button1" runat="server" Text="Hide Result" Width="131px" 
                            Height="35px" onclick="Button1_Click" />
                        
                    
                    </td> 
                </tr>
                
            </table>
            
            &nbsp;</td>
             <td style="width:100px; height:20px; ">
                    
                   <img src="images/vote1_NEW.png" alt="vote" style="width: 288px; height: 238px;" /> 
                    </td>
            </tr>
           </table>
</asp:Content>

