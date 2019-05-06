using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AplicacionCI2
{
    /// <summary>
    /// Descripción breve de AdminUsuario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AdminUsuario : System.Web.Services.WebService
    {

        public String nombre;
        public String usuario;
        public String contrasena;

        public String query;

        [WebMethod]
        public DataSet WSCrearUsuario()
        {
            //String query = "INSERT INTO tarea (fcreacion,descripcion,estado,fvencimiento,autor) VALUES ('"+fcreacion+"','"+descripcion+"','"+estado+"','"+fvencimiento+"','"+autor+"');";
            //String query = "INSERT INTO autor (nombre, usuario, contrasena) VALUES ('" + nombre + "','" + usuario + "','" + contrasena + "');";
            SqlConnection conn = new SqlConnection("Server = DESKTOP-QLBL4RR; Database = tareasci; Integrated Security = true;");
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        [WebMethod]
        public DataSet WSConsultarUsuario(DataSet ds)
        {
            SqlConnection conn = new SqlConnection("Server = DESKTOP-QLBL4RR; Database = tareasci; Integrated Security = true;");
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds);
            return ds;
        }

        [WebMethod]
        public DataSet WSActualizarUsuario()
        {
            SqlConnection conn = new SqlConnection("Server = DESKTOP-QLBL4RR; Database = tareasci; Integrated Security = true;");
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        [WebMethod]
        public DataSet WSEliminarUsuario()
        {
            SqlConnection conn = new SqlConnection("Server = DESKTOP-QLBL4RR; Database = tareasci; Integrated Security = true;");
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
