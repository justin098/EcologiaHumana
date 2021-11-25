using BLL.Mant;
using DAL.Mant;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppEcologiaHumana.Paginas.Consejos
{
    public partial class frmConsejos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ObtenerConsejos();
            }
        }

        private void ObtenerConsejos()
        {
            try
            {
                Cls_Consejos_BLL objBll = new Cls_Consejos_BLL();
                Cls_Consejos_DAL ObjDal = new Cls_Consejos_DAL();

                string msgError = "";

                DataTable dtConsejos = objBll.ListarConsejos(ref msgError);
                if (msgError.Equals(string.Empty) && dtConsejos != null)
                {
                    rptConsejos.DataSource = dtConsejos;
                    rptConsejos.DataBind();
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