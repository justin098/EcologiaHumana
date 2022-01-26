using BLL.Mant;
using DAL.Mant;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace AppEcologiaHumana.Paginas.Reportes
{
    public partial class frmReporteResultados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ObtenerResultados();
            }
        }

        private void ObtenerResultados()
        {
            try
            {
                Cls_Login_BLL objBll = new Cls_Login_BLL();

                string msgError = "";

                DataTable dtUsuarios = objBll.ListarResultados(ref msgError);
                if (msgError.Equals(string.Empty) && dtUsuarios != null)
                {
                    gdvPreguntas.DataSource = dtUsuarios;
                    gdvPreguntas.DataBind();
                }
                else
                {
                    gdvPreguntas.DataSource = null;
                    gdvPreguntas.DataBind();
                }

            }
            catch (Exception)
            {

            }
        }

        protected void gdvPreguntas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                gdvPreguntas.PageIndex = e.NewPageIndex;
                ObtenerResultados();
            }
            catch (Exception)
            {

            }
        }

        protected void lnkExport_Click(object sender, EventArgs e)
        {
            try
            {
                Response.ClearContent();
                Response.Buffer = true;
                Response.AddHeader("content-disposition", string.Format("attachment; filename={0}", "ReporteResultados" + DateTime.Now + ".xls"));
                Response.ContentType = "application/ms-excel";
                StringBuilder sb = new StringBuilder();
                StringWriter sw = new StringWriter(sb);
                HtmlTextWriter htw = new HtmlTextWriter(sw);
                HtmlForm form = new HtmlForm();
                Page page = new Page();
                gdvPreguntas.AllowPaging = false;
                ObtenerResultados();
                // Deshabilitar la validación de eventos, sólo asp.net 2
                page.EnableEventValidation = false;

                // Realiza las inicializaciones de la instancia de la clase Page que requieran los diseñadores RAD.
                page.DesignerInitialize();
                gdvPreguntas.HeaderRow.Style.Add("background-color", "#FFFFFF");
                for (int a = 0; a < gdvPreguntas.HeaderRow.Cells.Count; a++)
                {
                    gdvPreguntas.HeaderRow.Cells[a].Style.Add("background-color", "#507CD1");
                }
                int j = 1;
                foreach (GridViewRow gvrow in gdvPreguntas.Rows)
                {
                    gvrow.BackColor = Color.White;
                    if (j <= gdvPreguntas.Rows.Count)
                    {
                        if (j % 2 != 0)
                        {
                            for (int k = 0; k < gvrow.Cells.Count; k++)
                            {
                                gvrow.Cells[k].Style.Add("background-color", "#EFF3FB");
                            }
                        }
                    }
                    j++;
                }

                page.Controls.Add(form);
                form.Controls.Add(gdvPreguntas);

                page.RenderControl(htw);
                Response.Charset = "UTF-8";
                Response.ContentEncoding = Encoding.Default;
                Response.Write(sb.ToString());
                Response.End();
            }
            catch (Exception)
            {
                
            }
        }
    }
}