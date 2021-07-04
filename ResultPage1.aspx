<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResultPage1.aspx.cs" Inherits="ResidentsApplication.ResultPage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 841px;
        }
        .auto-style4 {
            width: 841px;
            height: 156px;
        }
        .auto-style5 {
            margin-left: 568px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:GridView ID="GridViewRes1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" Caption="Task 1" CellPadding="4" HorizontalAlign="Center">
                            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" ForeColor="#003399" />
                            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <SortedAscendingCellStyle BackColor="#EDF6F6" />
                            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                            <SortedDescendingCellStyle BackColor="#D6DFDF" />
                            <SortedDescendingHeaderStyle BackColor="#002876" />
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="Button1" runat="server" Font-Size="Large" Height="48px" OnClick="Button1_Click" Text="Return to the main page" Width="204px" CssClass="auto-style5" />
                    </td>
                </tr>
            </table>
            
    </form>
    
</body>
</html>
