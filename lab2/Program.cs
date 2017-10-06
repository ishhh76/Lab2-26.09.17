using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class LibraryDetails
    {
        List<Book> bookList = new List<Book>();
        private int count;

        public LibraryDetails()
        {
            bookList.Add(new Book("Treasure Island", "RL Stevenson", 10));
            bookList.Add(new Book("Famous Five", "Enid Blyton", 10));
            bookList.Add(new Book("Atlas Shrugged", "Ayn Rand", 10));
           
        }

        public int BookAvailability()
        {
            string name, author;
            
            Console.WriteLine("Provide the book name: ");
            name = Console.ReadLine();
           
            Console.WriteLine("Provide the author name: ");
            author= Console.ReadLine();

            Console.WriteLine(" The book is available and the available copies are : ");
            
            foreach(Book b in bookList)
            {
                if (b.Name.Equals(name))
                    return b.Count;
            }
            return 0;
            
        }

       /* public int LoanBook(int count) replicate the same method again and instead of 
        * return go for call of method b.decrement.
        {
            Console.WriteLine("If you want to loan a book: Choose Y / N");
            try
            {
                string answer;
                answer = Console.ReadLine();

                if (answer == "Y")
                    return (count - 1);
                else
                    return 0;
                Console.WriteLine("Books Remaining: "+ (count-1));
            
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception found: {0}", e);
            }

            
        }*/
        public int Loan_A_Book()
        {
            string name;
            Console.WriteLine("Enter book name to borrow: ");
            name = Console.ReadLine();
            Console.WriteLine("To loan the book: Press Y/N");
            Console.ReadLine();
            

            
                foreach (Book b in bookList)
                {
                  if(b.Name.Equals(name))
                {
                    int bookCount;
                    bookCount = b.Count--;
                    Console.WriteLine("Number of copies left for this book is: {0}", b.Count--);

                }
                
                }

            return 0;
        }
        
        static void Main(string[] args)
        {
            LibraryDetails libraryDetails = new LibraryDetails();
 
            Console.WriteLine(libraryDetails.BookAvailability());
            Console.WriteLine(libraryDetails.Loan_A_Book());


            Console.ReadLine();



        }
    }
}
