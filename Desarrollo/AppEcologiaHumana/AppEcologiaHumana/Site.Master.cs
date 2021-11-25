using DAL.Mant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppEcologiaHumana
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                Cls_Login_DAL ObjDal = new Cls_Login_DAL();

                ObjDal = (Cls_Login_DAL)Session["Usuario"];

                lblNombre.InnerHtml = ObjDal.NombreUsuario;
            }
            catch (Exception)
            {

            }
        }
    }
}