﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CS.aspx.cs" Inherits="CS" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
        table
        {
            border: 1px solid #ccc;
            border-collapse: collapse;
            background-color: #fff;
        }
        table th
        {
            background-color: #ff7f00;
            color: #fff;
            font-weight: bold;
        }
        table th, table td
        {
            padding: 5px;
            border: 1px solid #ccc;
        }
        table, table table td
        {
            border: 0px solid #ccc;
        }
        .button {
    background-color: #0094ff; /* Blue */
    border: none;
    color: white;
    padding: 15px 32px;
    text-align: center;
    text-decoration: none;
    display: inline-block;
    font-size: 16px;
        }


    .d1{
        padding-top:50px;   



    }
    </style>
</head>
<body>
    <form id="form1" runat="server">

           <h1> Users Report</h1>
    <div>
 
    <asp:FileUpload ID="FileUpload1"  CssClass="button"  runat="server" />
    <asp:Button ID="btnImport" CssClass="button" runat="server" Text="Import" OnClick="UsersReport" />

   </div>

    <div class="d1">

        
    <h1> Entity Summary </h1>
    <asp:FileUpload ID="FileUpload2"  CssClass="button"  runat="server" />
    <asp:Button ID="Button1" CssClass="button" runat="server" Text="Import" OnClick="EntitySummary" />

    </div>


    
    <div class="d1">

        
    <h1> Assessment Summary </h1>
    <asp:FileUpload ID="FileUpload3"  CssClass="button"  runat="server" />
    <asp:Button ID="Button2" CssClass="button" runat="server" Text="Import" OnClick="AssessmentSummary" />

    </div>



    <hr/>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>



    </form>



    <div>

    </div>



    </asp:Chart>


</body>
</html>
