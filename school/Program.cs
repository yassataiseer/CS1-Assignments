using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace school
{
    class Program
    {
        static void Main(string[] args)
        {
            string step = Step1();
            Console.WriteLine(step);//Launches step1 fucntion
        }

        static string Step1()
        {
            Console.WriteLine("Welcome to MySecure, a stable login system for businesses with safe data!");
            Console.WriteLine("Pick an option:");
            Console.WriteLine("Press 1 for Login");
            Console.WriteLine("Press 2 for SignUp");
            Console.WriteLine("Press any other key to leave");//Asks user input
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                int guesses = 4;//Makes guesses while loop
                while (guesses != 0)
                {
                    string[] userdata = Login();
                    bool usercheck = FindUser(userdata[0]);//verifies username
                    bool passwordcheck = FindPassword(userdata[1]);/// verifies psswd
                    if (usercheck == true && passwordcheck == true)
                    {
                        return "Welcome! You have succesfully logged in!";
                    }
                    else//if not correct
                    {
                        guesses--;
                        Console.WriteLine("You have invalid credentials");
                        Console.WriteLine("Please login again");
                        Console.WriteLine("You have onle {0} guesses left", guesses-1);
                        if (guesses - 1 == 0)
                        {
                            return "Your account is disabled please contact customer service";

                        }
                        else { }
                    }
                }
            }
            else if (input == 2)
            {
                string[] userdata = SignUp();//redirects to signup
                bool userwriter = UserWriter(userdata[0], userdata[1]);
                return "\nWelcome to MySecure, " + userdata[0] + "! You have succesfully signed up.\n-----------------------------------------------------------------------------------------------------";
            }//If clicked anything else:
            return "Thanks for using MySecure. Have a nice day!";

        }


        static string[] Login() {//Vinothan
            Console.WriteLine("Please enter your valid username");
            string username = Console.ReadLine();

            Console.WriteLine("Please enter your valid pssword");
            string password = Console.ReadLine();

            string[] userdata = { username, password };
            return userdata;
            //Creating a method to call to in the main for the sign up feature, using strings U and P for Username and Password

        }

        static string[] SignUp()//By Shirley
        {
            Console.WriteLine("Please enter your desired username:");
            string U = Console.ReadLine();
            Console.WriteLine("Please enter a password");
            string P = Console.ReadLine();
            string[] userdata = { U, P };
            //Prompts the user to input their desired username, password, and then welcomes them
            return userdata;
        }




        static bool UserWriter(string user, string passw)//Code written by Cole
        {
            using (StreamWriter sw = File.AppendText("username.txt"))
            {
                sw.WriteLine(user);
                sw.Flush();
                sw.Close();
            }
            //Writes username into username.txt
            using (StreamWriter sw = File.AppendText("password.txt"))
            {
                sw.WriteLine(passw);
                sw.Flush();
                sw.Close();
            }
            //writes password to password.txt
            return true;//if everything works return true
        }
        static bool FindUser(string username)
        {
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead("username.txt"))//opens the username.txt file 
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))//encodes it so the lines can be compared
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line == username)//searches line by line to see if there is any names equal
                    {
                        return true;//returns true if found
                    }
                    else
                    {
                    }
                }}
            return false;
        }
        static bool FindPassword(string password)
        {
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead("password.txt"))//opens the password.txt file 
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))//encodes it so the lines can be compared
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line == password)//searches line by line to see if there is any names equal
                    {
                        return true;//returns true if found
                    }
                    else
                    {
                    }
                }
            }
            return false;
        }

        
    }
}
