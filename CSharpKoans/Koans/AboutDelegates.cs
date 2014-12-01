using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKoans.Koans
{
    public class Document
    {
        public string Text
        {
            get;
            set;
        }
        public DateTime DocumentDate
        {
            get;
            set;
        }
        public string Author
        {
            get;
            set;
        }
    }
    public class DocumentProcessor
    {
        public delegate String DocumentProcess(Document doc);
        private readonly List<DocumentProcess> processes =
            new List<DocumentProcess>();
        public List<DocumentProcess> Processes
        {
            get
            {
                return processes;
            }
        }
        public string  Process(Document doc)
        {
            String docsCoverted = "";
            foreach (DocumentProcess process in Processes)
            {
               docsCoverted+= process(doc)+" ";
            }
            return docsCoverted;
        }
        public static DocumentProcessor Configure()
        {
            DocumentProcessor rc = new DocumentProcessor();
            rc.Processes.Add(DocumentProcessor.TranslateIntoFrench);
            rc.Processes.Add(DocumentProcessor.TranslateIntoLuganda);
            return rc;
        }

        private static String TranslateIntoFrench(Document doc)
        {

            Console.WriteLine("converting to french");
            return "French";
        }
        private static String TranslateIntoLuganda(Document doc)
        {

            Console.WriteLine("converting to luganda");
            return "Luganda";
        }

    }
}
