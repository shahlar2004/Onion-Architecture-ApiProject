using ApiProject.Application.Features.Auth.Command.Register;
using ApiProject.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application.AutoMapper
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<User,RegisterCommandRequest> ().ReverseMap();
        }
    }
}
