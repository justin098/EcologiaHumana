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
    public partial class frmConsejos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ObtenerConsejos();
            }
        }
        private void ObtenerConsejos()
        {
            try
            {
                Cls_Consejos_BLL objBll = new Cls_Consejos_BLL();

                string msgError = "";

                DataTable dtConsejos = objBll.ListarConsejos(ref msgError);
                if (msgError.Equals(string.Empty) && dtConsejos != null)
                {
                    gdvPreguntas.DataSource = dtConsejos;
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

        protected void gdvPreguntas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    TableCell Consejo = e.Row.Cells[2];
                    Consejo.Text = Consejo.Text.Substring(0, 30);

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
                int idConsejo = Convert.ToInt32(gdvPreguntas.Rows[index].Cells[1].Text);
                if (e.CommandName == "Editar")
                {
                    Response.Redirect("~/Paginas/Mantenimientos/frmMantConsejos.aspx?id=" + idConsejo);
                }
                else if (e.CommandName == "Borrar")
                {
                    Cls_Consejos_BLL objBll = new Cls_Consejos_BLL();
                    Cls_Consejos_DAL ObjDal = new Cls_Consejos_DAL();

                    string msgError = "";
                    ObjDal.IdConsejo = idConsejo;

                    bool resultado = objBll.EliminarConsejo(ref msgError, ref ObjDal);
                    if (msgError.Equals(string.Empty) && resultado)
                    {
                        Response.Redirect("~/Paginas/Mantenimientos/frmConsejos.aspx");
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
                gdvPreguntas.PageIndex = e.NewPageIndex;
                ObtenerConsejos();
            }
            catch (Exception)
            {

            }
        }
    }
}
