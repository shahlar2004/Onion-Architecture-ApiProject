using ApiProject.Application.Bases;

namespace ApiProject.Application.Features.Auth.Exception
{
    public class EmailAddressShouldBeValidException : BaseExceptions
    {
        public EmailAddressShouldBeValidException() : base("Email adderssi tapilmadi!") { }

    }
}
