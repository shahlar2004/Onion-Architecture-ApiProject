using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application.Features.Auth.Command.Login
{
    public class LoginCommandRequest:IRequest<LoginCommandResponse>
    {
        [DefaultValue("emai")]
        public string Email { get; set; }

        [DefaultValue("password")]
        public string Password { get; set; }    

    }
}
