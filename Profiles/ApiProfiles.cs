using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MyAPI.Models;
using MyAPI.Requests;
using MyAPI.Responses;

namespace MyAPI.Profiles
{
    public class ApiProfiles : Profile
    {
        public ApiProfiles(){
            CreateMap<AddInstructor, Instructor>().ReverseMap();

             CreateMap<MessageSucces, Instructor>().ReverseMap();
        }
        
    }
}