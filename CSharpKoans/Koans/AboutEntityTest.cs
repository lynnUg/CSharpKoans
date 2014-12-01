using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKoans.Koans
{
    [TestFixture]
    public static class AboutEntityTest
    {
        [Test]
        public static void ViewActors()
        {
            Context db = new Context();

            var Actors = db.Actors;
            Console.WriteLine("Actors Names");
            foreach (var aActor in Actors)
            {
                Console.WriteLine(aActor.Name + " "+aActor.Surname);
            }
           

        }
        
        [Test]
        public static void InsertActor()
        {
            Context db = new Context();
            db.Actors.Add(new Actor()
            {
                Name = "Lynn",
                Surname = "Asiimwe"
            });
            db.SaveChanges();
        }

        [Test]
        public static void UpdateActor()
        {
            Context db = new Context();
            Actor topFemale = db.Actors.Where(i => i.Name == "Lynn").SingleOrDefault();
            if (topFemale!=null)
            {
              topFemale.Name = "Melissa";
              db.Entry(topFemale).State = EntityState.Modified;
              db.SaveChanges();
              topFemale = db.Actors.Where(i => i.Name == "Melissa").SingleOrDefault();
              Console.WriteLine(topFemale.Name);
            }
            else
            {
                Console.WriteLine("No top female by name Lynn");
            }
           
           

        }
        [Test]
        public static void DeleteActor()
        {
            Context db = new Context();
            Actor topFemale = db.Actors.Where(i => i.Name == "Melissa").SingleOrDefault();
            if(topFemale!=null)
            {
                db.Actors.Remove(topFemale);
                db.SaveChanges();
                topFemale = db.Actors.Where(i => i.Name == "Melissa").SingleOrDefault();
                if(topFemale==null)
                {
                    Console.WriteLine("Melissa deleted");

                }
               

            }
            else
            {
                Console.WriteLine("No top female Melissa");
            }
            
        }
    }
}
