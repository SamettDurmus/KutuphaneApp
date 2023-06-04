using KutuphaneApp.Entity.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneApp.Business.Concrate
{
	public class KutuphaneAppContext:DbContext
	{
        public KutuphaneAppContext()
        {
            
        }
        public KutuphaneAppContext(DbContextOptions<KutuphaneAppContext> options) : base(options) { }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"server=CANER;database=KutuphaneApp;Integrated Security=true");
		}

		public virtual DbSet<Author> Authors { get; set; }
		public virtual DbSet<Book> Books { get; set; }
		public virtual DbSet<BookDetail> BookDetails { get; set; }
		public virtual DbSet<Cateogory> Cateogorys { get; set; }
		public virtual DbSet<Photo> Photos { get; set; }
		public virtual DbSet<User> Users { get; set; }
	}
}
