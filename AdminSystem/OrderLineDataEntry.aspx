<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLineDataEntry.aspx.cs" Inherits="OrderLineDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            this is order entry page</div>
        <p>
        <asp:Label ID="lblOrderLineID" runat="server" Text="OrderLine ID" width="105px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderLineID" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind2" runat="server" OnClick="btnFind2_Click" Text="Find" />
        <br />
        <asp:Label ID="lblProductID" runat="server" Text="Product ID" width="105px"></asp:Label>
&nbsp;<asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblProductDetails" runat="server" Text="Product Details" width="105px"></asp:Label>
&nbsp;<asp:TextBox ID="txtProductDetails" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblProductQuantity" runat="server" Text="Product Quantity" width="105px"></asp:Label>
&nbsp;<asp:TextBox ID="txtProductQuantity" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:CheckBox ID="chkShippingStatus" runat="server" Text="Shipping Status" />
        </p>
        <p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
