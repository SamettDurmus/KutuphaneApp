using KutuphaneApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneApp.Entity.Concrate
{
	public class Cateogory : IEntity
	{
        public int Id { get; set; }
		[Required(ErrorMessage = "Lütfen 'Kategori' adini boş geçmeyiniz ")]
		public string? CategoryName { get; set; }
    }
}
