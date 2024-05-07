using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application.Interfaces.Tokens
{
    public interface ITokenService
    {
        Task<JwtSecurityToken> CreateToken(User);
    }
}
