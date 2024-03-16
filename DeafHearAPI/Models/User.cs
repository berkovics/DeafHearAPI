using System.ComponentModel.DataAnnotations;

namespace DeafHearAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Tajszam { get; set; }
        public string Lakcim { get; set; }
        public string Email { get; set; }
    }
}
