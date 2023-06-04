using KutuphaneApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneApp.Entity.Concrate
{
	public class Author:IEntity
	{
        public int Id { get; set; }
        public string? AuthorName { get; set; }

		public string? AuthorSurname { get; set; }

        public List<Book>? BookLists { get; set; }
    }
}
