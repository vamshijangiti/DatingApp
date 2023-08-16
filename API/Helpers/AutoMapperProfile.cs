﻿using AutoMapper;

namespace API;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<AppUser, MemberDto>()
            .ForMember(dest=> dest.PhotoUrl, 
                        opt=>opt.MapFrom(src => src.Photos.FirstOrDefault(x=>x.IsMain).Url));
        CreateMap<Photo, PhotoDto>();
    }
}
