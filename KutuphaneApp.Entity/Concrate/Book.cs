using KutuphaneApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneApp.Entity.Concrate
{
	public class Book : IEntity
	{

        public int Id { get; set; }

		[Required(ErrorMessage = "Lütfen 'Kitap' adini boş geçmeyiniz ")]
		public int BookName { get; set; }
        public BookDetail BookDetails { get; set; }

        public List<Cateogory> Cateogories { get; set; }
    }
}
