using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Diagnostics;



namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;//used to see who logged in and out at what time



        public HomeController(ILogger<HomeController> logger)//constructor based dependency injector
        {
            _logger = logger;
        }



        public IActionResult Index()//first emthod will nvoke when the program is started
        {
            return View();//it is a inbuld function it will automatically makes view
        }
        public IActionResult SayHello(string name)//Iaction is a html
        {
            if (string.IsNullOrEmpty(name))



                ViewData["v1"] = name;//it is dictionary



            else
                ViewData["v1"] = name;



            return View();//it is a inbuld function it will automatically makes view
        }
        public IActionResult Add(int x, int y)//Iaction is a html
        {
            int result = x + y;
            ViewData["result"] = result;
            return View();//it is a inbuld function it will automatically makes view
        }
        public IActionResult Multiply(int x, int y)//Iaction is a html
        {
            int result = x * y;
            ViewData["result"] = result;
            return View("Add");//it is a inbuld function it will automatically makes view
        }
        public IActionResult Divide(int x, int y)//Iaction is a html
        {
            int result = x / y;
            ViewData["result"] = result;
            return View("Add");//it is a inbuld function it will automatically makes view
        }



        public IActionResult DoLogin(string txtUser, string txtpwd)
        {
            ViewData["userValue"] = $"{txtUser},{txtpwd}";
            return View();



        }
        public IActionResult Privacy()
        {
            return View();
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //working with book objects
        public IActionResult AddnewBook()
        {
            Book book = new Book();
            return View(book);
        }
        public IActionResult SavenewBook(Book pBook)
        {
            string fname = @"C:\temp\books.csv";
            string strBook = $"{pBook.BookID},{pBook.Title},{pBook.AuthorName},{pBook.Cost}";
            using (StreamWriter sw = new StreamWriter(fname, true))
            {
                sw.WriteLine(strBook);
            }
            return View(pBook);





        }
        private Book StringToBook(String[] data, Book book)
        {
            book.BookID = int.Parse(data[0]);
            book.Title = data[1];
            book.AuthorName = data[2];
            book.Cost = float.Parse(data[3]);
            return book;



        }
        public IActionResult ListAllBook()
        {
            string fname = @"c:\temp\books.csv";
            List<Book> list = new List<Book>();
            using (StreamReader sr = new StreamReader(fname))
            {
                string strBook = $"{sr.ReadLine()}";
                string[] data = strBook.Split(',');
                Book book = StringToBook(data, new Book());
                list.Add(book);
                while (!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(",");
                    book = StringToBook(data, new Book());
                    list.Add(book);



                }
            }
            return View(list);
            //Create Author Model - Author ID,  Author Name, Author Date of Birth, No of Books Published,Royalty company.



            // Create Author Controller - CreateAuthor, ListAuthors, ModifyAuthor,FindAuthor,DeleteAuthor



            // Create Views w.r.t to the controller



        }
        public IActionResult AddAuthor()
        {
            Author author = new Author();
            return View(author);
        }
        public IActionResult SavenewAuthor(Author pAuthor)
        {
            string fname = @"C:\temp\Author.csv";
            string strAuthor = $"{pAuthor.AuthorID},{pAuthor.AuthorName},{pAuthor.NoOfBookPublished},{pAuthor.Royalty},{pAuthor.DOB}";
            using (StreamWriter s = new StreamWriter(fname, true))
            {
                s.WriteLine(strAuthor);
            }
            return View(pAuthor);

        }
        public Author StringToAuthor(String[] data, Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.NoOfBookPublished = int.Parse(data[2]);
            author.Royalty = data[3];
            author.DOB = DateTime.Parse(data[4]);
            return author;

        }
        public IActionResult ListAllAuthor()
        {
            string fname = @"c:\temp\Author.csv";
            List<Author> lists = new List<Author>();
            using (StreamReader s = new StreamReader(fname))
            {
                string strAuthor = $"{s.ReadLine()}";
                string[] data = strAuthor.Split(',');
                Author author = StringToAuthor(data, new Author());
                lists.Add(author);
                while (!s.EndOfStream)
                {
                    strAuthor = $"{s.ReadLine()}";
                    data = strAuthor.Split(",");
                    author = StringToAuthor(data, new Author());
                    lists.Add(author);
                }
            }
            return View(lists);
        }
        //public static Author StringToAuthor(String[] data, Author author)
        //{
        //    author.AuthorID = int.Parse(data[0]);
        //    author.AuthorName = data[1];
        //    author.NoOfBookPublished = int.Parse(data[2]);
        //    author.Royalty = data[3];
        //    author.DOB = DateTime.Parse(data[4]);
        //    return author;
        //}
    }
}