using System.ComponentModel.DataAnnotations;

namespace Movie_tickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "Full Name")]

        public string FullName { get; set; }
       
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //relationship
        public List<Actor_movie> Actors_movies { get; set; }
    }
}
