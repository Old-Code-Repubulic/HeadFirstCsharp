ls
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

            TrySomeLoops();

        }

        private static void TrySomeLoops()
        {
            int count = 0;
            while (count < 10)
            {
                count = count + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }
            Console.WriteLine("The answer is " + count);
        }

    }
}

