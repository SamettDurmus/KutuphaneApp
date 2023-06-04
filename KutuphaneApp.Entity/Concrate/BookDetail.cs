using KutuphaneApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneApp.Entity.Concrate
{
	public class BookDetail : IEntity
	{
        public int Id { get; set; }
		public int Page { get; set; }
		public DateTime PublishDate { get; set; }
		public string? Preface { get; set; }

		public int BookId { get; set; }
		public Book? Books { get; set; }
		public List<Photo>? Photos { get; set; }
	}
}
