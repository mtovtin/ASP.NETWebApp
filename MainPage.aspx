<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="ResidentsApplication.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 388px;
        }
        .auto-style5 {
            width: 228px;
        }
        .auto-style6 {
            width: 293px;
        }
        .auto-style7 {
            margin-top: 33px;
        }
        .auto-style8 {
            height: 45px;
            width: 84px;
        }
        .auto-style9 {
            height: 117px;
            width: 84px;
        }
        .auto-style11 {
            width: 84px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <div style="text-align: center;">
            <div style="margin:0 auto; text-align:left;">
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6" style="vertical-align: top">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5" rowspan="3" style="vertical-align: top">
                    <asp:GridView ID="GridViewResidents" runat="server" Caption="Residents" Height="169px" Width="307px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" HorizontalAlign="Center">
                        <FooterStyle BackColor="#CCCCCC" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                </td>
                <td class="auto-style6" rowspan="3" style="vertical-align: top">
                    <asp:GridView ID="GridViewPayments" runat="server" Caption="Payments" Height="169px" Width="273px" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" CellSpacing="2" GridLines="Horizontal" HorizontalAlign="Center">
                        <FooterStyle BackColor="White" ForeColor="#333333" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#487575" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#275353" />
                    </asp:GridView>
                </td>
                <td class="auto-style9" style="vertical-align: top">
                    <asp:DropDownList ID="DropDownListYear" runat="server" CssClass="auto-style7" Height="50px">
                    </asp:DropDownList>
                    <asp:DropDownList ID="DropDownListAddress" runat="server" CssClass="auto-style7" Height="50px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style8" style="vertical-align: top">
                    <asp:Button ID="ButtonTask1" runat="server" Font-Size="Large" Height="43px" OnClick="ButtonTask1_Click" Text="Task 1" Width="208px" />
                </td>
            </tr>
            <tr>
                <td style="vertical-align: top" class="auto-style11">
                    <asp:Button ID="ButtonTask2" runat="server" Font-Size="Large" Height="43px" OnClick="ButtonTask2_Click1" Text="Task 2" Width="208px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6" style="vertical-align: top">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
        </table>
                </div>
            </div>
    </form>
</body>
</html>
