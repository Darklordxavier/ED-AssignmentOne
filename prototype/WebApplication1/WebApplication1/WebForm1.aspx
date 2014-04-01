<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title> CheckBoxList TextAlign Example </title>
<script runat="server">

      void Check_Clicked(Object sender, EventArgs e) 
      {

         Message.Text = "Selected Item(s):<br /><br />";

         // Iterate through the Items collection of the CheckBoxList 
         // control and display the selected items.
         for (int i=0; i<checkboxlist1.Items.Count; i++)
         {

            if (checkboxlist1.Items[i].Selected)
            {

               Message.Text += checkboxlist1.Items[i].Text + "<br />";

            }

         }

      }

      void Index_Change(Object sender, EventArgs e) 
      {

         // Set the alignment of the caption (right or left) in relation
         // to the check boxes.
         // Note that the TextAlign enumeration starts at 1 instead of 0, 
         // so the value of the SelectedIndex property cannot be used
         // directly for casting into a TextAlign enumeration.

         // In this example, the values of the TextAlign enumeration are 
         // stored in the Value property of each ListItem in the 
         // DropDownList control named List. To determine the enumeration  
         // value, retrieve the value of the Value property, convert it to
         // an Int32, and then cast it to a TextAlign enumeration.
         int EnumValue = Convert.ToInt32(List.SelectedItem.Value);

         checkboxlist1.TextAlign = (TextAlign)EnumValue;

      }

   </script>

</head>

<body>

   <form id="form1" runat="server">

      <h3> Accountant</h3>

      <br />

               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sorted by

               <asp:DropDownList id="List"
                    AutoPostBack="True"
                    OnSelectedIndexChanged="Index_Change"
                    runat="server">
                   <asp:ListItem Value="0">Time</asp:ListItem>
                   <asp:ListItem Value="1">Amount</asp:ListItem>

               </asp:DropDownList>

            <br />

      <asp:CheckBoxList id="checkboxlist1" 
           AutoPostBack="True"
           CellPadding="5"
           CellSpacing="5"
           RepeatColumns="2"
           RepeatDirection="Vertical"
           RepeatLayout="Table"
           TextAlign="Right"
           OnSelectedIndexChanged="Check_Clicked"
           runat="server" BorderColor="Black" BorderWidth="2px" Width="577px">

         <asp:ListItem>Item 1</asp:ListItem>
         <asp:ListItem>Item 2</asp:ListItem>
         <asp:ListItem>Item 3</asp:ListItem>
         <asp:ListItem>Item 4</asp:ListItem>
         <asp:ListItem>Item 5</asp:ListItem>
         <asp:ListItem>Item 6</asp:ListItem>

      </asp:CheckBoxList>

      <br /><br />

      <asp:label id="Message" runat="server"/>

      <hr />

       <table cellpadding="5">

         <tr>

            <td>

                <asp:Button ID="Button1" runat="server" Text="Accept" />
                <asp:Button ID="Button2" runat="server" Text="Reject" />
             </td>

         </tr>

      </table>

   </form>

</body>

</html>
