<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EectionState.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css">
        .style2
        {
            width: 135px;
            height: 295px;
        }
        .style3
        {
            height: 295px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellspacing="10px">
     <tr style="width:1000px" valign="top">
       <td class="style2" ><asp:LinkButton ID="LinkButton1" runat="server" 
               PostBackUrl="~/Admin.aspx">Back to Menu</asp:LinkButton></td>
       <td class="style3">
       
        <div>
    <center ><h4 style="play-during:mix">Election State</h4>
       <asp:GridView ID="GridView1" runat="server" CellPadding=6 EmptyDataText="No files found!" 
        AutoGenerateColumns="False" Font-Names="Time New Roman" AllowPaging="False" 
        Width="37%" BorderColor="#cccccc" BorderStyle="Solid" BorderWidth="1px" 
        Font-Size="20px" BackColor="#ff9e66"  style="margin-left: 0px;" AllowSorting="True">
        
        <AlternatingRowStyle BackColor="#ff9e66" Font-Size="15px" BorderColor="#cccccc" BorderStyle="Solid" BorderWidth="1px" />
        <RowStyle Height="20px" Font-Size="15px" BorderColor="#cccccc" BorderStyle="Solid" BorderWidth="1px"  />
        <Columns >
        <asp:TemplateField HeaderText="Candidate">
       <ItemTemplate>
      <img alt="photo" src='<%# Eval("Image") %>' width="50px" height="50px" />
       </ItemTemplate>
       </asp:TemplateField>
       <asp:BoundField HeaderText="Name" DataField="Name" />
     <asp:BoundField HeaderText="Post" DataField="Post" />
      
       <asp:BoundField HeaderText="VoteNo" DataField="VoteNo" />
       <asp:BoundField HeaderText="Result" DataField="Result" />
       
        </Columns >
        </asp:GridView>
        </center>
         </div>
       </td>
      </tr>
          </table>
</asp:Content>

