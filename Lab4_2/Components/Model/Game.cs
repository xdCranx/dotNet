using System.ComponentModel.DataAnnotations;

namespace Lab4_2.Components.Model
{
    public class Game
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public string? Platform { get; set; }
        public float? Price { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        public int NumOfReviews { get; set; }
        public float? AvgRating { get; set; }

        public string? ImgUrl { get; set; }
    }
}
