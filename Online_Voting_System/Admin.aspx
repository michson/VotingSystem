<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table cellspacing="20px">
<tr><!----- First Datarow ---->
<td>
 <div align="left">
<asp:Table ID="Table1" runat="server"> 
    <asp:TableRow>
    <asp:TableCell>
		<ul>
			<li>
				<h2>Menu</h2>
				<ul>
					<li><a href="ElectionSlating.aspx">SET POST ZONE</a></li>
					<li> <a href="ViewVoters.aspx">VIEW VOTERS</a></li>
                    <li><a href="ViewCandidate.aspx">VIEW CANDIDATE</a></li> 
                     <li><a href="EectionState.aspx">VIEW ELECTIONSTATE</a></li> 
                   <li><a href="ResultControl.aspx">PROCESS RESULT</a></li> 
					
				</ul>
			</li>
			</ul>
			
    </asp:TableCell>
    
    </asp:TableRow>
   
    </asp:Table>
    </div>
</td>
<td><!----- Second Datarow ---->
<div align="right">
    <asp:LinkButton ID="LNKLOGOUT" runat="server" onclick="LNKLOGOUT_Click">Log Out</asp:LinkButton>
    <h2 style="color:Green">Control The Election</h2><br /><br />
        
        <asp:Button ID="btnStatElec" runat="server" Text="Start Election" 
        onclick="btnStatElec_Click" />
        <asp:Button ID="btnEndElec" runat="server" Text="End Election" 
        onclick="btnEndElec_Click" /><br />
     
     </div>
</td>
</tr>

</table>      
</asp:Content>

