using System;

namespace BookReviewWebsite
{
    class Program
    {
        static void Main(string[] args)
        {
            usercheck();
            while (true){
                //diplays menu options
                Console.WriteLine(@"
    1.Add new book review
    2.View book goal progress
    3.Save in progress book
    4.Remove book review
    5.Search for book review
    6.Exit
");
                //prompting user for input then converting the user input to integer 
                Console.Write("Enter the number for your choice: ");
                int user_choice = Convert.ToInt32(Console.ReadLine());
                if (user_choice == 1)
                {
                } 
                else if (user_choice == 2)
                {
                }
                else if (user_choice == 3) 
                {  
                }
                else if (user_choice == 4)
                {
                }
                else if (user_choice == 5)
                {
                }
                else if (user_choice == 6)
                {
                }
                else 
                {
                }
        }
        static int usercheck(){
            Console.WriteLine("Enter Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            if(username == "bookreader"){
                if (password == "123456789"){
                    Console.Write("Welcome bookreader to the book review website!");
                }else{
                    Console.WriteLine("Either your username or password is incorrect please try again.");
                }
            }else{
                Console.WriteLine("Either your username or password is incorrect please try again.");
            }
            return 1;
        }

}
}
}