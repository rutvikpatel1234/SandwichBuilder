<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sandwich_backend.aspx.cs" Inherits="CIS3342.sandwich_backend" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
       
        body {
        background-color:yellowgreen;
        }
      
    </style>
</head>
<body>
   <form id="form1" runat="server">
        <div style="text-align:center; font-display:block; font-size:x-large;">
            <asp:Label ID="lblreceipt" runat="server" Text="Receipt"></asp:Label>
        </div>
    </form>

    
    
        
            <asp:Label ID="lblname" runat="server" Text="name"></asp:Label>
            <br />
            <asp:Label ID="lblphone" runat="server" Text="Phone"></asp:Label>
            &nbsp;
        
        <br />
        
            <asp:Label ID="lblsize" runat="server" Text="Sandwich Size"></asp:Label>
            &nbsp;
            &nbsp;
       
        <br />
        
            <asp:Label ID="lblpreference" runat="server" Text="Preference"></asp:Label>
        
        <br />
        
            <asp:Label ID="lblsauces" runat="server" Text="sauces"></asp:Label>
        
        <br />
        
            <asp:Label ID="lblVeggies" runat="server" Text="Veggies"></asp:Label>
        
        <br />
        
            <asp:Label ID="lblmeat" runat="server" Text="Meat"></asp:Label>
        
        <br />
        
            <asp:Label ID="lblextra" runat="server" Text="Extra"></asp:Label>
        
        <br />
        
            <asp:Label ID="lblsides" runat="server" Text="Slides"></asp:Label>
        
        <br />

        &nbsp;
        
            <asp:Label ID="lblsubtotal" runat="server" Text="Subtotal"></asp:Label>
        
        <br />
        &nbsp;
        
            <asp:Label ID="lbltip" runat="server" Text="Tip"></asp:Label>
        
        <br />
        &nbsp;
        
            <asp:Label ID="lbltax" runat="server" Text="Tax"></asp:Label>
        
        <br />
        &nbsp;
      
            <asp:Label ID="lbltotal" runat="server" Text="Total"></asp:Label>
        
    
   

    </body>
</html>
