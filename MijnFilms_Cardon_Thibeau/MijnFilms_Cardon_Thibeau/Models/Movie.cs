using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MijnFilms_Cardon_Thibeau.Models
{
    public class Movie
    {
        [Required]
        public int MovieID { get; set; }

        [Required]
        public int Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int GenreID { get; set; }

        [Required]
        public int DirectorID { get; set; }

        [Required]
        public string Stars { get; set; }

        [Required]
        public string Description { get; set; }



    }
}
