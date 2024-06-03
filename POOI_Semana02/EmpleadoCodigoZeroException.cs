using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Semana02
{
    public class EmpleadoCodigoZeroException : Exception
    {


        public EmpleadoCodigoZeroException()
        {
        }

        public EmpleadoCodigoZeroException(string message) : base(message)
        {
        }

        public EmpleadoCodigoZeroException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
