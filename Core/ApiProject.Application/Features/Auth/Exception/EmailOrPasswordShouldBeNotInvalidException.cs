using ApiProject.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application.Features.Auth.Exception
{
    public class EmailOrPasswordShouldBeNotInvalidException:BaseExceptions
    {
        public EmailOrPasswordShouldBeNotInvalidException():base("İstifadəçi adı və ya şifrəsi yalnış olmamalıdır") { }
      
    }
}
