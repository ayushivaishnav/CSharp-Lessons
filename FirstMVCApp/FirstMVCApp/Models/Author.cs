using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace FirstMVCApp.Models
{
    public class Author
    //Create Author Model - Author ID,  Author Name, Author Date of Birth, No of Books Published,Royalty company.

    // Create Author Controller - CreateAuthor, ListAuthors, ModifyAuthor,FindAuthor,DeleteAuthor

    // Create Views w.r.t to the controller
    {
        [Key]//validation / analaterators(field of class are decerated)

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorID { set; get; }
        [StringLength(25, ErrorMessage = "Name must not have more than 25 chars")]
        [MinLength(3, ErrorMessage = "name must have at least 3 chars")]
        [Required(ErrorMessage = "Title is Required")]
        public string AuthorName { set; get; }
        public int NoOfBookPublished { set; get; }
        [StringLength(25, ErrorMessage = "royalty must not have more than 25 chars")]
        [MinLength(3, ErrorMessage = "royalty must have at least 3 chars")]
        [Required(ErrorMessage = "Title is Required")]
        public string Royalty { set; get; }
        public DateTime DOB { set; get; }
    }



}