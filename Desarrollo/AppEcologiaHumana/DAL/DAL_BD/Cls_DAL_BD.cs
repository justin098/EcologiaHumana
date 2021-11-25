﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_BD
{
    public class Cls_DAL_BD
    {
        #region VariablesPrivadas
        private SqlConnection _sql_CNX;
        private SqlDataAdapter _sql_DA;
        private SqlCommand _sql_Cmd;
        private DataSet _DS;
        private string _sCadena, _sSentencia, _sNombreTabla, _sMsgError;
        private int _iValorScalar;
        private DataTable _dtParametros = new DataTable("Parametros");

        public SqlConnection sql_CNX
        {
            get
            {
                return _sql_CNX;
            }

            set
            {
                _sql_CNX = value;
            }
        }

        public SqlDataAdapter sql_DA
        {
            get
            {
                return _sql_DA;
            }

            set
            {
                _sql_DA = value;
            }
        }

        public SqlCommand sql_Cmd
        {
            get
            {
                return _sql_Cmd;
            }

            set
            {
                _sql_Cmd = value;
            }
        }

        public DataSet DS
        {
            get
            {
                return _DS;
            }

            set
            {
                _DS = value;
            }
        }

        public string sCadena
        {
            get
            {
                return _sCadena;
            }

            set
            {
                _sCadena = value;
            }
        }

        public string sSentencia
        {
            get
            {
                return _sSentencia;
            }

            set
            {
                _sSentencia = value;
            }
        }

        public string sNombreTabla
        {
            get
            {
                return _sNombreTabla;
            }

            set
            {
                _sNombreTabla = value;
            }
        }

        public string sMsgError
        {
            get
            {
                return _sMsgError;
            }

            set
            {
                _sMsgError = value;
            }
        }

        public int iValorScalar
        {
            get
            {
                return _iValorScalar;
            }

            set
            {
                _iValorScalar = value;
            }
        }

        public DataTable dtParametros
        {
            get
            {
                return _dtParametros;
            }

            set
            {
                _dtParametros = value;
            }
        }
        #endregion

    }
}
