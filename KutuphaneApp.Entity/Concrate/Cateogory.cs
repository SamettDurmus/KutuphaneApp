using KutuphaneApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneApp.Entity.Concrate
{
	public class Cateogory : IEntity
	{
        public int Id { get; set; }

        public int CategoryName { get; set; }
    }
}
