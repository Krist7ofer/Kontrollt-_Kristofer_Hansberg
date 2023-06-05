using System.Security.Cryptography;

namespace Kontrolltöö_Kristofer_Hansberg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali juhtum 1-4");
            Console.WriteLine("---------------");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SingleOrDefault();
                    break;

                case 2:
                    TakeAll();
                    break;

                case 3:
                    IfAndElse();
                    break;

                case 4:
                    ForLoop();
                    break;               
                    
                default:
                    Console.WriteLine("Valisite vale juhtumi.");
                    break;
            }
        }
        static void SingleOrDefault()
        {
            IList<int> oneElement = new List<int>() { 7 };

            Console.WriteLine("Single or Default");
            Console.WriteLine("-----------------");

            var singleOrDefault = oneElement.SingleOrDefault();

            Console.WriteLine(singleOrDefault);
        }
        static void TakeAll()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Take all");
            Console.WriteLine("--------");

            IEnumerable<int> allNumbers = numbers.Take(numbers.Count);

            foreach (int number in allNumbers)
            {
                Console.WriteLine(number);
            }
        }
        static void IfAndElse()
        {
            Console.WriteLine("Vali juhtum 1: Faili kirjutamine läbi kosnooli; 2: Faili lugemine ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)                        
            {
                Console.WriteLine("Kirjutage tekst faili sisse läbi konsooli");
                Console.WriteLine("-----------------------------------------");
                string filePath = @"C:/Users/opilane/Desktop/WriteToFile.txt";
                string inputText = Console.ReadLine();

                File.WriteAllText(filePath, inputText);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Faili lugemine");
                Console.WriteLine("-----------------");

                string line;

                try
                {
                    //Kui kirjutada tekst.txt asemel WriteToFile.txt, siis loeb faili
                    using (StreamReader sr = new StreamReader("C:/Users/opilane/Desktop/tekst.txt"))
                    {
                        int count = 0;

                        while (sr.EndOfStream == false)
                        {
                            ++count;
                            line = sr.ReadLine();
                            int charLine = line.Length;
                            Console.WriteLine(count + " " + line + " " + charLine);
                        }
                        sr.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Faili ei saa lugeda");
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        static void ForLoop()
        {
            int i, j, rows, number = 1;

            Console.WriteLine("Numbri püramiid");

            Console.WriteLine("Sisesta ridade arv");

            rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------");
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", number);
                    number++;
                }
                Console.Write("\n");
            }
        }
    }
}