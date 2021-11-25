using BLL.Mant;
using DAL.Mant;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppEcologiaHumana.Paginas.Dimensiones
{
    public partial class frmDimension1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarPreguntas();
        }

        private void CargarPreguntas()
        {
            try
            {
                Cls_Dimension_BLL objBll = new Cls_Dimension_BLL();
                Cls_Dimension_DAL ObjDal = new Cls_Dimension_DAL();

                string msgError = "";

                DataTable dtPreguntas1 = objBll.ListarPreguntasDimensionTipo(ref msgError, 1, 1);
                if (msgError.Equals(string.Empty) && dtPreguntas1 != null)
                {
                    rptFrecuencia.DataSource = dtPreguntas1;
                    rptFrecuencia.DataBind();

                    txtCantPregFrec.Value = dtPreguntas1.Rows.Count.ToString();

                    DataTable dtPreguntas2 = objBll.ListarPreguntasDimensionTipo(ref msgError, 1, 2);
                    if (msgError.Equals(string.Empty) && dtPreguntas2 != null)
                    {
                        rptTenencia.DataSource = dtPreguntas2;
                        rptTenencia.DataBind();
                        txtCantPregTen.Value = dtPreguntas2.Rows.Count.ToString();
                    }
                    else
                    {
                    }
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
                string val1 = txtCantPregFrec12.Text;
                string val2 = txtCantPregTen12.Text;

            }
            catch (Exception)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}