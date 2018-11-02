<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feed.aspx.cs" Inherits="deve_web.Views.Feed" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
	<link rel="stylesheet" type="text/css" href="feed.css" media="all"> 
    <title></title>
</head>
<body> 

    <form id="form1" runat="server" >
        <div> 
            <img src="img.png"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton style="vertical-align:middle"  ID="LinkButton4" runat="server" OnClick="LinkButton2_Click">Buscar</asp:LinkButton> 
            <asp:TextBox ID="TextBox2" Width="250" runat="server" placeholder="Ingrese un alias o #hashtag"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:LinkButton style="vertical-align:middle"  ID="LinkButton2" runat="server" OnClick="LinkSalir">Salir</asp:LinkButton>
        </div>
        <asp:Panel ID="Panel1" runat="server" class="form">
         
        <h2>Publicar:</h2>
            <p type="Imagen:">
                <asp:FileUpload CssClass="button1" ID="fup" accept="image/*" runat="server" required/>
            </p>
            <p type="Descripción:"> 
                <asp:TextBox ID="txtDescripcion" runat="server" placeholder="Ingrese una descripción de la imagen" required></asp:TextBox> </p>
            <p type="Hashtags:">
                <asp:TextBox ID="TxtHashtag" runat="server" placeholder="#Hashtag1 #hashtag2..."></asp:TextBox> 
            </p>
            <asp:Button CssClass="button1" ID="Button1" runat="server" Text="Subir" OnClick="Button1_Click" />
       
              </asp:Panel>
    </form>
        




        

    </body>
</html>
