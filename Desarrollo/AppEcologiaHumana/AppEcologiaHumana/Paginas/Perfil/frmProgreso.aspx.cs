using BLL.Mant;
using DAL.Mant;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace AppEcologiaHumana.Paginas.Perfil
{
    public partial class frmProgreso : System.Web.UI.Page
    {
        Cls_Login_DAL ObjLoginDal = new Cls_Login_DAL();


        protected void Page_Load(object sender, EventArgs e)
        {
            ObjLoginDal = (Cls_Login_DAL)Session["Usuario"];
            if (!IsPostBack)
            {
                ConsultaProgresoGrafico(1);
            }
        }

        private void ConsultaProgresoGrafico(int IdDimension)
        {
            try
            {
                Cls_Dimension_BLL objBll = new Cls_Dimension_BLL();
                string msgError = "";

                DataTable resultadoDT = objBll.ResultadoDimensionGrafico(ref msgError, IdDimension, ObjLoginDal.IdUsuario);
                if (resultadoDT.Rows.Count > 0)
                {
                    int[] barras = new int[resultadoDT.Rows.Count];
                    string[] nombs = new string[resultadoDT.Rows.Count];

                    int cont = 0;

                    Graficas.Titles.Add("Dimensión " + IdDimension);
                    foreach (DataRow item in resultadoDT.Rows)
                    {
                        barras[cont] = Convert.ToInt32(item["TotalResultado"].ToString());
                        nombs[cont] = Convert.ToDateTime(item["Fecha"].ToString()).ToString("dd/MM/yyyy");
                        cont++;
                    }

                    Graficas.Series["Serie"].Points.DataBindXY(nombs, barras);
                }

            }
            catch (Exception ex)
            {

            }
        }

        protected void imgDim1_ServerClick(object sender, EventArgs e)
        {
            ConsultaProgresoGrafico(1);
            updPanel.Update();
        }

        protected void imgDim2_ServerClick(object sender, EventArgs e)
        {
            ConsultaProgresoGrafico(2);
            updPanel.Update();

        }

        protected void imgDim3_ServerClick(object sender, EventArgs e)
        {
            ConsultaProgresoGrafico(3);
            updPanel.Update();

        }

        protected void imgDim4_ServerClick(object sender, EventArgs e)
        {
            ConsultaProgresoGrafico(4);
            updPanel.Update();

        }
    }
}