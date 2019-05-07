using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionCI2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btu1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Tbu1.Text) & !String.IsNullOrEmpty(Tbu2.Text))
            {
                String usuario = Tbu1.Text;
                String contrasena = Tbu2.Text;
                String query = "SELECT * FROM autor WHERE usuario = '" + usuario + "' AND contrasena ='" + contrasena + "';";
                SqlConnection conn = new SqlConnection("Server = DESKTOP-QLBL4RR; Database = tareasci; Integrated Security = true;");

                conn.Open();
                
                SqlCommand com = new SqlCommand(query, conn);
                com.ExecuteNonQuery();
                SqlDataReader dr = com.ExecuteReader();
                
                if (dr.Read())
                {
                    //Para crear la sesion
                    Session["Usuario"] = usuario;
                    //Para redirigir la pagina si el usuario y contraseña son correctos
                    Response.Redirect("Tarea.aspx");
                }
                else
                {
                    Lbu3.Text = "Usuario o contraseña incorrectos";
                }
                conn.Close();
            }
            else
            {
                Lbu3.Text = "Ingrese el usuario y contraseña";
            }
        }
    }
}
 