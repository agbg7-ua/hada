<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SobreNosotros.aspx.cs" Inherits="tiendaWeb.SobreNosotros" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
    .center{
        margin: auto;
        width: 35%;
        padding: 10px;
    }
    </style>
    <div class="center">
        <asp:Chart ID="Chart1" runat="server" Palette="Berry" Width="542px">
            <Titles>
                <asp:Title Name="Title" Text="Productos más vendidos"></asp:Title>
            </Titles>
        <Series>
            <asp:Series Name="Series1"></asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1">
                
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    </div>
</asp:Content>
