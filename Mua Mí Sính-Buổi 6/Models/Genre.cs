namespace Mua_Mí_Sính_Buổi_6.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Movie>? Movie { get; set; }
    }
}
