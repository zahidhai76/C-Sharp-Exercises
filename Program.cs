using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calc
{
    class Program
    {

        public static void Main()
        {
            Program.intList();
        }

        public static void intList()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    Console.Write("Enter the size of your list: ");
                    int n = int.Parse(Console.ReadLine());
                    List<int> numbers = new List<int>();
                    for(int i = 0; i < n; i++)
                    {
                        Console.Write("Enter a number to put into your list: ");
                        numbers.Add(int.Parse(Console.ReadLine()));
                    }
                    List<int> ordered = numbers.OrderBy(number => number).ToList();
                    Console.WriteLine("Your list ordered is: ");
                    foreach (int number in ordered)
                        Console.Write(number + " ");
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void Product()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    int productMax = int.MinValue;
                    int productMin = int.MaxValue;
                    List<int> numbers = new List<int>
                    {
                        1, 2, -5, 7, -1, 4, 3
                    };
                    for (int i = 1; i < numbers.Count(); i++)
                    {
                        int current_product = numbers[i] * numbers[i - 1];
                        if (current_product > productMax)
                        {
                            productMax = current_product;
                        }
                    }
                    for (int i = 1; i < numbers.Count(); i++)
                    {
                        int current_product = numbers[i] * numbers[i - 1];
                        if (current_product < productMin)
                        {
                            productMin = current_product;
                        }
                    }
                    Console.WriteLine($"The highest product of adjacent elements in the list is: {productMax}.");
                    Console.WriteLine($"The lowest product of adjacent elements in the list is: {productMin}.");
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public static void newArray()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    List<int> numbers1 = new List<int>
                    {
                        1, 2, 5
                    };
                    List<int> numbers2 = new List<int>
                    {
                        0, 3, 8
                    };
                    List<int> numbers3 = new List<int>
                    {
                        -1, 0, 2 
                    };
                    List<int> numbers4 = new List<int>
                    {
                        numbers1[1], numbers2[1], numbers3[1]
                    };
                    foreach(int i in numbers4)
                    {
                        Console.WriteLine(i);
                    }
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void sumArray()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    int result = 0;
                    List<int> numbers = new List<int>
                    {
                        1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1
                    };
                    for(int i = 0; i < numbers.Count; i++ )
                    {
                        result += numbers[i];
                    }
                    Console.WriteLine("The sum of the numbers is: " + result);
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void oddString()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    string word;
                    string result = "";
                    Console.Write("Enter a word: ");
                    word = Console.ReadLine();
                    char[] characters = word.ToCharArray();
                    for(int i = 0; i < word.Length; i++)
                    {
                        if(i == 0 || i % 2 == 0)
                        {
                            result += characters[i];
                        }
                    }
                    Console.WriteLine(result);
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public static void charTest()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    string word;
                    char letter;
                    int result = 0;
                    Console.Write("Enter a letter: ");
                    letter = Convert.ToChar((Console.ReadLine()).ToLower());
                    Console.Write("Enter a word: ");
                    word = (Console.ReadLine()).ToLower();
                    char[] characters = word.ToCharArray();
                    for(int i = 0; i < word.Length; i++)
                    {
                        if (characters[i] == letter)
                        {
                            result += 1;
                        }
                    }
                    Console.WriteLine(letter + " appears " + result + " times.");
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }


        public static void MinMaxTest()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    int a;
                    Console.Write("Enter number of integers: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    double[] numbers = new double[a];
                    for(int i = 0; i < a; i++)
                    {
                        Console.Write("Enter a number: ");
                        numbers[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    Console.WriteLine("Your largest number is: " + numbers.Max());
                    Console.WriteLine("Your smallest number is: " + numbers.Min());

                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void firstWord()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    string sentence;
                    bool word1 = false;
                    Console.Write("Enter a sentence: ");
                    sentence = Console.ReadLine();
                    string[] words = sentence.Split(new[]
                    {
                       " "
                       }, StringSplitOptions.None);
                    if(words[0].ToLower() == "hello")
                    {
                        word1 = true;
                        Console.WriteLine(word1);
                    }
                    else
                    {
                        Console.WriteLine(word1);
                    }
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }    
        }
        public static void multiple()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    int a;
                    Console.Write("Enter a multiple of 3 or 7: ");
                    a = int.Parse(Console.ReadLine());

                    if (a % 3 == 0 || a % 7 == 0)
                    {
                        finished = true;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Well done!");
        }
        public static void fourCopy()
        {
            Console.Write("Enter a sentence: ");
            string a = Console.ReadLine();

            if (a.Length >= 4)
            {
                string b = a.Substring(a.Length - 4);
                Console.WriteLine($"{b} {b} {b} {b}");
            }
            else
            {
                Console.WriteLine($"{a} {a} {a} {a}");
            }

        }
        public static void multiplyArray()
        {
            int[] Array1 = { 1, 3, -5, 4 };
            int[] Array2 = { 1, 4, -5, -2 };
            int[] Array3 = new int[4];

            /*
            Array3[0] = Array2[0] * Array1[0];
            Array3[1] = Array2[1] * Array1[1];
            Array3[2] = Array2[2] * Array1[2];
            Array3[3] = Array2[3] * Array1[3];
            */

            for (int i = 0; i < Array1.Length; i++)
            {
                Console.Write(Array1[i] * Array2[i] + " ");
            }
        }



        public static void Reverse()
        {
            string sentence;
            string result = "";
            List<string> wordsList = new List<string>();
            Console.Write("Enter a sentence: ");
            sentence = Console.ReadLine();

            string[] words = sentence.Split(new[]
            {
                " "
            }, StringSplitOptions.None);

            for(int i = words.Length - 1; i>=0; i--)
            {
                result += words[i] + " ";
            }
            wordsList.Add(result);

            foreach(String s in wordsList)
            {
                Console.WriteLine("\nReverse String: " + s);
            }

        }



        public static int Digits(int number)
        {
            int digits = 0;

            while(number != 0)
            {
                digits += number % 10;
                number /= 10;
            }

            return digits;
        }

        public static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static void mean()
        {
            double x, y, z, sum = 0;
            Console.WriteLine("Enter number of iterations");
            y = int.Parse(Console.ReadLine());
            for (int i = 0; i < y; i++)
            {
                Console.WriteLine("Enter a number");
                z = int.Parse(Console.ReadLine());
                Console.WriteLine();
                sum += z;
            }
            Console.WriteLine("Summation is : " + sum);
            Console.WriteLine("Count is : " + y);

            x = Math.Round((sum / y), 2);
            Console.WriteLine("Average is : " + x);
        }

        public static void flip()
        {
            string word, a, b, z;
            Console.WriteLine("Enter a word: ");
            word = Console.ReadLine();
            a = word.Substring(0, 1);
            z = word.Substring(word.Length - 1);
            b = word.Substring(1, word.Length - 2);
            Console.WriteLine(z + b + a);
        }

        public static void check()
        {
            int x, y;
            Console.WriteLine("Enter your first number: ");
            x = int.Parse(Console.ReadLine()); //x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            y = int.Parse(Console.ReadLine());

            if (x > 0 && y < 0)
            {
                Console.WriteLine($"{x} is positive and {y} is negative");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"{y} is positive and {x} is negative");
            }
            else
            {
                Console.WriteLine("The signs of your numbers match or at least one of your numbers is 0");
            }
        }

        public static void comp()
        {
            try
            {
                int x, y;
                Console.Write("Enter your first number: ");
                x = int.Parse(Console.ReadLine()); //x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your second number: ");
                y = int.Parse(Console.ReadLine());

                if (x != y)
                {
                    Console.WriteLine($"{x} + {y} = {x + y}");
                }
                else if (x == y)
                {
                    Console.WriteLine($"{x} + {y} * 3 = {(x + y) * 3}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }



        }

        public static int abs(int a, int b)
        {
            int c;
            if(a > b)
            {
                c = 2 * Math.Abs(a - b);
            }
            else
            {
                c = Math.Abs(a - b);
            }
            return c;
        }

        public static void longest(string line)
        {
                string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
                string word = "";
                int ctr = 0;
                foreach (String s in words)
                {
                    if (s.Length > ctr)
                    {
                        word = s;
                        ctr = s.Length;
                    }
                }

                Console.WriteLine(word);
        }

        public static void Odd()
        {
            Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
            for (int n = 1; n < (99 + 1); n++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n.ToString());
                }
            }

        }

    }

}
