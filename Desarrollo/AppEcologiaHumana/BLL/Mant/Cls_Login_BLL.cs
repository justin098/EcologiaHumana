﻿using BLL.BLL_BD;
using DAL.DAL_BD;
using DAL.Mant;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mant
{
    public class Cls_Login_BLL
    {
        public DataTable LoginUsuario(ref string sMsjError, Cls_Login_DAL objLogin)
        {

            try
            {
                Cls_BLL_DesCNX objDes = new Cls_BLL_DesCNX();

                Cls_BLL_BD ObjBllCNX = new Cls_BLL_BD();
                Cls_DAL_BD ObjDalBD = new Cls_DAL_BD();
                ObjDalBD.sNombreTabla = "Usuario";
                ObjBllCNX.CrearDTParametros(ref ObjDalBD);
                ObjDalBD.sSentencia = ConfigurationManager.AppSettings["LoginUsuario"];
                ObjDalBD.dtParametros.Rows.Add("@Usuario", 1, objLogin.Usuario);
                ObjDalBD.dtParametros.Rows.Add("@Contrasena", 1, objDes.EncriptCadena(objLogin.Contrasena));
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
        public DataTable ListarSedes(ref string sMsjError)
        {

            try
            {
                Cls_BLL_BD ObjBllCNX = new Cls_BLL_BD();
                Cls_DAL_BD ObjDalBD = new Cls_DAL_BD();
                ObjDalBD.sNombreTabla = "Sedes";
                ObjBllCNX.CrearDTParametros(ref ObjDalBD);
                ObjDalBD.sSentencia = ConfigurationManager.AppSettings["SelectSedes"];
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

        public DataTable ListarProfesiones(ref string sMsjError)
        {

            try
            {
                Cls_BLL_BD ObjBllCNX = new Cls_BLL_BD();
                Cls_DAL_BD ObjDalBD = new Cls_DAL_BD();
                ObjDalBD.sNombreTabla = "Profesiones";
                ObjBllCNX.CrearDTParametros(ref ObjDalBD);
                ObjDalBD.sSentencia = ConfigurationManager.AppSettings["SelectProfesiones"];
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

        public bool InsertarUsuario(ref string sMsjError, ref Cls_Login_DAL objLogin)
        {
            bool resultado = false;

            try
            {
                Cls_BLL_DesCNX objDes = new Cls_BLL_DesCNX();

                Cls_BLL_BD ObjBllCNX = new Cls_BLL_BD();
                Cls_DAL_BD ObjDalBD = new Cls_DAL_BD();

                ObjBllCNX.CrearDTParametros(ref ObjDalBD);

                ObjDalBD.dtParametros.Rows.Add("@Usuario", 1, objLogin.Usuario);
                ObjDalBD.dtParametros.Rows.Add("@Contrasena", 1, objDes.EncriptCadena(objLogin.Contrasena));
                ObjDalBD.dtParametros.Rows.Add("@Estado", 6, true);



                ObjDalBD.sSentencia = ConfigurationManager.AppSettings["InsertarUsuario"];

                ObjBllCNX.Ejec_Scalar(ref ObjDalBD);

                if (ObjDalBD.sMsgError != string.Empty)
                {
                    sMsjError = ObjDalBD.sMsgError;
                    resultado = false;
                }
                else
                {
                    sMsjError = string.Empty;
                    objLogin.IdUsuario = ObjDalBD.iValorScalar;
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

        public bool InsertarPerfil(ref string sMsjError, ref Cls_Login_DAL objLogin)
        {
            bool resultado = false;

            try
            {
                Cls_BLL_DesCNX objDes = new Cls_BLL_DesCNX();

                Cls_BLL_BD ObjBllCNX = new Cls_BLL_BD();
                Cls_DAL_BD ObjDalBD = new Cls_DAL_BD();

                ObjBllCNX.CrearDTParametros(ref ObjDalBD);

                ObjDalBD.dtParametros.Rows.Add("@NombreUsuario", 1, objLogin.NombreUsuario);
                ObjDalBD.dtParametros.Rows.Add("@FechaNacimiento", 8, objLogin.FechaNacimiento);
                ObjDalBD.dtParametros.Rows.Add("@Sexo", 2, objLogin.Sexo);
                ObjDalBD.dtParametros.Rows.Add("@IdUsuario", 3, objLogin.IdUsuario);
                ObjDalBD.dtParametros.Rows.Add("@IdSede", 3, objLogin.IdSede);
                ObjDalBD.dtParametros.Rows.Add("@IdProfesion", 3, objLogin.IdProfesion);



                ObjDalBD.sSentencia = ConfigurationManager.AppSettings["InsertarPerfil"];

                ObjBllCNX.Ejec_Scalar(ref ObjDalBD);

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
