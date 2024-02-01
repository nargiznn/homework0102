using System;
using Microsoft.VisualBasic;
using System.Text;
using System.Xml.Linq;

namespace homework0102
{
	public class Library
	{
       
        List<string> books = new List<string>();
		public int BookLimit=100;
		public void AddBook()
		{
            Console.WriteLine("Kitabin adını daxil edin: ");
            string bookname = Console.ReadLine();
            if (books.Contains(bookname))
		    {
				Console.WriteLine($"{bookname} adli kitab var!");
				return;
			}
			if (string.IsNullOrWhiteSpace(bookname))
			{
				Console.WriteLine("Duzgun ad daxil edin!");
                return;
            }
	
            books.Add(bookname);

		}
		public bool RemoveBook()
		{
            Console.WriteLine("Kitabin adını daxil edin: ");
            string bookname = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(bookname) || !books.Contains(bookname))
			{
                Console.WriteLine($"{bookname} kitab yoxdur");
                return false;
            }
			
            else
            {
                Console.WriteLine($"{bookname} kitab silindi");
                books.Remove(bookname); return true;
            }
			

        }
		public void ShowBook()
		{
			foreach(var book in books)
			{
				Console.WriteLine(book);
			}
		}
		public void SpesfkShowBook()
		{
            Console.WriteLine("Kitabin adını daxil edin: ");
            string bookname = Console.ReadLine();

            if (books.Contains(bookname))
			{
				Console.WriteLine($"{bookname} kitab var");
			}
			else
			{
				Console.WriteLine("Bele bir kitab yoxdur");
			}
		}



    }
}

