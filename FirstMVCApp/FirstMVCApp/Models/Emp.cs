using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class Emp
    {

        [Key]//validation / analaterators(field of class are decerated)
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        [Required]
        [StringLength(20)]
        [MinLength(3,ErrorMessage ="Name must be between 3 to 20 characters")]
        public string Name { set; get; }
        [Required]
        [Range(5000,200000)]
        public decimal Salary { set; get; }
        [Required]
        [StringLength(20)]
        [MinLength(3,ErrorMessage ="City must be Chennai or Bgl")]
        public string City { set; get; }
        
    }
}
