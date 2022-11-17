namespace Movie_tickets.Models
{
    public class Actor_movie
    {
        public int MovieId { get; set; }
        //multiple relationship
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        //multiple relationship
        public Actor Actor { get; set; }
    }
}
