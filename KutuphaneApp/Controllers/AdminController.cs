using KutuphaneApp.Business.Abstract;
using KutuphaneApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace KutuphaneApp.Controllers
{
	public class AdminController : Controller
	{
        private readonly IAuthorService _authorService;

        private readonly ICategoryService _categoryService;

        private readonly IBookService _bookService;
        public AdminController(IBookService bookService,IAuthorService authorService , ICategoryService categoryService)
        {
            _bookService = bookService;
            _categoryService = categoryService;
            _authorService = authorService;

        }

        [HttpGet]
        public IActionResult AddAuthors()
		{
			return View();
		}
        [HttpPost]
        public IActionResult AddAuthors(AuthorViewModel authorViewModel)
        {
            if (ModelState.IsValid)
            {
                _authorService.Add(authorViewModel.Authors);
            }
            else
            {
                return View(authorViewModel);
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(CategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Add(categoryViewModel.Categories);
            }
            else
            {
                return View(categoryViewModel);
            }
            return View();
        }


        [HttpGet]
        public IActionResult AddBooks()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBooks(BooksViewModel bookViewModel)
        {
            if (ModelState.IsValid)
            {
                _bookService.Add(bookViewModel.Books);
            }
            else
            {
                return View(bookViewModel);
            }
            return View();
        }

    }
}
