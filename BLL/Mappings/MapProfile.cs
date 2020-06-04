using AutoMapper;
using BLL.DTOs.Movie;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Movie, MovieDTO>()
                .ForMember(dest =>
                    dest.Director,
                    opt => opt.MapFrom(src => $"{src.Director.Firstname} {src.Director.Lastname}"));

            CreateMap<CreateMovieDTO, Movie>();

            CreateMap<Movie, EditMovieDTO>();

            CreateMap<EditMovieDTO, Movie>();
        }
    }
}
