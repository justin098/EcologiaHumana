using BLL.Mant;
using DAL.Mant;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppEcologiaHumana.Paginas.Mantenimientos
{
    public partial class frmPreguntas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ObtenerPreguntasDimension(1);
                lblIdDim.InnerHtml = "1";
            }
        }
        private void ObtenerPreguntasDimension(int dimension)
        {
            try
            {
                Cls_Dimension_BLL objBll = new Cls_Dimension_BLL();
                Cls_Dimension_DAL ObjDal = new Cls_Dimension_DAL();

                string msgError = "";

                DataTable dtPreguntas = objBll.ListarPreguntasDimension(ref msgError, dimension);
                if (msgError.Equals(string.Empty) && dtPreguntas != null)
                {
                    gdvPreguntas.DataSource = dtPreguntas;
                    gdvPreguntas.DataBind();
                }
                else
                {
                    gdvPreguntas.DataSource = null;
                    gdvPreguntas.DataBind();
                }

            }
            catch (Exception)
            {

            }
        }

        protected void btnConsultar_ServerClick(object sender, EventArgs e)
        {
            try
            {
                int dimension = Convert.ToInt32(ddlDimension.Value);
                lblIdDim.InnerHtml = dimension.ToString();
                ObtenerPreguntasDimension(dimension);
            }
            catch (Exception)
            {

            }
        }

        protected void gdvPreguntas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    TableCell tipoPreg = e.Row.Cells[3];
                    if (tipoPreg.Text == "1")
                    {
                        tipoPreg.Text = "Principiante";
                    }
                    else if (tipoPreg.Text == "2")
                    {
                        tipoPreg.Text = "Promedio";
                    }
                    else if (tipoPreg.Text == "3")
                    {
                        tipoPreg.Text = "Hábil";
                    }
                    else if (tipoPreg.Text == "4")
                    {
                        tipoPreg.Text = "Especialista";
                    }
                    else if (tipoPreg.Text == "5")
                    {
                        tipoPreg.Text = "Experto";
                    }

                    TableCell EstiloPreg = e.Row.Cells[4];
                    if (EstiloPreg.Text == "1")
                    {
                        EstiloPreg.Text = "Frecuencia";
                    }
                    else if (EstiloPreg.Text == "2")
                    {
                        EstiloPreg.Text = "Tenencia";
                    }

                    TableCell Pregunta = e.Row.Cells[2];
                    Pregunta.Text = Pregunta.Text.Substring(0, 30);

                }
            }
            catch (Exception)
            {

            }
        }

        protected void gdvPreguntas_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            try
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gdvPreguntas.Rows[index];
                int idPregunta = Convert.ToInt32(gdvPreguntas.Rows[index].Cells[1].Text);
                if (e.CommandName == "Editar")
                {
                    Response.Redirect("~/Paginas/Mantenimientos/frmPreguntasDimension.aspx?id=" + idPregunta);
                }
                else if (e.CommandName == "Borrar")
                {
                    Cls_Dimension_BLL objBll = new Cls_Dimension_BLL();
                    Cls_Dimension_DAL ObjDal = new Cls_Dimension_DAL();

                    string msgError = "";
                    ObjDal.IdPregunta = idPregunta;

                    bool resultado = objBll.EliminarPregunta(ref msgError, ref ObjDal);
                    if (msgError.Equals(string.Empty) && resultado)
                    {
                        Response.Redirect("~/Paginas/Mantenimientos/frmPreguntas.aspx");
                    }
                    else
                    {
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        protected void gdvPreguntas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                int IdDimension = Convert.ToInt32(lblIdDim.InnerHtml);
                gdvPreguntas.PageIndex = e.NewPageIndex;
                ObtenerPreguntasDimension(IdDimension);
            }
            catch (Exception)
            {

            }
        }
    }
}
