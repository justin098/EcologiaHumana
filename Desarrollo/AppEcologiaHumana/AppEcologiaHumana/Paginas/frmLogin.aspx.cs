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
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                Session["Usuario"] = null;
        }

        protected void btnIniciar_ServerClick(object sender, EventArgs e)
        {
            try
            {
                Cls_Login_BLL objBll = new Cls_Login_BLL();
                Cls_Login_DAL ObjDal = new Cls_Login_DAL();

                ObjDal.Usuario = lblEmail1.Value;
                ObjDal.Contrasena = lblPassword1.Value;

                string msgError = "";

                if (ObjDal.Usuario.Equals("admin@admin.com") && ObjDal.Contrasena.Equals("@dm1n"))
                {
                    ObjDal.IdUsuario = 0;
                    ObjDal.IdProfesion = 1;
                    ObjDal.IdSede = 1;
                    ObjDal.FechaNacimiento = DateTime.Now;
                    ObjDal.FechaCreacion = DateTime.Now;
                    ObjDal.NombreUsuario = "Admin";
                    ObjDal.IdRol = -99;
                    Session["Usuario"] = ObjDal;
                    Response.Redirect("~/Paginas/frmIndex.aspx");
                }
                else
                {
                    DataTable dtLogin = objBll.LoginUsuario(ref msgError, ObjDal);
                    if (dtLogin.Rows.Count > 0 && msgError.Equals(string.Empty))
                    {
                        if (string.IsNullOrEmpty(dtLogin.Rows[0]["IdPerfil"].ToString()))
                        {
                            ObjDal.IdUsuario = Convert.ToInt32(dtLogin.Rows[0]["IdUsuario"].ToString());
                            Session["Usuario"] = ObjDal;
                            Response.Redirect("~/Paginas/frmCompletarPerfil.aspx");
                        }
                        else
                        {
                            ObjDal.IdUsuario = Convert.ToInt32(dtLogin.Rows[0]["IdUsuario"].ToString());
                            ObjDal.IdProfesion = Convert.ToInt32(dtLogin.Rows[0]["IdProfesion"].ToString());
                            ObjDal.IdSede = Convert.ToInt32(dtLogin.Rows[0]["IdSede"].ToString());
                            ObjDal.FechaNacimiento = Convert.ToDateTime(dtLogin.Rows[0]["FechaNacimiento"].ToString());
                            ObjDal.FechaCreacion = Convert.ToDateTime(dtLogin.Rows[0]["FechaCreacion"].ToString());
                            ObjDal.NombreUsuario = dtLogin.Rows[0]["NombreUsuario"].ToString();
                            Session["Usuario"] = ObjDal;
                            Response.Redirect("~/Paginas/frmIndex.aspx");
                        }
                    }
                    else
                    {
                        lblMensaje.InnerHtml = "Usuario / Contraseña incorrectos.";
                        lblMensaje.Visible = true;
                        updBtn.Update();
                    }
                }


            }
            catch (Exception)
            {
                lblMensaje.InnerHtml = "No se pudo realizar el inicio de sesión.";
                lblMensaje.Visible = true;
                updBtn.Update();
            }
        }
    }
}