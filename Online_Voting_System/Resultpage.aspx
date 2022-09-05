<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Resultpage.aspx.cs" Inherits="Resultpage" Title="Untitled Page" %>

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
    
    <table cellspacing="10px">
     <tr style="width:1000px" valign="top">
       <td style="width:100px; height:20px; ">
<img src="images/vote1_NEW.png" alt="vote" style="width: 288px; height: 238px;" /></td>
      
      <td>
            <table align="left" style="width: 316px; height: 205px;" >
            <tr valign="top"><td>
                <marquee behavior="scroll" scrolldelay="20"><asp:Label ID="Label1" runat="server" Text="Result Pending"></asp:Label></marquee></td>
            <td>
            
            <asp:GridView ID="GridView1" runat="server" CellPadding=6 EmptyDataText="No files found!" 
        AutoGenerateColumns="False" Font-Names="Time New Roman" 
        Width="37%" BorderColor="#cccccc" BorderStyle="Solid" BorderWidth="1px" 
        Font-Size="20px" BackColor="#ff9e66"  style="margin-left: 0px;">
        
        <AlternatingRowStyle BackColor="#ff9e66" Font-Size="15px" BorderColor="#cccccc" BorderStyle="Solid" BorderWidth="1px" />
        <RowStyle Height="20px" Font-Size="15px" BorderColor="#cccccc" BorderStyle="Solid" BorderWidth="1px"  />
        <Columns >
        <asp:TemplateField HeaderText="Candidate">
       <ItemTemplate>
      <img alt="photo" src='<%# Eval("Image") %>' width="100px" height="100px" />
       </ItemTemplate>
       </asp:TemplateField>
        <asp:BoundField HeaderText= "Name" DataField="Name"/>
     <asp:BoundField HeaderText="Post" DataField="Post" />
     <asp:BoundField HeaderText="VoteNo" DataField="VoteNo" />
      <asp:BoundField HeaderText="Result" DataField="Result" />  
        </Columns>
        </asp:GridView>
            
            
            </td>
            </tr>
            </table>
            </td>
            </tr>
            </table>
</asp:Content>

