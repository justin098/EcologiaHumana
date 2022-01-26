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
    public partial class frmUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ObtenerUsuarios();
            }
        }
        private void ObtenerUsuarios()
        {
            try
            {
                Cls_Login_BLL objBll = new Cls_Login_BLL();

                string msgError = "";

                DataTable dtUsuarios = objBll.ListarUsuarios(ref msgError);
                if (msgError.Equals(string.Empty) && dtUsuarios != null)
                {
                    gdvPreguntas.DataSource = dtUsuarios;
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
                    TableCell estado = e.Row.Cells[3];
                    if (estado.Text == "True")
                    {
                        estado.Text = "Activo";
                    }
                    else if (estado.Text == "False")
                    {
                        estado.Text = "Inactivo";
                    }

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
                int idUsuario = Convert.ToInt32(gdvPreguntas.Rows[index].Cells[1].Text);
                if (e.CommandName == "Editar")
                {
                    Response.Redirect("~/Paginas/Mantenimientos/frmMantUsuarios.aspx?id=" + idUsuario);
                }
                else if (e.CommandName == "Borrar")
                {
                    Cls_Login_BLL objBll = new Cls_Login_BLL();
                    Cls_Login_DAL ObjDal = new Cls_Login_DAL();

                    string msgError = "";
                    ObjDal.IdUsuario = idUsuario;

                    bool resultado = objBll.EliminarUsuario(ref msgError, ObjDal);
                    if (msgError.Equals(string.Empty) && resultado)
                    {
                        Response.Redirect("~/Paginas/Mantenimientos/frmUsuarios.aspx");
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
                ObtenerUsuarios();
            }
            catch (Exception)
            {

            }
        }
    }
}