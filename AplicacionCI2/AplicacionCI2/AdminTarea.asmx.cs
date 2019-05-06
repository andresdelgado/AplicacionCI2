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
    /// Descripción breve de AdminTarea
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AdminTarea : System.Web.Services.WebService
    {

        public DateTime fcreacion;
        public String descripcion;
        public String estado;
        public DateTime fvencimiento;
        public String autor;

        public String query;

        [WebMethod]
        public DataSet WSCrearTarea()
        {
            SqlConnection conn = new SqlConnection("Server = DESKTOP-QLBL4RR; Database = tareasci; Integrated Security = true;");
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        [WebMethod]
        public DataSet WSConsultarTarea(DataSet ds)
        {
            SqlConnection conn = new SqlConnection("Server = DESKTOP-QLBL4RR; Database = tareasci; Integrated Security = true;");
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds);
            return ds;
        }

        [WebMethod]
        public DataSet WSActualizarTarea()
        {
            SqlConnection conn = new SqlConnection("Server = DESKTOP-QLBL4RR; Database = tareasci; Integrated Security = true;");
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
