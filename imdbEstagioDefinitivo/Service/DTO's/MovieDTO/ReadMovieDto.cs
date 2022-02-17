﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO_s.MovieDTO
{ 
    public class ReadMovieDto
    {
        public int Id { get; set; } 
        public string Title { get; set; }  
        public string Description { get; set; }
        public int Duration { get; set; }
        public string Director { get; set; }
        public int Rating { get; set; }
        public int VoteCounter { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual List<Actor> Actors { get; set; } 
        public virtual List<Genre> Genres{ get; set; }
    }
}
