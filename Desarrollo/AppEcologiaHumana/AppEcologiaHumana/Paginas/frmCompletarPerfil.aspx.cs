using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Mant;
using DAL.Mant;
using System.Data;

namespace AppEcologiaHumana.Paginas
{
    public partial class frmCompletarPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ObtenerSedes();
                ObtenerPerfiles();
            }
            catch (Exception ex)
            {

            }
        }

        private void ObtenerSedes()
        {
            try
            {
                Cls_Login_BLL objBll = new Cls_Login_BLL();
                Cls_Login_DAL ObjDal = new Cls_Login_DAL();

                string msgError = "";

                DataTable dtSedes = objBll.ListarSedes(ref msgError);
                if (msgError.Equals(string.Empty) && dtSedes != null)
                {
                    ddlSedes.DataSource = dtSedes;
                    ddlSedes.DataTextField = "Descripcion";
                    ddlSedes.DataValueField = "IdSede";
                    ddlSedes.DataBind();
                }
                else
                {
                    ddlSedes.DataSource = null;
                    ddlSedes.DataBind();
                }

            }
            catch (Exception)
            {

            }
        }

        private void ObtenerPerfiles()
        {
            try
            {
                Cls_Login_BLL objBll = new Cls_Login_BLL();
                Cls_Login_DAL ObjDal = new Cls_Login_DAL();

                string msgError = "";

                DataTable dtrofesiones = objBll.ListarProfesiones(ref msgError);
                if (msgError.Equals(string.Empty) && dtrofesiones != null)
                {
                    ddlProfesiones.DataSource = dtrofesiones;
                    ddlProfesiones.DataTextField = "NombreProfesion";
                    ddlProfesiones.DataValueField = "IdProfesion";
                    ddlProfesiones.DataBind();
                }
                else
                {
                    ddlProfesiones.DataSource = null;
                    ddlProfesiones.DataBind();
                }

            }
            catch (Exception)
            {

            }
        }

        protected void btnCrear_ServerClick(object sender, EventArgs e)
        {
            try
            {
                Cls_Login_BLL objBll = new Cls_Login_BLL();
                Cls_Login_DAL ObjDal = new Cls_Login_DAL();

                ObjDal = (Cls_Login_DAL)Session["Usuario"];

                string msgError = "";

                ObjDal.NombreUsuario = txtUsuario.Value.Trim();
                string fecha = txtFechaNac.Value.Trim();
                ObjDal.FechaNacimiento = Convert.ToDateTime(fecha);
                ObjDal.Sexo = Convert.ToChar(selectSexo.Value);
                ObjDal.IdSede = Convert.ToInt32(ddlSedes.SelectedValue);
                ObjDal.IdProfesion = Convert.ToInt32(ddlProfesiones.SelectedValue);

                if (objBll.InsertarPerfil(ref msgError, ref ObjDal))
                {
                    Session["Usuario"] = ObjDal;
                    Response.Redirect("~/Paginas/frmIndex.aspx");
                }
                else
                {
                    lblMensaje.InnerHtml = "No se pudo realizar el registro del usuario. <br> Intente nuevamente o más tarde.";
                    lblMensaje.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}