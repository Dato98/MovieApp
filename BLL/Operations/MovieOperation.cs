using AutoMapper;
using BLL.DTOs.Movie;
using BLL.Interfaces;
using DAL.Entities;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Operations
{
    public class MovieOperation : IMovieOperation
    {
        private readonly IUOW service;
        private readonly IMapper mapper;

        public MovieOperation(IUOW uOW, IMapper mapper)
        {
            service = uOW;
            this.mapper = mapper;
        }

        public IEnumerable<MovieDTO> GetAll()
        {
            var movies = service.Movie.GetAllMovieWithDirector();
            return mapper.Map<IEnumerable<MovieDTO>>(movies);
        }

        public CreateMovieComponents GetCreateMovieComponents()
        {
            CreateMovieComponents model = new CreateMovieComponents();
            var directors = service.Person.GetDirectors();

            model.DirectorList = directors.Select(x =>
            new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem() 
            { Text = $"{x.Firstname} {x.Lastname}", Value = x.Id.ToString() }).ToList();

            return model;            
        }

        public void Create(CreateMovieDTO model)
        {
            var dbModel = mapper.Map<Movie>(model);
            service.Movie.Create(dbModel);
            service.Commit();
        }

        public EditMovieDTO GetEditMovieData(int id)
        {
            var model = service.Movie.Get(id);
            return mapper.Map<EditMovieDTO>(model);
        }

        public void Edit(EditMovieDTO model)
        {
            var dbModel = mapper.Map<Movie>(model);
            service.Movie.Update(dbModel);
            service.Commit();
        }
    }
}
