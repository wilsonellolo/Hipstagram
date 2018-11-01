<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feed.aspx.cs" Inherits="deve_web.Views.Feed" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
	<link rel="stylesheet" type="text/css" href="feed.css" media="all"> 
    <title></title>
</head>
<body> 

    <form id="form1" runat="server" class="form">
<div > 

		<img src="img.png">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    <asp:LinkButton style="vertical-align:middle"  ID="LinkButton4" runat="server" OnClick="LinkButton2_Click">Buscar</asp:LinkButton> 
    <asp:TextBox ID="TextBox2" Width="250" runat="server" placeholder="Ingrese un alias o #hashtag"></asp:TextBox>
    <asp:LinkButton style="vertical-align:middle" ID="LinkButton3" runat="server" OnClick="LinkButton1_Click">Perfil</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
    <asp:LinkButton style="vertical-align:middle" ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Gestión</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:LinkButton style="vertical-align:middle"  ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Salir</asp:LinkButton>
      
		
	
</div>

  <h2>Publicar:</h2>
        <p type="Imagen:">
        <asp:FileUpload CssClass="button1" ID="fup" accept="image/*" runat="server" />
       </p>
        <p type="Descripción:"></input> 
            <asp:TextBox ID="txtDescripcion" runat="server" placeholder="Ingrese una descripción de la imagen"></asp:TextBox> </p>
        <p type="Hashtags:"></input> <asp:TextBox ID="TxtHashtag" runat="server" placeholder="#Hashtag1 #hashtag2..."></asp:TextBox> </p>
        <asp:Button CssClass="button1" ID="Button1" runat="server" Text="Subir" OnClick="Button1_Click" />
        
        <!--AQUI EMPIEZA EL FEED-->
        
        <asp:Image ID="imagen" runat="server" />
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
  	        <p > 
                  <asp:Button ID="Button2" runat="server" Text="imagen" OnClick="Button2_Click1" />
                  <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                  <asp:Button ID="Button4" runat="server" Text="Button" OnClick="Button4_Click" />
  	        </p>
                <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label> 
                <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
            <p>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
  	        </p>
            <asp:Button ID="Button5" runat="server" Text="Button" OnClick="Button5_Click" />
        
    
    </form>
        




        

    </body>
</html>
