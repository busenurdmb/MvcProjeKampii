using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
{  //Ccontext sınıfı buraya yazılmış olan dbset türündeki propları
        //sqle birer tablo olarak yansıtıcak
        
        //About ile Abouts arasındaki fark şu
        //About benim projenin içinde yer alan sınıfın ismi
        //Abouts ise sql de veri tabanımıza yansıyacak olan tablonun ismi
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Message> Messages { get; set; }

        public DbSet<ImageFile> Images { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
