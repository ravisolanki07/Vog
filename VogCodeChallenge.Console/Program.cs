using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace VogCodeChallenge.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = QuestionClass.NamesList.Select(n =>
            {
                //iterate through list
                return n + "temp";

            }).ToList();

            //just for displaying the data
            list.ForEach(n => { Console.WriteLine(n); });

            Console.ReadLine();
        }
    }
}
