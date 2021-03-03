using System;
//Login Assignment docs project
namespace cs1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Setup = User_setup();
            string UserName = Setup[0];
            string PassWord = Setup[1];
            Console.WriteLine("Congratualations the data is succesfully stored please login!");
            Console.WriteLine(User_login(UserName,PassWord));

        }
        static string[] User_setup ()//This is the function to get the Username and Password from the user
        {
            Console.WriteLine("Welcome Person Please Enter a Username and a Password. ");
            Console.Write("Type your Username: ");
            string Username = Console.ReadLine();
            Console.Write("Type your Password: ");
            string Password = Console.ReadLine();
            string[] user_data = { Username, Password };
            return user_data;
            //The data is returned as an array which will be passed into user_login
        }

        static string User_login(string Username, string Password)
            // will take user data from User_setup
            //Then will check to see if the user's credentials are aligned
            // After 4 guesses it will be over
        {
            int guesses = 4;
            while (guesses != 0)
            {
                Console.Write("Type your Username: ");
                string Username1 = Console.ReadLine();
                Console.Write("Type your Password: ");
                string Password1 = Console.ReadLine();
                bool User_result = string.Equals(Username, Username1);
                bool Password_result = string.Equals(Password, Password1);
                if (User_result == true & Password_result == true)
                {
                    return "Welcome! You have succesfully logged in!";
                }
                else
                {
                    guesses--;
                    Console.WriteLine("invalid user ID password, only {0} more tries",guesses);
                }


            }
            return "Your account is disabled please contact customer service";

        }


    }
}