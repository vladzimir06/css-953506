using System;
using System.Globalization;
using System.Threading;

namespace Lab2Ind2
{
    class Program
    {
        static void Main(string[] args)
        {
            char language;
            do
            {
                Console.Clear();
                Console.WriteLine(
                    "You can choose from for languages: Russian, French, German and English.\nTo select one, press from 1 to 4. To exit, press 5.");
                language = Convert.ToChar(Console.ReadLine());
                DateTime MyMonths = new DateTime();




                switch (language)
                {
                    case '1':
                    {
                        Thread.CurrentThread.CurrentCulture = new CultureInfo(0x0419);
                        break;
                    }

                    case '2':
                    {
                        Thread.CurrentThread.CurrentCulture = new CultureInfo(0x040C);
                        break;
                    }

                    case '3':
                    {
                        Thread.CurrentThread.CurrentCulture = new CultureInfo(0x0407);
                        break;
                    }

                    case '4':
                    {
                        Thread.CurrentThread.CurrentCulture = new CultureInfo(0x0409);
                        break;
                    }

                    case '5':
                        break;

                    default:
                    {
                        Console.WriteLine("You must have entered something wrong.\n");
                        break;
                    }
                }

                if (language == '5')
                    break;

                for (int i = 0; i < 12; i++)
                {
                    string month = MyMonths.ToString("M");
                    Console.WriteLine(month);
                    MyMonths = MyMonths.AddMonths(1);
                }

                Console.ReadKey();
            } while (true);
            Console.WriteLine("Thank you.");
        }
    }
}
