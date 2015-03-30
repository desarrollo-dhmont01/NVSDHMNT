using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace NotifyPresentation.EntityLayer.Resultado
{
    public class BeanResultado
    {

        public struct ResultadoSelect
       {
           public DataTable dtResultado;
           public bool blnExiste;
           public string strMensaje;
       }
       public struct ResultadoTransaccion
       {
           public bool blnResultado;
           public string strMensaje;
           public Int16 ParametroOutPut;
           public String ParametroOutPut2;
           public Decimal ParametroOutPut3;
           public Int32 ParametroOutPut4;
           public DataTable dtResultado;
       }

       public struct ResultadoLista
       {
           public IList listResultado;
           public bool blnExiste;
           public string strMensaje;
       }

       public struct ResultadoArrayList
       {
           public ArrayList listResultado;
           public bool blnExiste;
           public string strMensaje;
       }

       public struct ResultadoDataSet
       {
           public DataSet dsResultado;
           public bool blnExiste;
           public string strMensaje;
       }


    }
}
