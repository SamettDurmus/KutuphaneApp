using KutuphaneApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneApp.Entity.Concrate
{
	public class BookDetail : IEntity
	{
        public int Id { get; set; }

		[Required(ErrorMessage = "Lütfen sayfa numarası boş geçmeyiniz ")]
		public int Page { get; set; }
		public DateTime PublishDate { get; set; }

		[Required(ErrorMessage = "Lütfen önyüz boş geçmeyiniz ")]
		public string? Preface { get; set; }

		public int BookId { get; set; }
		public Book? Books { get; set; }
		public List<Photo>? Photos { get; set; }
	}
}
