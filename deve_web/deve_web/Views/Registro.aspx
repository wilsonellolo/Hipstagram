﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="deve_web.Views.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="UTF-8">
	<link rel="stylesheet" type="text/css" href="registro.css" media="all"> 
    <title></title>
</head>

<body> 
    
    <form id="form1" runat="server" class="form">
<div > 
		<img src="img.png">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Registrarse</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Entrar</asp:LinkButton>
      
		
	
</div>

  <h2>Registro</h2>
        <p type="Nombre:"><asp:TextBox ID="TextBox1" runat="server" placeholder="Ingrese su nombre"></asp:TextBox></p>
        <p type="Apellido:"></input><asp:TextBox ID="TextBox2" runat="server" placeholder="Ingrese su Apellido"></asp:TextBox> </p>
        <p type="Alias:"></input><asp:TextBox ID="TextBox3" runat="server" placeholder="Ingrese su Alias"></asp:TextBox> </p>
        <p type="Fecha de nacimiento:"></input><asp:TextBox ID="TextBox4" runat="server" placeholder="mes - dia -año"></asp:TextBox> </p>
        <p type="contraseña:"></input><asp:TextBox ID="TextBox5" runat="server" placeholder="Ingrese su contraseña" type="password"></asp:TextBox> </p>
        <p type="correo electronico:"></input><asp:TextBox ID="TextBox6" runat="server" placeholder="Ingrese su correo electronico"></asp:TextBox> </p>
 
        <asp:Button CssClass="button1" ID="Button1" runat="server" Text="Registrarme" OnClick="Button1_Click" />
    </form>

 
</body>
</html>
