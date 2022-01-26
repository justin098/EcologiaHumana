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
    public partial class frmDimension3 : System.Web.UI.Page
    {
        Cls_Login_DAL ObjLoginDal = new Cls_Login_DAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            ObjLoginDal = (Cls_Login_DAL)Session["Usuario"];

            if (!IsPostBack)
            {

                Cls_Dimension_BLL objBll = new Cls_Dimension_BLL();
                string msgError = "";
                int resultadoCalc = 0;
                int resultadoTotal = 0;

                DataTable resultadoDT = objBll.ResultadoDimension(ref msgError, 3, ObjLoginDal.IdUsuario);
                if (resultadoDT.Rows.Count != 0)
                {
                    dvMensaje.Visible = true;
                    appCapsule.Visible = false;
                    resultadoTotal = Convert.ToInt32(resultadoDT.Rows[0]["TotalResultado"].ToString());

                }
                else
                {
                    dvMensaje.Visible = false;
                    appCapsule.Visible = true;
                    CargarPreguntas();
                }

                resultadoCalc = objBll.CalculoPreguntasDimension(ref msgError, 3);
                lblResDim3.InnerText = resultadoTotal + "/" + resultadoCalc;
            }
        }

        private void CargarPreguntas()
        {
            try
            {
                Cls_Dimension_BLL objBll = new Cls_Dimension_BLL();
                Cls_Dimension_DAL ObjDal = new Cls_Dimension_DAL();

                string msgError = "";

                DataTable dtPreguntas1 = objBll.ListarPreguntasDimensionTipo(ref msgError, 3, 1);
                if (msgError.Equals(string.Empty) && dtPreguntas1 != null)
                {
                    rptFrecuencia.DataSource = dtPreguntas1;
                    rptFrecuencia.DataBind();

                    txtCantPregFrec.Value = dtPreguntas1.Rows.Count.ToString();

                    DataTable dtPreguntas2 = objBll.ListarPreguntasDimensionTipo(ref msgError, 3, 2);
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

                string[] pregFrec = val1.Split(',');
                int resTotFrec = 0;

                for (int i = 0; i < pregFrec.Length - 1; i++)
                {
                    string[] resFrec = pregFrec[i].Split('-');
                    if (resFrec[0].Equals("4"))
                    {
                        resTotFrec += 0;
                    }
                    else
                    {
                        resTotFrec += Convert.ToInt32(resFrec[0]);
                    }
                }


                string[] pregTen = val2.Split(',');
                int resTotTen = 0;

                for (int i = 0; i < pregTen.Length - 1; i++)
                {
                    string[] resTen = pregTen[i].Split('-');
                    if (resTen[0].Equals("4"))
                    {
                        resTotTen += 0;
                    }
                    else
                    {
                        resTotTen += Convert.ToInt32(resTen[0]);
                    }
                }

                int cantPreg = (pregFrec.Length - 1) + (pregTen.Length - 1);
                int totFrecTen = resTotFrec + resTotTen;

                double xM = (cantPreg * 3);
                double Di = totFrecTen / xM;

                int ITot = Convert.ToInt32(Di * 1000);

                Cls_Dimension_BLL objBll = new Cls_Dimension_BLL();
                Cls_ResultadoDimension_DAL ObjDal = new Cls_ResultadoDimension_DAL();

                string msgError = "";

                ObjDal.TotalResultado = ITot;
                ObjDal.IdUsuario = ObjLoginDal.IdUsuario;
                ObjDal.Dimension = 3;


                objBll.InsertarResultadoDimension(ref msgError, ref ObjDal);

                if (msgError.Equals(string.Empty))
                {
                    Response.Redirect("~/Paginas/Dimensiones/frmDimension3.aspx");
                }
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