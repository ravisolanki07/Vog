using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace VogCodeChallenge.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = QuestionClass.NamesList.Select(n =>
            //{
            //    //iterate through list
            //    return n + "temp";

            //}).ToList();

            ////just for displaying the data
            //list.ForEach(n => { Console.WriteLine(n); });

            Console.WriteLine(TESTModule(1));
            Console.WriteLine(TESTModule(2));
            Console.WriteLine(TESTModule(2.0f));
            Console.WriteLine(TESTModule("VogApp"));
            Console.WriteLine(TESTModule(12.1212));
            Console.WriteLine(TESTModule(0));
            Console.ReadKey();
        }

        static object TESTModule(object input)
        {
            Dictionary<Type, int> typeDict = new Dictionary<Type, int>
            {
                {typeof(int),0},
                {typeof(string),1},
                {typeof(float),2}
            };
            var type = input.GetType();

            if (input.GetType() == typeof(int) || input.GetType() == typeof(float) || input.GetType() == typeof(string))
            {
                switch (typeDict[type])
                {
                    case 0:
                        var inputInt = Convert.ToInt32(input);
                        if (inputInt > 4)
                        {
                            return inputInt * 3;
                        }
                        if (inputInt < 1)
                        {
                            throw new InvalidOperationException("Please enter value which is greater than 0");
                        }
                        else
                        {
                            return inputInt * 2;
                        }
                    case 1:
                        return input.ToString().ToUpper();
                    case 2:
                        var inputFloat = float.Parse(input.ToString());
                        if (inputFloat == 1 || inputFloat == 2)
                        {
                            return 3.0f;
                        }
                        return input;
                }
            }

            return input;
        }
    }
}
