using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Mant;
using DAL.Mant;

namespace AppEcologiaHumana.Paginas
{
    public partial class frmIndex : System.Web.UI.Page
    {
        Cls_Login_DAL ObjLoginDal = new Cls_Login_DAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ObjLoginDal = (Cls_Login_DAL)Session["Usuario"];
                CalculoResultados();
                Roles();
            }
        }

        private void Roles()
        {
            try
            {
                if (ObjLoginDal.IdRol == -99)
                {
                    btnDimension1.Visible = false;
                    btnDimension2.Visible = false;
                    btnDimension3.Visible = false;
                    btnDimension4.Visible = false;
                }
            }
            catch (Exception)
            {

            }
        }

        private void CalculoResultados()
        {
            try
            {
                Cls_Dimension_BLL objBll = new Cls_Dimension_BLL();
                Cls_Dimension_DAL ObjDal = new Cls_Dimension_DAL();



                int idUsuario = ObjLoginDal.IdUsuario;

                string msgError = "";
                int resultadoCalc = 0;
                int resultadoTotal = 0;


                resultadoCalc = objBll.CalculoPreguntasDimension(ref msgError, 1);
                resultadoTotal = objBll.ResultadoDimensionTotal(ref msgError, 1, idUsuario);
                lblResDim1.InnerText = resultadoTotal + "/" + resultadoCalc;
                resultadoCalc = 0;
                resultadoTotal = 0;

                resultadoCalc = objBll.CalculoPreguntasDimension(ref msgError, 2);
                resultadoTotal = objBll.ResultadoDimensionTotal(ref msgError, 2, idUsuario);
                lblResDim2.InnerText = resultadoTotal + "/" + resultadoCalc;
                resultadoCalc = 0;
                resultadoTotal = 0;

                resultadoCalc = objBll.CalculoPreguntasDimension(ref msgError, 3);
                resultadoTotal = objBll.ResultadoDimensionTotal(ref msgError, 3, idUsuario);
                lblResDim3.InnerText = resultadoTotal + "/" + resultadoCalc;
                resultadoCalc = 0;
                resultadoTotal = 0;

                resultadoCalc = objBll.CalculoPreguntasDimension(ref msgError, 4);
                resultadoTotal = objBll.ResultadoDimensionTotal(ref msgError, 4, idUsuario);
                lblResDim4.InnerText = resultadoTotal + "/" + resultadoCalc;

            }
            catch (Exception)
            {

            }
        }
    }
}