using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class Entities
    {
        [Key]
        [Required]
        public int Id { set; get; }

        [Required]
        [StringLength(30)]
        [MinLength(1, ErrorMessage = "Name must be between 3 to 30 characters")]
        public string Title { set; get; }

        [Required]
        [StringLength(30)]
        public string Language { set; get; } 

        [Required]
        [StringLength(30)]
        public string Hero { set; get; }

        [Required]
        [StringLength(30)]
        public string Director { set; get; }

        [Required]
        [StringLength(30)]
        public string MusicDirector { set; get; }

        public DateTime ReleaseDate { set; get; }

        [Required]
        public int Cost { set; get; }

        [Required]
        public int Collection {  set; get; }

        [Required]
        [StringLength(50)]
        public string Review { set; get; }
    }
}
