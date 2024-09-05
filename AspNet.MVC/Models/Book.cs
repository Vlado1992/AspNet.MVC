using System.ComponentModel;

namespace AspNet.MVC.Models
{
    public class Book
    {
        [DisplayName("ID knjige")]
        public int Id { get; set; }
        [DisplayName("Naziv knjige")]
        public string Title { get; set; }
        [DisplayName("Žanr knjige")]
        public string Genre { get; set; }
        [DisplayName("Godina izdavanja knjige")]
        public string ReleaseDate { get; set; }
        [DisplayName("Autor knjige")]
        public Author Author { get; set; }
    }
}
