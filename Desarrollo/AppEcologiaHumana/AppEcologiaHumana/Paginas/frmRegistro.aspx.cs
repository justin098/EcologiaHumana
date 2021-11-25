using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Mant;
using DAL.Mant;

namespace AppEcologiaHumana.Paginas
{
    public partial class frmRegistro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrear_ServerClick(object sender, EventArgs e)
        {
            try
            {
                Cls_Login_BLL objBll = new Cls_Login_BLL();
                Cls_Login_DAL ObjDal = new Cls_Login_DAL();

                ObjDal.Usuario = lblEmail1.Value;
                ObjDal.Contrasena = lblPassword1.Value;

                string msgError = "";

                if (objBll.InsertarUsuario(ref msgError, ref ObjDal))
                {
                    Session["Usuario"] = ObjDal;
                    Response.Redirect("~/Paginas/frmCompletarPerfil.aspx");
                }
                else
                {
                    lblMensaje.InnerHtml = "No se pudo realizar el registro del usuario.";
                    lblMensaje.Visible = true;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}