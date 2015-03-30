using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Practices.EnterpriseLibrary.Common;
using System.Data;
using System.Data.Common;

namespace NotifyPresentation.DataAccessLayer.Global
{
    public class DAOGlobal
    {

        public static String VG_CONECTION_STRING = "Data Source=192.168.1.200;Initial Catalog=ERPDHMONT;User ID=sa;Password=!gestionerp2013";

        //public CapaEntidad.BeanResultado.ResultadoSeleccion Bdinicializar(String VL_USUARIO, String VL_PASSWORD)
        //{
        //    StringBuilder conn = new StringBuilder();
        //    conn.Append("Data Source=192.168.1.200;Initial Catalog=ERPDHMONT;Persist Security Info=True;User ID=sa;Password=!gestionerp2013");

        //    SqlDatabase VL_Database = new SqlDatabase(conn.ToString());
        //    BeanResultado.ResultadoSeleccion VL_BeanResultado = new CapaEntidad.BeanResultado.ResultadoSeleccion();
        //    DbCommand VL_Command;

        //    try
        //    {

        //        VL_Command = VL_Database.GetStoredProcCommand("COMUN.USP_USUARIO_LOGUEO_CONFIRMAR");

        //        VL_Database.AddInParameter(VL_Command, "@USUARIO", DbType.String, VL_USUA_CODIGO);
        //        VL_Database.AddInParameter(VL_Command, "@PASSWORD", DbType.String, VL_SIST_CODIGO);

        //        VL_BeanResultado.dtResultado = VL_Database.ExecuteDataSet(VL_Command).Tables[0];
        //        VL_BeanResultado.blnExiste = true;
        //    }
        //    catch (Exception)
        //    {
        //        VL_BeanResultado.blnExiste = false;
        //        VL_BeanResultado.strMensaje = "EL USUARIO O LA CONTRASEÑA NO COINCIDEN";
        //    }
        //    finally
        //    {
        //        VL_Database = null;
        //        VL_Command = null;
        //    }

        //    VG_CONECTION_STRING = conn.ToString();

        //    return VL_BeanResultado;

        //}

        public string BdConectionString()
        {
            return VG_CONECTION_STRING;
        }

        public EntityLayer.Resultado.BeanResultado.ResultadoSelect FNC_LOGIN_LOGUEO(String VL_USUARIO, String VL_PASSWORD)
        {
            SqlDatabase VL_Database = new SqlDatabase(VG_CONECTION_STRING);
            EntityLayer.Resultado.BeanResultado.ResultadoSelect VL_BeanResultado = new EntityLayer.Resultado.BeanResultado.ResultadoSelect();
            DbCommand VL_Command;

            try
            {
                VL_Command = VL_Database.GetStoredProcCommand("COMUN.USP_USUARIO_LOGUEO_CONFIRMAR");

                VL_Database.AddInParameter(VL_Command, "@USUARIO", DbType.String, VL_USUARIO);
                VL_Database.AddInParameter(VL_Command, "@PASSWORD", DbType.String, VL_PASSWORD);


                VL_BeanResultado.dtResultado = VL_Database.ExecuteDataSet(VL_Command).Tables[0];
                VL_BeanResultado.blnExiste = true;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                VL_BeanResultado.blnExiste = false;
                VL_BeanResultado.strMensaje = ex.Message.ToString();
            }
            finally
            {

                VL_Database = null;
                VL_Command = null;
            }
            return VL_BeanResultado;
        }

    }
}
