using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using BLL.BLL_BD;
using DAL.DAL_BD;
using DAL.Mant;

namespace BLL.Mant
{
    public class Cls_Consejos_BLL
    {
        public DataTable ListarConsejos(ref string sMsjError)
        {

            try
            {
                Cls_BLL_BD ObjBllCNX = new Cls_BLL_BD();
                Cls_DAL_BD ObjDalBD = new Cls_DAL_BD();
                ObjDalBD.sNombreTabla = "Consejos";
                ObjBllCNX.CrearDTParametros(ref ObjDalBD);
                ObjDalBD.sSentencia = ConfigurationManager.AppSettings["SelectConsejos"];
                ObjBllCNX.Ejec_DataAdap(ref ObjDalBD);

                if (ObjDalBD.sMsgError.Trim() != string.Empty)
                {

                    sMsjError = ObjDalBD.sMsgError;

                    return null;
                }
                else
                {

                    sMsjError = string.Empty;
                    return ObjDalBD.DS.Tables[0];
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public DataTable ListarConsejo(ref string sMsjError, int IdConsejo)
        {

            try
            {
                Cls_BLL_BD ObjBllCNX = new Cls_BLL_BD();
                Cls_DAL_BD ObjDalBD = new Cls_DAL_BD();
                ObjDalBD.sNombreTabla = "Consejo";
                ObjBllCNX.CrearDTParametros(ref ObjDalBD);
                ObjDalBD.dtParametros.Rows.Add("@IdConsejo", 1, IdConsejo);
                ObjDalBD.sSentencia = ConfigurationManager.AppSettings["SelectConsejo"];
                ObjBllCNX.Ejec_DataAdap(ref ObjDalBD);

                if (ObjDalBD.sMsgError.Trim() != string.Empty)
                {

                    sMsjError = ObjDalBD.sMsgError;

                    return null;
                }
                else
                {

                    sMsjError = string.Empty;
                    return ObjDalBD.DS.Tables[0];
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }


        public bool InsertarConsejo(ref string sMsjError, ref Cls_Consejos_DAL objConsejos)
        {
            bool resultado = false;

            try
            {
                Cls_BLL_DesCNX objDes = new Cls_BLL_DesCNX();

                Cls_BLL_BD ObjBllCNX = new Cls_BLL_BD();
                Cls_DAL_BD ObjDalBD = new Cls_DAL_BD();

                ObjBllCNX.CrearDTParametros(ref ObjDalBD);

                ObjDalBD.dtParametros.Rows.Add("@Consejo", 1, objConsejos.Consejo);
                ObjDalBD.dtParametros.Rows.Add("@IdUsuario", 3, objConsejos.IdUsuario);
                ObjDalBD.dtParametros.Rows.Add("@Dimension", 3, objConsejos.Dimension);



                ObjDalBD.sSentencia = ConfigurationManager.AppSettings["InsertarConsejo"];

                ObjBllCNX.Ejec_Scalar(ref ObjDalBD);

                if (ObjDalBD.sMsgError != string.Empty)
                {
                    sMsjError = ObjDalBD.sMsgError;
                    resultado = false;
                }
                else
                {
                    sMsjError = string.Empty;
                    objConsejos.IdConsejo = ObjDalBD.iValorScalar;
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                sMsjError = ex.Message.ToString();
                resultado = false;
            }

            return resultado;

        }

        public bool ActualizarConsejo(ref string sMsjError, ref Cls_Consejos_DAL objConsejos)
        {
            bool resultado = false;

            try
            {
                Cls_BLL_DesCNX objDes = new Cls_BLL_DesCNX();

                Cls_BLL_BD ObjBllCNX = new Cls_BLL_BD();
                Cls_DAL_BD ObjDalBD = new Cls_DAL_BD();

                ObjBllCNX.CrearDTParametros(ref ObjDalBD);

                ObjDalBD.dtParametros.Rows.Add("@Consejo", 1, objConsejos.Consejo);
                ObjDalBD.dtParametros.Rows.Add("@IdUsuario", 3, objConsejos.IdUsuario);
                ObjDalBD.dtParametros.Rows.Add("@Dimension", 3, objConsejos.Dimension);
                ObjDalBD.dtParametros.Rows.Add("@IdConsejo", 3, objConsejos.IdConsejo);



                ObjDalBD.sSentencia = ConfigurationManager.AppSettings["ActualizarConsejo"];

                ObjBllCNX.Ejec_Scalar(ref ObjDalBD);

                if (ObjDalBD.sMsgError != string.Empty)
                {
                    sMsjError = ObjDalBD.sMsgError;
                    resultado = false;
                }
                else
                {
                    sMsjError = string.Empty;
                    objConsejos.IdConsejo = ObjDalBD.iValorScalar;
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                sMsjError = ex.Message.ToString();
                resultado = false;
            }

            return resultado;

        }

        public bool EliminarConsejo(ref string sMsjError, ref Cls_Consejos_DAL objConsejos)
        {
            bool resultado = false;

            try
            {
                Cls_BLL_DesCNX objDes = new Cls_BLL_DesCNX();

                Cls_BLL_BD ObjBllCNX = new Cls_BLL_BD();
                Cls_DAL_BD ObjDalBD = new Cls_DAL_BD();

                ObjBllCNX.CrearDTParametros(ref ObjDalBD);

                ObjDalBD.dtParametros.Rows.Add("@IdConsejo", 1, objConsejos.IdConsejo);
                ObjDalBD.sSentencia = ConfigurationManager.AppSettings["DeleteConsejo"];

                ObjBllCNX.Ejec_NonQuery(ref ObjDalBD);

                if (ObjDalBD.sMsgError != string.Empty)
                {
                    sMsjError = ObjDalBD.sMsgError;
                    resultado = false;
                }
                else
                {
                    sMsjError = string.Empty;
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                sMsjError = ex.Message.ToString();
                resultado = false;
            }

            return resultado;

        }
    }
}
