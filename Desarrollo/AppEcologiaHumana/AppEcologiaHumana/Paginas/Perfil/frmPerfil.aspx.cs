using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Mant;
using DAL.Mant;
using System.Data;

namespace AppEcologiaHumana.Paginas.Perfil
{
    public partial class frmPerfil : System.Web.UI.Page
    {
        Cls_Login_DAL ObjLoginDal = new Cls_Login_DAL();

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                ObjLoginDal = (Cls_Login_DAL)Session["Usuario"];

                if (!IsPostBack)
                {
                    ObtenerSedes();
                    ObtenerPerfiles();
                    ObtenerPerfilUsuario();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void ObtenerPerfilUsuario()
        {
            try
            {
                Cls_Login_BLL objBll = new Cls_Login_BLL();

                string msgError = "";

                DataTable dtPerfil = objBll.ListarPerfil(ref msgError, ObjLoginDal);
                if (msgError.Equals(string.Empty) && dtPerfil != null)
                {
                    txtUsuario.Value = dtPerfil.Rows[0]["NombreUsuario"].ToString();
                    DateTime dtFecNac = Convert.ToDateTime(dtPerfil.Rows[0]["FechaNacimiento"].ToString());
                    txtFechaNac.Value = dtFecNac.ToString("yyyy-MM-dd");
                    ddlSedes.SelectedValue = dtPerfil.Rows[0]["IdSede"].ToString();
                    ddlProfesiones.SelectedValue = dtPerfil.Rows[0]["IdProfesion"].ToString();
                    selectSexo.Value = dtPerfil.Rows[0]["Sexo"].ToString();
                }
                else
                {
                }
            }
            catch (Exception)
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
                ObjDal.IdUsuario = ObjLoginDal.IdUsuario;

                if (objBll.ActualizarPerfil(ref msgError, ref ObjDal))
                {
                    Response.Redirect("~/Paginas/Perfil/frmPerfil.aspx");
                }
                else
                {
                    lblMensaje.InnerHtml = "No se pudo actualizar el usuario. <br> Intente nuevamente o más tarde.";
                    lblMensaje.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        protected void btnProgreso_ServerClick(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("~/Paginas/Perfil/frmProgreso.aspx");

            }
            catch (Exception)
            {
                
            }
        }
    }
}