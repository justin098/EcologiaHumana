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
    public partial class frmMantConsejos : System.Web.UI.Page
    {
        Cls_Login_DAL objLogin;
        string valor = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            objLogin = (Cls_Login_DAL)Session["Usuario"];
            if (!IsPostBack)
            {
                valor = Convert.ToString(Request.QueryString["id"]);

                if (valor != null)
                {
                    ObtenerPregunta(valor);
                }
            }
        }

        private void ObtenerPregunta(string valor)
        {
            try
            {
                Cls_Consejos_BLL objBll = new Cls_Consejos_BLL();
                Cls_Consejos_DAL ObjDal = new Cls_Consejos_DAL();

                string msgError = "";

                DataTable dtPreguntas = objBll.ListarConsejo(ref msgError, Convert.ToInt32(valor));
                if (msgError.Equals(string.Empty) && dtPreguntas != null)
                {
                    txtIdConsejo.Value = dtPreguntas.Rows[0]["IdConsejo"].ToString();
                    txtConsejo.Value = dtPreguntas.Rows[0]["Consejo"].ToString();
                    ddlDimensiones.SelectedValue = dtPreguntas.Rows[0]["Dimension"].ToString();
                    btnCrear.InnerText = "Actualizar consejo";
                    dvIdPregunta.Visible = true;
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
                Cls_Consejos_BLL objBll = new Cls_Consejos_BLL();
                Cls_Consejos_DAL ObjDal = new Cls_Consejos_DAL();

                string msgError = "";


                ObjDal.Consejo = txtConsejo.Value.Trim();
                ObjDal.Dimension = Convert.ToInt32(ddlDimensiones.SelectedValue);
                ObjDal.IdUsuario = objLogin.IdUsuario;

                bool resultado = false;
                if (dvIdPregunta.Visible)
                {
                    ObjDal.IdConsejo = Convert.ToInt32(txtIdConsejo.Value);
                    resultado = objBll.ActualizarConsejo(ref msgError, ref ObjDal);
                }
                else
                {
                    resultado = objBll.InsertarConsejo(ref msgError, ref ObjDal);
                }

                if (msgError.Equals(string.Empty) && resultado)
                {
                    Response.Redirect("~/Paginas/Mantenimientos/frmConsejos.aspx");
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