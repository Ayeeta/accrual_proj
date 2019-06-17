<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpDetails.aspx.cs" Inherits="QuestionFour.EmpDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: left;
            width: 348px;
        }
        .auto-style3 {
            width: 392px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 37%;">
            <tr>
                <td class="auto-style1" colspan="2">Employee Details</td>
            </tr>
            <tr>
                <td class="auto-style2">Employee Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtEmpName" runat="server" Width="293px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Employee Dept.</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtEmpDep" runat="server" Width="291px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Employee Salary</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtEmpSalary" runat="server" Width="291px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
