using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyPresentation.BusinessLogicLayer.Global
{
    public class SrvGlobal
    {

        DataAccessLayer.Global.DAOGlobal VL_DAOGlobal = new DataAccessLayer.Global.DAOGlobal();
        public EntityLayer.Resultado.BeanResultado.ResultadoSelect FNC_LOGIN_LOGUEO(String VL_USUARIO, String VL_PASSWORD)
        {
            return VL_DAOGlobal.FNC_LOGIN_LOGUEO(VL_USUARIO, VL_PASSWORD);
        }

    }
}
