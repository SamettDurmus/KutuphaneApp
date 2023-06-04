using KutuphaneApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneApp.Entity.Concrate
{
	public class Author:IEntity
	{
        public int Id { get; set; }

        [Required(ErrorMessage ="Lütfen 'Yazar' adini boş geçmeyiniz ")]
        public string? AuthorName { get; set; }

		[Required(ErrorMessage = "Lütfen 'Yazar Soy' adini boş geçmeyiniz ")]
		public string? AuthorSurname { get; set; }

        public List<Book>? BookLists { get; set; }
    }
}
