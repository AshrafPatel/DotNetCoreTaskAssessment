using AutoMapper;
using HMCTS.TaskTracker.Data;
using HMCTS.TaskTracker.Data.Models;
using HMCTS.TaskTracker.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMCTS.TaskTracker.Services.Profiles
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<TaskEntity, TaskDto>().ReverseMap();
        }
    }
}
