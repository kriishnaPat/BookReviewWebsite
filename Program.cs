using System;
using System.Collections.Generic;  

namespace BookReviewWebsite
{
    class Program
    {
        public static int index;
        static void Main(string[] args)
        {
            usercheck();
            List<string> books = new List<string>();
            
            while (true){
                //diplays menu options
                Console.WriteLine(@"
    1.Add in progress book
    2.View book goal progress
    3.Complete book/add review
    4.Remove book review
    5.Search for book review
    6.Exit
");
                //prompting user for input then converting the user input to integer 
                Console.Write("Enter the number for your choice: ");
                int user_choice = Convert.ToInt32(Console.ReadLine());
                if (user_choice == 1)
                {
                    Console.WriteLine("Enter book name: ");
                    string bookname = Console.ReadLine();
                    Console.WriteLine("Enter book author: ");
                    string author = Console.ReadLine();
                    Book newbook = new Book(bookname, author);
                    List<string> fullInfo = new List<string>{newbook.name, newbook.author};
                    books.AddRange(fullInfo);
                    foreach(var month in books)
                    {
                        Console.Write(month);
                    }
                } 
                else if (user_choice == 2)
                {
                }
                else if (user_choice == 3) 
                {  
                    Console.WriteLine("Enter name of the book you have finished: ");
                    string completeBook = Console.ReadLine();
                    for (int i = 0; i < books.Count; i++)
                    {
                        if (books[i].Contains(completeBook)){
                            index = books.IndexOf(completeBook);
                            Console.Write(index);
                    }
                    }
                    Console.WriteLine("Enter a rating from (1-10) for the book: ");
                    string rating = Console.ReadLine();
                    Console.WriteLine("Enter a description for the book: ");
                    string description = Console.ReadLine();
                    books.Insert(index, rating);
                    books.Insert(index, description);
                    foreach(var month in books)
                    {
                        Console.Write(month);
                    }

                }
                else if (user_choice == 4)
                {
                    Console.WriteLine("Enter name of the book you would like to remove: ");
                    string removeBook = Console.ReadLine();
                    for (int i = 0; i < books.Count; i++)
                    {
                        if (books[i].Contains(removeBook)){
                            index = books.IndexOf(removeBook);
                            Console.Write(index);
                    } 
                    }
                    books.RemoveAt(index);
               
                }
                else if (user_choice == 5)
                {
                    Console.WriteLine("Enter name of the book you would like to view the review of: ");
                    string findBook = Console.ReadLine();
                    for (int i = 0; i < books.Count; i++)
                    {
                        if (books[i].Contains(findBook)){
                            index = books.IndexOf(findBook);
                            Console.Write(index);
                        }
                }
                Console.WriteLine(books[index]);
                }
                else if (user_choice == 6)
                {
                    break;
                }
                else 
                {
                    Console.Write("That was not a valid choice!");
                }
        }
        static int usercheck(){
            Console.WriteLine("Enter Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            if(username == "bookreader" && password == "123456789"){
                Console.Write("Welcome bookreader to the book review website!");
            }else{
                    Console.WriteLine("Either your username or password is incorrect please try again.");
                }
            return 1;
        }
        }
        }
    class Book{
        public string name;
        public string author;
        public string description;
        public int rating;
        public Book(string name, string author){
            this.name = name;
            this.author = author;
        }
        public void addBook(){

        }
    }
}

