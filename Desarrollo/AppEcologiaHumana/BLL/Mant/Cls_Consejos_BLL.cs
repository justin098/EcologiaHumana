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
    }
}
