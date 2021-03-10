<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    &nbsp;<form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderID" runat="server" Text="Order ID" width="96px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="FIND" />
        <br />
        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" width="96px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblOrderDetails" runat="server" Text="Order Details" width="96px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtOrderDetails" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateOrdered" runat="server" Text="Date Ordered" width="96px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDateOrdered" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="96px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblOrderLineID" runat="server" Text="OrderLine ID" width="105px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderLineID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblProductID" runat="server" Text="Product ID" width="105px"></asp:Label>
&nbsp;<asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblProductDetails" runat="server" Text="Product Details" width="105px"></asp:Label>
&nbsp;<asp:TextBox ID="txtProductDetails" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblProductQuantity" runat="server" Text="Product Quantity" width="105px"></asp:Label>
&nbsp;<asp:TextBox ID="txtProductQuantity" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkShippingStatus" runat="server" Text="Shipping Status" />
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
