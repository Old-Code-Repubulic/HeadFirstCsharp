using System;

namespace Ch._2_coding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string sentence = "hidey oh";
            int num = 0; 
            while (sentence != "")
            {
                Console.WriteLine("I'm not an empy string");
                if (num == 3)
                    sentence = "";
                else
                {
                    num++;
                }
            }

        }
    }
}
