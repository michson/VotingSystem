<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ElectionSlating.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 163px;
        }
        .style6
        {
            width: 130px;
        }
        .style7
        {
            width: 129px;
        }
        .style9
        {
            width: 100px;
        }
        .style10
        {
            width: 152px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table>

   <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Admin.aspx">Back to Menu</asp:LinkButton></td>
       <center><asp:Button ID="Button1" runat="server" Height="40px" Width="126px" Text="Slate" onclick="Button1_Click" /></center> 
     <tr style="width:1000px">
       <td class="style9">
<img src="images/vote1_NEW.png" alt="vote" style="width: 288px; height: 238px;" /></td>
      
      <td class="style7">
      <asp:Label ID="Label3" runat="server" Text="S.L.T"></asp:Label>
           <asp:ListBox ID="lstSLT" runat="server" Height="56px" Rows="3" Width="126px">
    </asp:ListBox>
    </td>
    <td class="style10">
    <asp:Label ID="Label2" runat="server" Text="STATISTICS"></asp:Label>
    <asp:ListBox ID="lstMATHS" runat="server" Height="56px" Rows="3">
    </asp:ListBox>
    </td>
    <td class="style6">
        <asp:Label ID="Label1" runat="server" Text="COM/SCI"></asp:Label>
    <asp:ListBox ID="lstcomS" runat="server" Height="56px" Width="108px">
    </asp:ListBox>
</td>
<td class="style3">
    <asp:Label ID="Label4" runat="server" Text="Food Tech"></asp:Label>
    <asp:ListBox ID="lstfoodteh" runat="server" Width="113px" Height="56px"> 
    </asp:ListBox>
            
            </td>
            </tr>
           </table>
    
</asp:Content>

