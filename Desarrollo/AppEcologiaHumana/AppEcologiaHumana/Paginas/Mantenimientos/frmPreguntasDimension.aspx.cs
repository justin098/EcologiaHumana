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
    public partial class frmPreguntasDimension : System.Web.UI.Page
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
                Cls_Dimension_BLL objBll = new Cls_Dimension_BLL();
                Cls_Dimension_DAL ObjDal = new Cls_Dimension_DAL();

                string msgError = "";

                DataTable dtPreguntas = objBll.ListarPreguntas(ref msgError, Convert.ToInt32(valor));
                if (msgError.Equals(string.Empty) && dtPreguntas != null)
                {
                    txtIdPregunta.Value = dtPreguntas.Rows[0]["IdPregunta"].ToString();
                    txtPregunta.Value = dtPreguntas.Rows[0]["Pregunta"].ToString();
                    ddlTipoPregunta.SelectedValue = dtPreguntas.Rows[0]["Tipo"].ToString();
                    ddlEstiloPregunta.SelectedValue = dtPreguntas.Rows[0]["Estilo"].ToString();
                    ddlDimensiones.SelectedValue = dtPreguntas.Rows[0]["Dimension"].ToString();
                    btnCrear.InnerText = "Actualizar pregunta";
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
                Cls_Dimension_BLL objBll = new Cls_Dimension_BLL();
                Cls_Dimension_DAL ObjDal = new Cls_Dimension_DAL();

                string msgError = "";


                ObjDal.Pregunta = txtPregunta.Value.Trim();
                ObjDal.Tipo = Convert.ToInt32(ddlTipoPregunta.SelectedValue);
                ObjDal.Estilo = Convert.ToInt32(ddlEstiloPregunta.SelectedValue);
                ObjDal.Dimension = Convert.ToInt32(ddlDimensiones.SelectedValue);
                ObjDal.IdUsuario = objLogin.IdUsuario;

                bool resultado = false;
                if (dvIdPregunta.Visible)
                {
                    ObjDal.IdPregunta = Convert.ToInt32(txtIdPregunta.Value);
                    resultado = objBll.ActualizarPregunta(ref msgError, ref ObjDal);
                }
                else
                {
                    resultado = objBll.InsertarPregunta(ref msgError, ref ObjDal);
                }

                if (msgError.Equals(string.Empty) && resultado)
                {
                    Response.Redirect("~/Paginas/Mantenimientos/frmPreguntas.aspx");
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