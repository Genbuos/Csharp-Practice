

namespace ConsoleApp1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new();

            string[] names = { "Jordan", "Kalil", "Andy" };
            int[] numbers = { 1, 2, 3, 4, 5 };



            Console.WriteLine($"Last Index: {program.GetLastIndex(names)}");
            Console.WriteLine($"Second to Last Index: {program.GetSecondToLastIndex(names)}");
            Console.WriteLine($"First Element: {program.GetFirstElement(names)}");
            Console.WriteLine($"Last Element: {program.GetLastElement(names)}");
            Console.WriteLine($"Second to Last Element: {program.GetSecondToLastElement(names)}");

            Console.WriteLine($"Sum: {program.GetSum(numbers)}");
            Console.WriteLine($"Average: {program.GetAverage(numbers)}");

            Console.WriteLine($"Odd Numbers: {program.ExtractAllOddNumbers(numbers)}");
            Console.WriteLine($"Even Numbers: {program.ExtractAllEvenNumbers(numbers)}");

            string elementToCheck = "Bob";
            Console.WriteLine($"Contains '{elementToCheck}': {program.Contains(names, elementToCheck)}");
        }





        public  int GetLastIndex(string[] names)
        {
            return names.Length - 1;
        }

        public int GetSecondToLastIndex(string[] names)
        {
            return names.Length - 2;
        }

        public string GetFirstElement(string[] names)
        {
            return names[0];
        }

        public string GetLastElement(string[] names)
        {

            return names[GetLastIndex(names)];
        }

        public string GetSecondToLastElement(string[] names)
        {
            return names[GetLastIndex(names) - 1];
        }

        public int GetSum(int[] ints)
        {

            int sum = 0;
            foreach (int i in ints)
            {
                sum += i;
            }
            return sum;
        }

        public int GetAverage(int[] ints)
        {
            int sum = 0;
            foreach (int i in ints)
            {
                sum += i;
            }
            int average = sum / ints.Length;
            return average;
        }

        public string ExtractAllOddNumbers(int[] numbers)
        {
            string odds = "";
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    odds += number.ToString();
                }

            }
            return odds;
        }

        public string ExtractAllEvenNumbers(int[] numbers)
        {
            string steve = "";
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    steve += number.ToString();
                }

            }
            return steve;
        }

        public bool Contains(string[] names, string element)
        {
            return names.Contains(element);
        }
    }

      
    }

