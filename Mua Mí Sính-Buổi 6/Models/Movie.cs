using System.ComponentModel.DataAnnotations;

namespace Mua_Mí_Sính_Buổi_6.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2, ErrorMessage ="tile must me")]
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public string? RealeaseDate { get; set; }
        public string? Price { get; set; }
        public int GenreID { get; set; }
        [Display(Name = "Genre Name")]
        public Genre? Genre { get; set; }
    }
}
