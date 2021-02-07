using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Simulations_Project_PRG252
{
    class CustExeception:Exception
    {
        public CustExeception()
        {

        }
        public CustExeception(string message):base(message)
        {

        }
        public CustExeception(string message, Exception InnerException):base(message,InnerException)
        {

        }
    }
}
