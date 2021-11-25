using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using BLL.BLL_BD;
using DAL.DAL_BD;
using DAL.Mant;

namespace BLL.Mant
{
    public class Cls_Dimension_BLL
    {
        public DataTable ListarPreguntasDimension(ref string sMsjError, int dimension)
        {

            try
            {
                Cls_BLL_BD ObjBllCNX = new Cls_BLL_BD();
                Cls_DAL_BD ObjDalBD = new Cls_DAL_BD();
                ObjDalBD.sNombreTabla = "Dimensiones";
                ObjBllCNX.CrearDTParametros(ref ObjDalBD);
                ObjDalBD.dtParametros.Rows.Add("@Dimension", 1, dimension);
                ObjDalBD.sSentencia = ConfigurationManager.AppSettings["SelectPreguntasDimension"];
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

        public DataTable ListarPreguntasDimensionTipo(ref string sMsjError, int dimension, int tipo)
        {

            try
            {
                Cls_BLL_BD ObjBllCNX = new Cls_BLL_BD();
                Cls_DAL_BD ObjDalBD = new Cls_DAL_BD();
                ObjDalBD.sNombreTabla = "Dimensiones";
                ObjBllCNX.CrearDTParametros(ref ObjDalBD);
                ObjDalBD.dtParametros.Rows.Add("@Dimension", 1, dimension);
                ObjDalBD.dtParametros.Rows.Add("@Estilo", 1, tipo);
                ObjDalBD.sSentencia = ConfigurationManager.AppSettings["SelectPreguntasDimensionEstilo"];
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

        public DataTable ListarPreguntas(ref string sMsjError, int IdPregunta)
        {

            try
            {
                Cls_BLL_BD ObjBllCNX = new Cls_BLL_BD();
                Cls_DAL_BD ObjDalBD = new Cls_DAL_BD();
                ObjDalBD.sNombreTabla = "Dimensiones";
                ObjBllCNX.CrearDTParametros(ref ObjDalBD);
                ObjDalBD.dtParametros.Rows.Add("@IdPregunta", 1, IdPregunta);
                ObjDalBD.sSentencia = ConfigurationManager.AppSettings["SelectPregunta"];
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


        public bool InsertarPregunta(ref string sMsjError, ref Cls_Dimension_DAL objDimension)
        {
            bool resultado = false;

            try
            {
                Cls_BLL_DesCNX objDes = new Cls_BLL_DesCNX();

                Cls_BLL_BD ObjBllCNX = new Cls_BLL_BD();
                Cls_DAL_BD ObjDalBD = new Cls_DAL_BD();

                ObjBllCNX.CrearDTParametros(ref ObjDalBD);

                ObjDalBD.dtParametros.Rows.Add("@Pregunta", 1, objDimension.Pregunta);
                ObjDalBD.dtParametros.Rows.Add("@Tipo", 3, objDimension.Tipo);
                ObjDalBD.dtParametros.Rows.Add("@Estilo", 3, objDimension.Estilo);
                ObjDalBD.dtParametros.Rows.Add("@IdUsuario", 3, objDimension.IdUsuario);
                ObjDalBD.dtParametros.Rows.Add("@Dimension", 3, objDimension.Dimension);



                ObjDalBD.sSentencia = ConfigurationManager.AppSettings["InsertarPregunta"];

                ObjBllCNX.Ejec_Scalar(ref ObjDalBD);

                if (ObjDalBD.sMsgError != string.Empty)
                {
                    sMsjError = ObjDalBD.sMsgError;
                    resultado = false;
                }
                else
                {
                    sMsjError = string.Empty;
                    objDimension.IdPregunta = ObjDalBD.iValorScalar;
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

        public bool ActualizarPregunta(ref string sMsjError, ref Cls_Dimension_DAL objDimension)
        {
            bool resultado = false;

            try
            {
                Cls_BLL_DesCNX objDes = new Cls_BLL_DesCNX();

                Cls_BLL_BD ObjBllCNX = new Cls_BLL_BD();
                Cls_DAL_BD ObjDalBD = new Cls_DAL_BD();

                ObjBllCNX.CrearDTParametros(ref ObjDalBD);

                ObjDalBD.dtParametros.Rows.Add("@Pregunta", 1, objDimension.Pregunta);
                ObjDalBD.dtParametros.Rows.Add("@Tipo", 3, objDimension.Tipo);
                ObjDalBD.dtParametros.Rows.Add("@Estilo", 3, objDimension.Estilo);
                ObjDalBD.dtParametros.Rows.Add("@IdUsuario", 3, objDimension.IdUsuario);
                ObjDalBD.dtParametros.Rows.Add("@Dimension", 3, objDimension.Dimension);
                ObjDalBD.dtParametros.Rows.Add("@IdPregunta", 3, objDimension.IdPregunta);



                ObjDalBD.sSentencia = ConfigurationManager.AppSettings["ActualizarPregunta"];

                ObjBllCNX.Ejec_Scalar(ref ObjDalBD);

                if (ObjDalBD.sMsgError != string.Empty)
                {
                    sMsjError = ObjDalBD.sMsgError;
                    resultado = false;
                }
                else
                {
                    sMsjError = string.Empty;
                    objDimension.IdPregunta = ObjDalBD.iValorScalar;
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

        public bool EliminarPregunta(ref string sMsjError, ref Cls_Dimension_DAL objDimension)
        {
            bool resultado = false;

            try
            {
                Cls_BLL_DesCNX objDes = new Cls_BLL_DesCNX();

                Cls_BLL_BD ObjBllCNX = new Cls_BLL_BD();
                Cls_DAL_BD ObjDalBD = new Cls_DAL_BD();

                ObjBllCNX.CrearDTParametros(ref ObjDalBD);

                ObjDalBD.dtParametros.Rows.Add("@IdPregunta", 1, objDimension.IdPregunta);
                ObjDalBD.sSentencia = ConfigurationManager.AppSettings["DeletePregunta"];

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
