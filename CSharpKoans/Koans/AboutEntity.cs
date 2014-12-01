using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKoans.Koans
{
    public class Context : DbContext
    {
        public Context():base("DefaultConnection")
        {
           
        }

        public DbSet<Actor> Actors { get; set; }
        

    }
    class DbInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            context.Actors.Add(new Actor()
            {
                Name = "Tom",
                Surname = "Cruise"
            });
        }
    }
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public String Name { get; set; }
        [Required]
        [StringLength(50)]
        public String Surname { get; set; }
        [StringLength(200)]
        public String Note { get; set; }
    }
}
