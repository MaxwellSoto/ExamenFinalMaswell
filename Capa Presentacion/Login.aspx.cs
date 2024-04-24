using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal.Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
string username = txtUsuario.Text;
            string password = txtContra.Text;

            int resultado = ClsUsuario.Ingresar(username, password);

            if (resultado == 1)
            {
                Response.Redirect("CVistas/Inicio.aspx");
            }
            else
            {
                Response.Write($"<script>alert('Usuario o contraseña incorrectos: {username} y {password}');</script>");
            }
        }
    
      protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CVistas/Registrar.aspx");
        }
    }
}