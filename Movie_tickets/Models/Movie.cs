using Movie_tickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Data.SqlClient;

namespace Movie_tickets.Models
{
    public class Movie
    {    
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nmae")]
        public string Nmae { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        public double Price { get; set; }
        [Display(Name = "ImageURL")]
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory  { get; set; }

        //relationship
        public List<Actor_movie> Actors_movies { get; set; }

         //cinemas multiple relationships
         public int CinemaId { get; set; }
         [ForeignKey("CinemaId")]
         public Cinema Cinema { get; set; }

        //producer multiple relationships
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

    }
}
