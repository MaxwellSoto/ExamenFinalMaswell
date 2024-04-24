<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menuprincipal.aspx.cs" Inherits="ExamenFinal.Presentacion.Menuprincipal" %>

<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<link rel="stylesheet" href="styles.css">
<title>Menu</title>
</head>
<body>
<div class="circle-menu">
  <input type="checkbox" id="menu-toggle">
  <label for="menu-toggle" class="menu-icon">&#9776;</label>
  <div class="menu">
    <ul>
      <li><a href="/ExamenFinal-master/ExamenFinal/Capa Presentacion/Login.aspx">Inicio</a></li>
      <li><a href="/ExamenFinal-master/ExamenFinal/Capa Presentacion/Agente_Vista.aspx">Agentes</a></li>
      <li><a href="/ExamenFinal-master/ExamenFinal/Capa Presentacion/Clientes_View.aspx">Clientes</a></li>
    </ul>
  </div>
</div>
</body>
</html>
