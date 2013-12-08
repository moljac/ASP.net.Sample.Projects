<%@ Control Language="C#" CodeBehind="ForeignKey.ascx.cs" Inherits="WebApplicationDynamicDataEntities.netfx35.ForeignKeyField" %>

<asp:HyperLink ID="HyperLink1" runat="server"
    Text="<%# GetDisplayString() %>"
    NavigateUrl="<%# GetNavigateUrl() %>"  />