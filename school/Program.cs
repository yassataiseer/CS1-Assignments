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
            Console.WriteLine("Hello World!");
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
    }
}
