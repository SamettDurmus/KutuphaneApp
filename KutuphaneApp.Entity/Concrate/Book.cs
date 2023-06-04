using KutuphaneApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneApp.Entity.Concrate
{
	public class Book : IEntity
	{

        public int Id { get; set; }
		public int BookName { get; set; }
        public BookDetail BookDetails { get; set; }
    }
}
