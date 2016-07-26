<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="PDFediter_BS.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        *{
            margin: 0;
            padding: 0;
            background-color: #EAEAEA;
        }
        div{
            width: 400px;
            height: 400px;
            background-color: #1E90FF;
        }
        .center-in-center{
            position: absolute;
            top: 50%;
            left: 50%;
            -webkit-transform: translate(-50%, -50%);
            -moz-transform: translate(-50%, -50%);
            -ms-transform: translate(-50%, -50%);
            -o-transform: translate(-50%, -50%);
            transform: translate(-50%, -50%);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="center-in-center">
        <input type="file" id="FileInput" name="FileInput" runat="server" />
        <asp:Button ID="btnFileInput" Text="Input" runat="server" OnClick="btnFileInput_Click" />
        <asp:Button ID="btnFileDownload" Text="Download" runat="server" Enabled="false" OnClick="btnFileDownload_Click" />
    </div>
    </form>
</body>
</html>
