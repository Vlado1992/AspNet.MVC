using System.ComponentModel;

namespace AspNet.MVC.Models
{
    public class Author
    {
        [DisplayName("ID autora")]
        public int Id { get; set; }
        [DisplayName("Ime i prezime autora")]
        public string Name { get; set; }
        [DisplayName("Zemlja porijekla autora")]
        public string CountryOfOrigin { get; set; }
        [DisplayName("E-mail adresa autora")]
        public string DateOfBirth { get; set; }
    }
}
