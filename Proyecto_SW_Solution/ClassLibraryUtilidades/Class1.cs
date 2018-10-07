using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Model.Entity;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Practices.EnterpriseLibrary.Common;
using ClassLibraryUtilidades;
using System.Data.Common;

namespace ClassLibraryUtilidades
{
    public class CadenaConexion
    {
        public string RecuperarCadenaConexion()
        {
            return ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        }
    }
}
