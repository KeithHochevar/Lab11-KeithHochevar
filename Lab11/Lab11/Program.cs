using System;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1:
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            Console.WriteLine(names[2]);
            Console.WriteLine(names[4]);

            // Question 2:
            int i;

            string[] months = new string[12];
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";

            for (i = 0; i < 12; i++)
            {
                Console.WriteLine("{0} : {1}", i, months[i]);
            }

            // Question 3:
            string[] seasons = { "Summer", "Fall", "Winter", "Spring" };

            foreach (string listseasons in seasons)
                Console.WriteLine(listseasons);

            // Question 4:

            // Part a:
            Random random = new Random();
            int[] randomNumber = new int[1000];

            for (int y = 0; y < randomNumber.Length; y++)
            {
                randomNumber[y] = random.Next(0, 100);
            }

            // part b:
            foreach (int chances in randomNumber)
            {
                Console.Write(chances);
                Console.Write(" ");
                // Console.WriteLine();
            }
        }
    }
}
