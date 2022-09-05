<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewVoters.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

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
    <center ><h4 style="play-during:mix">List Of All Voters</h4>
       <asp:GridView ID="GridView1" runat="server" CellPadding=6 EmptyDataText="No files found!" 
        AutoGenerateColumns="False" Font-Names="Time New Roman" AllowPaging="true" 
        Width="37%" BorderColor="#cccccc" BorderStyle="Solid" BorderWidth="1px" 
        Font-Size="20px" BackColor="#ff9e66"  style="margin-left: 0px;">
        
        <AlternatingRowStyle BackColor="#ff9e66" Font-Size="15px" BorderColor="#cccccc" BorderStyle="Solid" BorderWidth="1px" />
        <RowStyle Height="20px" Font-Size="15px" BorderColor="#cccccc" BorderStyle="Solid" BorderWidth="1px"  />
        <Columns >
        <asp:BoundField HeaderText= "UserName" DataField="UserName"/>
     <asp:BoundField HeaderText="Password" DataField="Password" />
     <asp:BoundField HeaderText="Phone" DataField="Phone" />
      <asp:BoundField HeaderText="Email" DataField="Email" />
       <asp:BoundField HeaderText="Matric_no" DataField="Matric_no" />
       <asp:BoundField HeaderText="Role" DataField="Role" />
        <asp:BoundField HeaderText="Session" DataField="Session" />
        </Columns>
        </asp:GridView>
        </center>
         </div>
       </td>
      </tr>
          </table>
    
</asp:Content>

