using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace UserValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                /*string pokemon = "squirtle";
                using (StreamWriter sw = File.AppendText("pokemon.txt"))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                    sw.WriteLine(pokemon);
                    sw.Flush();
                    sw.Close();
                    Console.WriteLine("DONE");
                }*/
                Console.WriteLine("foidjnojlna");
                Console.Write(solve("Welcome"));

            }
        }
        static bool solve(string username)
        {
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead("pokemon.txt"))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line == username)
                    {
                        return true;
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
