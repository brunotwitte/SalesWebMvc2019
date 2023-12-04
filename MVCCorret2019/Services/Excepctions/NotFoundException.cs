using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCorret2019.Services.Excepctions
{
    public class NotFoundException : ApplicationException
    {
        public  NotFoundException(string message):base(message)
        {
 
        }
    }
}
