using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBase
{
    public static class RolHelper
    {
        public static string ObtenerNombreRol(int rolCodigo)
        {
            switch (rolCodigo)
            {
                case 1:
                    return "Administrador";
                case 2:
                    return "Operador";
                case 3:
                    return "Auditor";
                default:
                    return "Desconocido";
            }
        }
    }

}
