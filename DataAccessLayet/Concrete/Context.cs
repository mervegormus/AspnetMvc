using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayet.Concrete
{
    public class Context:DbContext  //bir başka sınıftan yerden bir şeyleri kalıtsal yoldan almaya yarar : c# da.
    {
        // dbsetler sqle tablo olarak yasıtayacak.
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
