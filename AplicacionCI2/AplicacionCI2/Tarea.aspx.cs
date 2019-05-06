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
    public partial class Tarea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Bta1_Click(object sender, EventArgs e)
        {
            AdminTarea at = new AdminTarea();
            //9219771-Leonardo-11am
            if (!String.IsNullOrEmpty(Tbta1.Text) & !String.IsNullOrEmpty(Tbta2.Text) & !String.IsNullOrEmpty(Tbta3.Text) & !String.IsNullOrEmpty(Tbta4.Text) & !String.IsNullOrEmpty(Tbta5.Text))
            {
                at.fcreacion = Convert.ToDateTime(Tbta1.Text);
                at.descripcion = Tbta2.Text;
                at.estado = Tbta3.Text;
                at.fvencimiento = Convert.ToDateTime(Tbta4.Text);
                at.autor = Tbta5.Text;
                at.query = "INSERT INTO tarea (fcreacion,descripcion,estado,fvencimiento,autor) VALUES ('"+ at.fcreacion+"','"+ at.descripcion+"','"+ at.estado+"','"+ at.fvencimiento+"','"+ at.autor+"');";
                at.WSCrearTarea();
                Lbta6.Text = "Tarea creada correctamente";
            }
            else
            {
                Lbta6.Text = "Ingrese todos los datos necesarios para crear la tarea";
            }
        }

        protected void Bta2_Click(object sender, EventArgs e)
        {
            AdminTarea at = new AdminTarea();
            at.query = "SELECT * FROM tarea;";
            DataSet ds = new DataSet();
            at.WSConsultarTarea(ds);
            GvTarea.DataSource = ds.Tables[0];
            GvTarea.DataBind();
        }

        protected void Bta3_Click(object sender, EventArgs e)
        {
            AdminTarea at = new AdminTarea();
            if (!String.IsNullOrEmpty(Tbta6.Text))
            {
                if (!String.IsNullOrEmpty(Tbta2.Text) & !String.IsNullOrEmpty(Tbta3.Text) & !String.IsNullOrEmpty(Tbta4.Text))
                {
                    at.descripcion = Tbta2.Text;
                    at.estado = Tbta3.Text;
                    at.fvencimiento = Convert.ToDateTime(Tbta4.Text);
                    at.query = "UPDATE tarea SET descripcion = '" + at.descripcion + "', estado = '" + at.estado + "', fvencimiento = '" + at.fvencimiento + "' WHERE idtarea = '" + Tbta6.Text + "';";
                    at.WSActualizarTarea();
                    Lbta6.Text = "Para la tarea de ID "+Tbta6.Text.ToString()+" se actualizo: " + Lbta2 + ", " + Lbta3 + ", " + Lbta4;
                }
                else
                {
                    if (String.IsNullOrEmpty(Tbta2.Text) & String.IsNullOrEmpty(Tbta3.Text) & String.IsNullOrEmpty(Tbta4.Text))
                    {
                        Lbta6.Text = "Ingrese los datos para actualizar la tarea";
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(Tbta2.Text))
                        {
                            at.descripcion = Tbta2.Text;
                            at.query = "UPDATE tarea SET descripcion = '" + at.descripcion + "' WHERE idtarea = '" + Tbta6.Text + "';";
                            at.WSActualizarTarea();
                        }
                        if (!String.IsNullOrEmpty(Tbta3.Text))
                        {
                            at.estado = Tbta3.Text;
                            at.query = "UPDATE tarea SET estado = '" + at.estado + "' WHERE idtarea = '" + Tbta6.Text + "';";
                            at.WSActualizarTarea();
                        }
                        if (!String.IsNullOrEmpty(Tbta4.Text))
                        {
                            at.fvencimiento = Convert.ToDateTime(Tbta4.Text);
                            at.query = "UPDATE tarea SET fvencimiento = '" + at.fvencimiento + "' WHERE idtarea = '" + Tbta6.Text + "';";
                            at.WSActualizarTarea();
                        }
                        Lbta6.Text = "Tarea de ID " + Tbta6.Text.ToString() + " actualizada";
                    }
                }
            }
            else
            {
                Lbta6.Text = "Ingrese el ID la tarea";
            }
        }

        protected void Bta4_Click(object sender, EventArgs e)
        {
            AdminTarea at = new AdminTarea();
            at.query = "SELECT * FROM tarea WHERE estado='"+ Tbta7.Text + "';";
            DataSet ds = new DataSet();
            at.WSConsultarTarea(ds);
            GvTarea.DataSource = ds.Tables[0];
            GvTarea.DataBind();
        }

        protected void Bta5_Click(object sender, EventArgs e)
        {
            AdminTarea at = new AdminTarea();
            at.query = "SELECT idtarea,fcreacion,descripcion,estado,fvencimiento,autor FROM tarea ORDER BY fvencimiento ASC;";
            DataSet ds = new DataSet();
            at.WSConsultarTarea(ds);
            GvTarea.DataSource = ds.Tables[0];
            GvTarea.DataBind();
        }

        protected void Bta6_Click(object sender, EventArgs e)
        {
            AdminTarea at = new AdminTarea();
            at.query = "SELECT idtarea,fcreacion,descripcion,estado,fvencimiento,autor FROM tarea ORDER BY fvencimiento DESC;";
            DataSet ds = new DataSet();
            at.WSConsultarTarea(ds);
            GvTarea.DataSource = ds.Tables[0];
            GvTarea.DataBind();
        }
    }
}