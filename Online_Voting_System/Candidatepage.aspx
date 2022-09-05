<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Candidatepage.aspx.cs" Inherits="Defau" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table>
<tr valign="top">
<td><!-----First td ---->
<asp:Table ID="Table1" runat="server">
    
    <asp:TableRow  style="width:1000px">
    <asp:TableCell>
    <div align="left" id="sidebar">
		<ul>
			<li>
				<h2>Menu</h2>
				<ul>
					<li><a href="CandidateLoging.aspx">VOTE</a></li>
					
				</ul>
			</li>
			</ul>
			</div>
	<!-- end sidebar -->
    </asp:TableCell>
    </asp:TableRow>
   
    </asp:Table>
</td>
<td><!----Second td ---->

<asp:Table ID="Table2" runat="server" >
    <asp:TableRow  style="width:1000px">
    <asp:TableCell>
   <div align="right">
    <center ><h4 style="play-during:mix">List Of All Candidate</h4>
       <asp:GridView ID="GridView1" runat="server" CellPadding=6 EmptyDataText="No files found!" 
        AutoGenerateColumns="False" Font-Names="Time New Roman" AllowPaging="true" 
        Width="37%" BorderColor="#cccccc" BorderStyle="Solid" BorderWidth="1px" 
        Font-Size="20px" BackColor="#ff9e66"  style="margin-left: 0px;">
        
        <AlternatingRowStyle BackColor="#ff9e66" Font-Size="15px" BorderColor="#cccccc" BorderStyle="Solid" BorderWidth="1px" />
        <RowStyle Height="20px" Font-Size="15px" BorderColor="#cccccc" BorderStyle="Solid" BorderWidth="1px"  />
        <Columns >
        <asp:BoundField HeaderText= "Name" DataField="Name"/>
     <asp:BoundField HeaderText="Department" DataField="Department" />
     <asp:BoundField HeaderText="Post" DataField="Post" />
      <asp:BoundField HeaderText="Level" DataField="Level" />
       <asp:BoundField HeaderText="Session" DataField="Session" />
       <asp:TemplateField HeaderText="Candidate">
       <ItemTemplate>
      <img alt="photo" src='<%# Eval("Image") %>' width="100px" height="100px" />
       </ItemTemplate>
       </asp:TemplateField>
        </Columns>
        </asp:GridView>
        </center>
         </div>
    </asp:TableCell>
    
    </asp:TableRow>
   
    </asp:Table>
</td>

</tr>


</table>


    
    
    
</asp:Content>

