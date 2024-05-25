using ApiProject.Application.Bases;

namespace ApiProject.Application.Features.Auth.Exception
{
    public class RefreshTokenShouldNotBeExpiredException : BaseExceptions
    {
        public RefreshTokenShouldNotBeExpiredException() : base("Icazə vaxtı sona çatdı. Yenidən giriş edin!") { }

    }
}
