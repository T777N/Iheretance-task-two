using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class DocumentProgram
    {
       /* - OpenDocument 
	- EditDocument(virtual)
	- SaveDocument(virtual)

	Her uc metod voiddir ve ekrana acagidakilari cixardirlar.
	
	1. Document Opened
	2. Can Edit in Pro and Expert versions
	3. Can Save in Pro and Expert versions
       */
       public void OpenDocument()
        {
            Console.WriteLine($" Document Opened ");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine($" Can Edit in Pro and Expert versions ");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine($" Can Save in Pro and Expert versions ");
        }

    }
    class ProDocumentProgram:DocumentProgram
    {
        /*
        1. Document Opened
	    2. Document Edited(burda override elediyiniz metodu seald edirsiniz)
        3. Document Saved in doc format, for pdf format buy Expert packet
	*/
        public new void OpenDocument()
        {
            Console.WriteLine($" Document Opened ");
        }
        public sealed override void EditDocument()
        {
            Console.WriteLine($" Document Edited ");
            //base.EditDocument();
        }
        public override void SaveDocument()
        {
            Console.WriteLine($" Document Saved in doc format, for pdf format buy Expert packet ");
            //base.SaveDocument();
        }
    }

    /*3. ExpertDocument adinda bir class yaradin hansi ki ProDocumentProgram classindan miras alir ve ekrana asagidakilari cixardir:

	1. Document Opened
	2. Document Edited
	3. Document Saved in pdf format*/

    class ExpertDocument:ProDocumentProgram
    {
        public new void OpenDocument()
        {
            Console.WriteLine($" Document Opened ");
        }
       public new void EditDocument()
       {
            Console.WriteLine($" Document Edited ");
       }
        public override void SaveDocument()
        {
            Console.WriteLine($" Document Saved in pdf format ");
            //base.SaveDocument();
        }
        
    }

    /*Qebul olunan acara gore yaradilan obyektler DocumentProgram classina upcast olunmalidir. Meselen asagidaki kimi

	DocumentProgram docProgram = new ProDocumentProgram(); ve ya 
	DocumentProgram docProgram = new ExpertDocument ();*/

    class Program
    {
        static void Start()
        {
            string Start2()
            {
            Console.WriteLine();
            Console.WriteLine($"          Enter Please          ");
            Console.WriteLine();
            Console.WriteLine($" Basic  [ 1 ] ");
            Console.WriteLine($" Pro    [ 2 ] ");
            Console.WriteLine($" Expert [ 3 ] ");
            Console.WriteLine();
            Console.Write($" Enter : ");
            string text_one;
            text_one = Console.ReadLine();
                return text_one;
            }
            string text2 = Start2();
            if (text2 == "1")
            {
                Console.Clear();
                DocumentProgram docProgram = new DocumentProgram();
                Console.WriteLine();
                docProgram.OpenDocument();
                Console.WriteLine();
                docProgram.EditDocument();
                Console.WriteLine();
                docProgram.SaveDocument();
                Console.WriteLine();

            }
            else if (text2 == "2")
            {
                Console.Clear();
                DocumentProgram docProgram = new ProDocumentProgram();
                Console.WriteLine();
                docProgram.OpenDocument();
                Console.WriteLine();
                docProgram.EditDocument();
                Console.WriteLine();
                docProgram.SaveDocument();
                Console.WriteLine();
            }
            else if (text2 == "3")
            {
                Console.Clear();
                DocumentProgram docProgram = new ExpertDocument();
                Console.WriteLine();
                docProgram.OpenDocument();
                Console.WriteLine();
                docProgram.EditDocument();
                Console.WriteLine();
                docProgram.SaveDocument();
                Console.WriteLine();
            }
            else {
                Console.Clear();
                Start();
            }
            
        }
        static void Main(string[] args)
        {
            Start();
        }
    }
}
