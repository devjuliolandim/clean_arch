using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.UseCases.CreateUser;
using CleanArchitecture.Domain.Entities;
using AutoMapper;

namespace CleanArchitecture.Application.UseCases.GetAllUser
{
    public sealed class GetAllUserMapper: Profile
    {
        public GetAllUserMapper() {
            CreateMap<User, GetAllUserResponse>();
        }
    }
}
