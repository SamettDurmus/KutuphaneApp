using KutuphaneApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneApp.Entity.Concrate
{
	public class Photo : IEntity
	{
        public int Id { get; set; }

        public byte[]? PhotoPaths { get; set; }

        public List<Photo>? Photos { get; set; }
    }
}
