using DrPolina.Domain.Dto;
using DrPolina.Domain.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrPolina.Domain.Converters
{
    public static class GenreConverter
    {
        public static Genre Convert(GenreDto genre)
        {
            return new Genre
            {
                Id = genre.Id,
                Title = genre.Title,
                
            };
        }

        public static GenreDto Convert(Genre genre)
        {
            return new GenreDto
            {
                Id = genre.Id,
                Title = genre.Title
            };
        }

        public static List<Genre> Convert (List<GenreDto> genres)
        {
            return genres.Select(a => Convert(a)).ToList();
        }
        public static List<GenreDto> Convert(List<Genre> genres)
        {
            return genres.Select(a => Convert(a)).ToList();
        }


    }
}
