<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    SANUSI NETTEMPLATE
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="grid-form1">
        <h2>SANUSI NETTEMPLATE</h2>
        <h4>Choose Template Menu</h4>
        <ol>
            <li><a href="<%= Page.ResolveUrl("~/Barang/Show") %>">LINQ CRUD with Razor view engine</a></li>
            <li><a href="<%= Page.ResolveUrl("~/Barang/IndexInAspx") %>">Form Validation using Jquery (TODO)</a></li>
        </ol>
    </div>
    

    

</asp:Content>
