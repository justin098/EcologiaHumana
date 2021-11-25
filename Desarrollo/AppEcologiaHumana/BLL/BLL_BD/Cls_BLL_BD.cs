using DAL.DAL_BD;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL_BD
{
    public class Cls_BLL_BD
    {
        public void CrearDTParametros(ref Cls_DAL_BD Obj_DAL_BD)
        {

            DataColumn dcNombre = new DataColumn(@"Nombre", typeof(string));
            DataColumn dcTipo = new DataColumn(@"Tip_Dato", typeof(string));
            DataColumn dcValor = new DataColumn(@"Valor", typeof(string));

            Obj_DAL_BD.dtParametros.Columns.Add(dcNombre);
            Obj_DAL_BD.dtParametros.Columns.Add(dcTipo);
            Obj_DAL_BD.dtParametros.Columns.Add(dcValor);
        }

        public void TraerConexion(ref Cls_DAL_BD Obj_BD_DAL)
        {
            try
            {
                Cls_BLL_DesCNX ObjBllDescriptar = new Cls_BLL_DesCNX();
                Obj_BD_DAL.sCadena = ConfigurationManager.ConnectionStrings["CNX_SQL"].ToString();
                Obj_BD_DAL.sCadena = ObjBllDescriptar.DesencriptCadena(Obj_BD_DAL.sCadena);
                Obj_BD_DAL.sql_CNX = new SqlConnection(Obj_BD_DAL.sCadena);
            }
            catch (Exception e)
            {
                Obj_BD_DAL.sMsgError = e.Message;
                Obj_BD_DAL.sCadena = string.Empty;
                Obj_BD_DAL.sql_CNX = null;
            }
        }

        public void Ejec_DataAdap(ref Cls_DAL_BD Obj_DAL_BD)
        {
            try
            {
                TraerConexion(ref Obj_DAL_BD);
                if (Obj_DAL_BD.sql_CNX != null)
                {
                    if (Obj_DAL_BD.sql_CNX.State == ConnectionState.Closed)
                    {
                        Obj_DAL_BD.sql_CNX.Open();
                        Obj_DAL_BD.sql_DA = new SqlDataAdapter(Obj_DAL_BD.sSentencia, Obj_DAL_BD.sql_CNX);
                        Obj_DAL_BD.sql_DA.SelectCommand.CommandType = CommandType.StoredProcedure;

                        if (Obj_DAL_BD.dtParametros != null)
                        {
                            SqlDbType SqlDataType = SqlDbType.VarChar;

                            foreach (DataRow dr in Obj_DAL_BD.dtParametros.Rows)
                            {
                                switch (dr[@"Tip_Dato"].ToString())
                                {
                                    case "1":
                                        SqlDataType = SqlDbType.VarChar;
                                        break;
                                    case "2":
                                        SqlDataType = SqlDbType.Char;
                                        break;
                                    case "3":
                                        SqlDataType = SqlDbType.Int;
                                        break;
                                    case "4":
                                        SqlDataType = SqlDbType.Date;
                                        break;
                                    case "5":
                                        SqlDataType = SqlDbType.Decimal;
                                        break;
                                    case "6":
                                        SqlDataType = SqlDbType.Bit;
                                        break;
                                    case "7":
                                        SqlDataType = SqlDbType.Text;
                                        break;
                                    case "8":
                                        SqlDataType = SqlDbType.DateTime;
                                        break;
                                    default:
                                        break;
                                }
                                Obj_DAL_BD.sql_DA.SelectCommand.Parameters.Add(dr[@"Nombre"].ToString(),
                                                                             SqlDataType).Value = dr[@"Valor"].ToString();
                            }
                        }
                        Obj_DAL_BD.DS = new DataSet();
                        Obj_DAL_BD.sql_DA.Fill(Obj_DAL_BD.DS, Obj_DAL_BD.sNombreTabla);
                        Obj_DAL_BD.sMsgError = string.Empty;
                    }
                }
            }
            catch (SqlException e)
            {
                Obj_DAL_BD.sMsgError = e.Message;
            }
            finally
            {
                if (Obj_DAL_BD.sql_CNX != null)
                {
                    if (Obj_DAL_BD.sql_CNX.State == ConnectionState.Open)
                    {
                        Obj_DAL_BD.sql_CNX.Close();
                        Obj_DAL_BD.sql_CNX.Dispose();
                    }
                }
            }
        }

        public void Ejec_NonQuery(ref Cls_DAL_BD Obj_DAL_BD)
        {
            try
            {
                TraerConexion(ref Obj_DAL_BD);
                if (Obj_DAL_BD.sql_CNX != null)
                {
                    if (Obj_DAL_BD.sql_CNX.State == ConnectionState.Closed)
                    {
                        Obj_DAL_BD.sql_CNX.Open();
                        Obj_DAL_BD.sql_Cmd = new SqlCommand(Obj_DAL_BD.sSentencia, Obj_DAL_BD.sql_CNX);
                        Obj_DAL_BD.sql_Cmd.CommandType = CommandType.StoredProcedure;

                        if (Obj_DAL_BD.dtParametros != null)
                        {
                            SqlDbType SqlDataType = SqlDbType.VarChar;

                            foreach (DataRow dr in Obj_DAL_BD.dtParametros.Rows)
                            {
                                switch (dr[@"Tip_Dato"].ToString())
                                {
                                    case "1":
                                        SqlDataType = SqlDbType.VarChar;
                                        break;
                                    case "2":
                                        SqlDataType = SqlDbType.Char;
                                        break;
                                    case "3":
                                        SqlDataType = SqlDbType.Int;
                                        break;
                                    case "4":
                                        SqlDataType = SqlDbType.DateTime;
                                        break;
                                    case "5":
                                        SqlDataType = SqlDbType.Decimal;
                                        break;
                                    case "6":
                                        SqlDataType = SqlDbType.Bit;
                                        break;
                                    case "7":
                                        SqlDataType = SqlDbType.Text;
                                        break;
                                    case "8":
                                        SqlDataType = SqlDbType.DateTime;
                                        break;
                                    default:
                                        break;
                                }
                                Obj_DAL_BD.sql_Cmd.Parameters.Add(dr[@"Nombre"].ToString(),
                                                                             SqlDataType).Value = dr[@"Valor"].ToString();
                            }
                        }
                        Obj_DAL_BD.sql_Cmd.ExecuteNonQuery();
                        Obj_DAL_BD.sMsgError = string.Empty;
                    }
                }

            }
            catch (SqlException e)
            {
                Obj_DAL_BD.sMsgError = e.Message;
            }
            finally
            {
                if (Obj_DAL_BD.sql_CNX != null)
                {
                    if (Obj_DAL_BD.sql_CNX.State == ConnectionState.Open)
                    {
                        Obj_DAL_BD.sql_CNX.Close();
                    }
                    Obj_DAL_BD.sql_CNX.Dispose();
                }
            }
        }

        public void Ejec_Scalar(ref Cls_DAL_BD Obj_DAL_BD)
        {
            try
            {
                TraerConexion(ref Obj_DAL_BD);
                if (Obj_DAL_BD.sql_CNX != null)
                {
                    if (Obj_DAL_BD.sql_CNX.State == ConnectionState.Closed)
                    {
                        Obj_DAL_BD.sql_CNX.Open();
                        Obj_DAL_BD.sql_Cmd = new SqlCommand(Obj_DAL_BD.sSentencia, Obj_DAL_BD.sql_CNX);
                        Obj_DAL_BD.sql_Cmd.CommandType = CommandType.StoredProcedure;

                        if (Obj_DAL_BD.dtParametros != null)
                        {
                            SqlDbType SqlDataType = SqlDbType.VarChar;

                            foreach (DataRow dr in Obj_DAL_BD.dtParametros.Rows)
                            {
                                switch (dr[@"Tip_Dato"].ToString())
                                {
                                    case "1":
                                        SqlDataType = SqlDbType.VarChar;
                                        break;
                                    case "2":
                                        SqlDataType = SqlDbType.Char;
                                        break;
                                    case "3":
                                        SqlDataType = SqlDbType.Int;
                                        break;
                                    case "4":
                                        SqlDataType = SqlDbType.DateTime;
                                        break;
                                    case "5":
                                        SqlDataType = SqlDbType.Decimal;
                                        break;
                                    case "6":
                                        SqlDataType = SqlDbType.Bit;
                                        break;
                                    case "7":
                                        SqlDataType = SqlDbType.Text;
                                        break;
                                    case "8":
                                        SqlDataType = SqlDbType.DateTime;
                                        break;
                                    default:
                                        break;
                                }
                                Obj_DAL_BD.sql_Cmd.Parameters.Add(dr[@"Nombre"].ToString(),
                                                                             SqlDataType).Value = dr[@"Valor"].ToString();
                            }
                        }
                        Obj_DAL_BD.iValorScalar = Convert.ToInt32(Obj_DAL_BD.sql_Cmd.ExecuteScalar());
                        Obj_DAL_BD.sMsgError = string.Empty;
                    }
                }

            }
            catch (SqlException e)
            {
                Obj_DAL_BD.sMsgError = e.Message;
            }
            finally
            {
                if (Obj_DAL_BD.sql_CNX != null)
                {
                    if (Obj_DAL_BD.sql_CNX.State == ConnectionState.Open)
                    {
                        Obj_DAL_BD.sql_CNX.Close();
                    }
                    Obj_DAL_BD.sql_CNX.Dispose();
                }
            }
        }
    }
}
