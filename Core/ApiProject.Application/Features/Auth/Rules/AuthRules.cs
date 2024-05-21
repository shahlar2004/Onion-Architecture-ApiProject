using ApiProject.Application.Bases;
using ApiProject.Application.Features.Auth.Exception;
using ApiProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application.Features.Auth.Rules
{
    public class AuthRules : BaseRules
    {
        public Task UserShouldNotBeExis(User? user)
        {

            if (user is not null) throw new UserAlreadyExistException();
          
            return Task.CompletedTask;
        }

        public Task EmailOrPasswordShouldNotBeInvalid(User? user, bool checkPassword)
        {
            if(user is null || !checkPassword) throw new EmailOrPasswordShouldBeNotInvalidException();
            return Task.CompletedTask;
        }
    }
}
