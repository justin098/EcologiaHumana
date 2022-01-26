using BLL.Mant;
using DAL.Mant;
using System;
using System.Collections.Generic;
using System.Data;
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
            if (!IsPostBack)
            {
                CargarDatos();
                CalculoResultados();
                Roles();
            }
        }
        Cls_Login_DAL ObjLoginDal = new Cls_Login_DAL();

        private void CargarDatos()
        {
            try
            {

                ObjLoginDal = (Cls_Login_DAL)Session["Usuario"];
                if (ObjLoginDal == null)
                {
                    Response.Redirect("~/Paginas/frmLogin.aspx");
                }
                lblNombre.InnerHtml = ObjLoginDal.NombreUsuario;
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

                string msgError = "";
                int resultadoCalc = 0;
                int resultadoTotal = 0;

                int idUsuario = ObjLoginDal.IdUsuario;


                resultadoCalc = objBll.CalculoPreguntasDimension(ref msgError, 1);
                resultadoTotal = objBll.ResultadoDimensionTotal(ref msgError, 1, idUsuario);


                resultadoCalc += objBll.CalculoPreguntasDimension(ref msgError, 2);
                resultadoTotal += objBll.ResultadoDimensionTotal(ref msgError, 2, idUsuario);


                resultadoCalc += objBll.CalculoPreguntasDimension(ref msgError, 3);
                resultadoTotal += objBll.ResultadoDimensionTotal(ref msgError, 3, idUsuario);


                resultadoCalc += objBll.CalculoPreguntasDimension(ref msgError, 4);
                resultadoTotal += objBll.ResultadoDimensionTotal(ref msgError, 4, idUsuario);


                lblResultadoCal.InnerText = resultadoTotal + "/" + resultadoCalc;

            }
            catch (Exception)
            {

            }
        }

        private void Roles()
        {
            try
            {
                if (ObjLoginDal.IdRol == -99)
                {
                    dvMantConsejos.Visible = false;
                    dvPreguntas.Visible = false;
                    dvPerfil.Visible = false;
                    dvPerfil2.Visible = false;
                }
                else if (ObjLoginDal.IdRol == 1)
                {
                    dvMants.Visible = false;
                    ulMants.Visible = false;
                    dvReportes.Visible = false;
                    ulReportes.Visible = false;
                }
                else if (ObjLoginDal.IdRol == 3)
                {
                    dvMants.Visible = false;
                    ulMants.Visible = false;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}