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
    public partial class frmMantUsuarios : System.Web.UI.Page
    {
        Cls_Login_DAL objLogin;
        string valor = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            objLogin = (Cls_Login_DAL)Session["Usuario"];
            if (!IsPostBack)
            {

                ObtenerSedes();
                ObtenerPerfiles();
                ObtenerRoles();

                valor = Convert.ToString(Request.QueryString["id"]);

                if (valor != null)
                {
                    ObtenerUsuario(valor);
                }
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

        private void ObtenerRoles()
        {
            try
            {
                Cls_Login_BLL objBll = new Cls_Login_BLL();
                Cls_Login_DAL ObjDal = new Cls_Login_DAL();

                string msgError = "";

                DataTable dtRoles = objBll.ListarRoles(ref msgError);
                if (msgError.Equals(string.Empty) && dtRoles != null)
                {
                    ddlRol.DataSource = dtRoles;
                    ddlRol.DataTextField = "NombreRol";
                    ddlRol.DataValueField = "IdRol";
                    ddlRol.DataBind();
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

        private void ObtenerUsuario(string valor)
        {
            try
            {
                Cls_Login_BLL objBll = new Cls_Login_BLL();
                Cls_Login_DAL objDal = new Cls_Login_DAL();

                objDal.IdUsuario = Convert.ToInt32(valor);
                string msgError = "";

                DataTable dtUsuario = objBll.ListarUsuario(ref msgError, objDal);
                if (msgError.Equals(string.Empty) && dtUsuario != null)
                {
                    txtUsuario.Value = dtUsuario.Rows[0]["Usuario"].ToString();
                    DateTime dtFecNac = Convert.ToDateTime(dtUsuario.Rows[0]["FechaNacimiento"].ToString());
                    txtFechaNac.Value = dtFecNac.ToString("yyyy-MM-dd");
                    txtNombreUsuario.Value = dtUsuario.Rows[0]["NombreUsuario"].ToString();
                    ddlSedes.SelectedValue = dtUsuario.Rows[0]["IdSede"].ToString();
                    ddlProfesiones.SelectedValue = dtUsuario.Rows[0]["IdProfesion"].ToString();
                    ddlRol.SelectedValue = dtUsuario.Rows[0]["IdRol"].ToString();
                    if (Convert.ToBoolean(dtUsuario.Rows[0]["Estado"].ToString()))
                        selectEstado.Value = "A";
                    else
                        selectEstado.Value = "I";
                    selectSexo.Value = dtUsuario.Rows[0]["Sexo"].ToString();
                    dvIdPregunta.Visible = true;
                    txtIdUsuario.Value = valor;
                    btnCrear.InnerText = "Actualizar usuario";

                }
                else
                {
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

                string msgError = "";

                ObjDal.Usuario = txtUsuario.Value.Trim();
                char estado = Convert.ToChar(selectEstado.Value);
                if (estado.Equals('A'))
                {
                    ObjDal.Estado = true;
                }
                else
                {
                    ObjDal.Estado = false;
                }
                ObjDal.Contrasena = txtContrasena.Value.Trim();
                ObjDal.NombreUsuario = txtNombreUsuario.Value.Trim();
                string fecha = txtFechaNac.Value.Trim();
                ObjDal.FechaNacimiento = Convert.ToDateTime(fecha);
                ObjDal.Sexo = Convert.ToChar(selectSexo.Value);
                ObjDal.IdSede = Convert.ToInt32(ddlSedes.SelectedValue);
                ObjDal.IdProfesion = Convert.ToInt32(ddlProfesiones.SelectedValue);
                ObjDal.IdRol = Convert.ToInt32(ddlRol.SelectedValue);

                bool resultado = false;
                if (dvIdPregunta.Visible)
                {
                    ObjDal.IdUsuario = Convert.ToInt32(txtIdUsuario.Value);
                    resultado = objBll.ActualizarUsuarioPerfil(ref msgError, ref ObjDal);
                }
                else
                {
                    resultado = objBll.InsertarUsuarioPerfil(ref msgError, ref ObjDal);
                }

                if (msgError.Equals(string.Empty) && resultado)
                {
                    Response.Redirect("~/Paginas/Mantenimientos/frmUsuarios.aspx");
                }
                else
                {
                }
            }
            catch (Exception)
            {

            }
        }
    }
}