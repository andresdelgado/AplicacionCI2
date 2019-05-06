using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionCI2
{
    public partial class Autor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void B1_Click(object sender, EventArgs e)
        {
            AdminUsuario au = new AdminUsuario();
            if (!String.IsNullOrEmpty(Tb1.Text) & !String.IsNullOrEmpty(Tb2.Text) & !String.IsNullOrEmpty(Tb3.Text))
            {
                au.nombre = Tb1.Text;
                au.usuario = Tb2.Text;
                au.contrasena = Tb3.Text;
                au.query = "INSERT INTO autor (nombre, usuario, contrasena) VALUES ('" + au.nombre + "','" + au.usuario + "','" + au.contrasena + "');";
                au.WSCrearUsuario();
                Lb4.Text = "Usuario creado correctamente";
            }
            else
            {
                Lb4.Text = "Ingrese los datos correctamente para crear el usuario";
            }

        }

        protected void B2_Click(object sender, EventArgs e)
        {
            AdminUsuario au = new AdminUsuario();
            au.query = "SELECT * FROM autor;";
            DataSet ds = new DataSet();
            au.WSConsultarUsuario(ds);
            GvLogin.DataSource = ds.Tables[0];
            GvLogin.DataBind();
            //au.query = "SELECT * FROM autor WHERE nombre ='" + au.nombre + "';";
        }

        protected void B3_Click(object sender, EventArgs e)
        {
            AdminUsuario au = new AdminUsuario();
            if (!String.IsNullOrEmpty(Tb1.Text) & !String.IsNullOrEmpty(Tb2.Text) & !String.IsNullOrEmpty(Tb3.Text) & !String.IsNullOrEmpty(Tb4.Text))
            {
                au.nombre = Tb1.Text;
                au.usuario = Tb2.Text;
                au.contrasena = Tb3.Text;
                au.query = "UPDATE autor SET nombre = '" + au.nombre + "', usuario = '" + au.usuario + "', contrasena = '" + au.contrasena + "' WHERE idautor = '" + Tb4.Text + "';";
                au.WSActualizarUsuario();
                Lb4.Text = "Usuario actualizado correctamente";
            }
            else
            {
                Lb4.Text = "Ingrese los datos correctamente para actualizar el usuario";
            }
        }

        protected void B4_Click(object sender, EventArgs e)
        {
            AdminUsuario au = new AdminUsuario();
            if (!String.IsNullOrEmpty(Tb5.Text))
            {
                au.query = "DELETE FROM autor WHERE idautor = '" + Tb5.Text + "';";
                au.WSEliminarUsuario();
                Lb4.Text = "Usuario eliminado correctamente";
            }
            else
            {
                Lb4.Text = "Ingrese el ID del usuario a eliminar";
            }
        }
    }
}