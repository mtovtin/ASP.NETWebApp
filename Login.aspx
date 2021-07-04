<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ResidentsApplication.Login" %>

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
			width: 207px;
		}
	    .auto-style4 {
            width: 299px;
        }
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<table class="auto-style1">
				<tr>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style3">User</td>
					<td>
						<asp:TextBox ID="UserTextBox" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td class="auto-style4"></td>
					<td class="auto-style3"></td>
					<td></td>
				</tr>
				<tr>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style3">Password</td>
					<td>
						<asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style3">&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style3">&nbsp;</td>
					<td>
						<asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="OK" Width="104px" />
					</td>
				</tr>
			</table>
        </div>
    </form>
</body>
</html>
