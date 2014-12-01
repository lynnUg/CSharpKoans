using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKoans.Koans
{
    [TestFixture]
    public static class AboutDelegatesTest
    {
        [Test]
        public static void viewDelegates()
        {
            Document doc1 = new Document
            {
                Author = "Mathew Adams",
                DocumentDate = new DateTime(2000, 01, 01),
                Text = "Am I one year early?"

            };

            DocumentProcessor processor = DocumentProcessor.Configure();
            String docsConverted=processor.Process(doc1);
            Console.WriteLine("Documents converted to");
            Console.WriteLine(docsConverted);
            Assert.AreEqual(docsConverted, "French Luganda ");
            
        }
    }
}
