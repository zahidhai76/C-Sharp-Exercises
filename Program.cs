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
            bool finished = false;
            while (!finished)
            {
                try
                {
                    wordInt words = new wordInt();
                    Console.Write("Enter a word: ");
                    words.Word = Console.ReadLine();
                    Console.Write("Enter number of copies: ");
                    words.N = int.Parse(Console.ReadLine());
                    words.copies();
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }


        //Write a C# Sharp program to create a new string which is n (non-negative integer) copies of a given string (class version)
        /*public static void Main()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    wordInt words = new wordInt();
                    Console.Write("Enter a word: ");
                    words.Word = Console.ReadLine();
                    Console.Write("Enter number of copies: ");
                    words.N = int.Parse(Console.ReadLine());
                    words.copies();
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }*/

        //Write a C# Sharp program to create a new string which is n (non-negative integer) copies of a given string

        public static string copy(string word, uint n) //uint for only positive
        {
            bool finished = false;
            string result = "";
            while (!finished)
            {
                try
                {
                    for(int i = 0; i < n; i++)
                    {
                        result += word;
                    }
                    finished = true;
                    return result;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return result;
            }
            return result;
        }

        //Write a C# Sharp program to convert the last 3 characters of a given string in upper case. If the length of the string has less than 3 then uppercase all the characters
        public static void last3()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    Console.Write("Enter a word: ");
                    string word = Console.ReadLine();
                    if(word.Length < 3)
                    {
                        word = word.ToUpper();
                    }
                    else
                    {
                        word = word.Substring(0, word.Length - 3) + word.Substring(word.Length -3, 3).ToUpper();
                    }
                    Console.WriteLine(word);
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        //Write a C# Sharp program to check if a given string contains between 2 and 4 'z' character
        public static bool test(string str)
        {
            int i = 0;
            char[] myLettersArray = str.ToCharArray();
            foreach (char letter in myLettersArray)
            {
                if (Char.ToUpper(letter) == 'Z')
                {
                    i++;
                }
            }
            if (i >= 2 && i <= 4)
            {
                return true;
            }
            return false;
        }

        //Write a C# Sharp program to check the largest number among three given integers (same as earlier exercises but using list instead of array this time)
        public static void Largest()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    int biggest = int.MinValue;
                    List<int> numbers = new List<int>();
                    Console.Write("Enter size of your list: ");
                    int n = int.Parse(Console.ReadLine());
                    while (n <= 0)
                    {
                        Console.Write("Please enter a positive integer: ");
                        n = int.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Enter a number: ");
                        numbers.Add(int.Parse(Console.ReadLine()));
                        if(numbers[i] > biggest)
                        {
                            biggest = numbers[i];
                        }
                    }
                    Console.WriteLine("The largest number in your list is " + biggest);
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }

        //Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
        /*
          public static void Main()
          {
              bool finished = false;
              while (!finished)
              {
                  try
                  {
                      Swap word = new Swap();
                      Console.Write("Enter a word: ");
                      word.Word = Console.ReadLine();
                      word.CharacterSwap(word.Word);
                      finished = true;
                  }
                  catch (Exception e)
                  {
                      Console.WriteLine(e.Message);
                  }
              }
          }
        */

        //Write a C# Sharp program to remove the character in a given position of a given string
        /* public static void Main()
         {
                  bool finished = false;
            while (!finished)
            {
                try
                {
                    Remove word = new Remove();
                    Console.Write("Enter a character position to remove: ");
                    word.N = int.Parse(Console.ReadLine());
                    Console.Write("Enter a word: ");
                    word.Word = Console.ReadLine();
                    word.removal(word.Word, word.N);
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }    
         }
        */

        //Write a C# Sharp program to count positive and negative numbers in a given array of integers
        public static void PositiveNegative()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    List<int> numbers = new List<int>();
                    Console.Write("Enter size of your list: ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Enter a number: ");
                        numbers.Add(int.Parse(Console.ReadLine()));
                    }
                    List<int> pos = numbers.Where(number => number > 0).ToList();
                    List<int> neg = numbers.Where(number => number < 0).ToList();
                    Console.WriteLine("Number of positive numbers is: " + pos.Count() + "\nNumber of negative numbers is: " + neg.Count());
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        //Write a C# Sharp program to reverse a boolean value
        public static bool reverse(bool boolean)
        {
            return !boolean;
        }
        //Write a C# Sharp program to find the cumulative sum of an array of number. Go to the editor
        //A cumulative sum is a sequence of partial sums of a given sequence.For example, the cumulative sums of the sequence {x, y, z,...}, are x, x+y , x+y+z
        public static void cumulative()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    List<int> numbers = new List<int>();
                    List<int> sum_numbers = new List<int>();
                    Console.Write("Enter size of your list: ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Enter a number: ");
                        numbers.Add(int.Parse(Console.ReadLine()));
                    }
                    for (int i = 0; i < n; i++)
                    {
                        if (i > 0)
                        {
                            sum_numbers.Add(numbers[i] + sum_numbers[i - 1]);
                        }
                        else
                        {
                            sum_numbers.Add(numbers[0]);
                        }
                    }
                    foreach(int number in sum_numbers)
                    {
                        Console.Write(number + " ");
                    }
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        //Write a C# Sharp program to check whether the average value of the elements of a given array of numbers is a whole number or not
        public static void averageInteger()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    double ctr = 0;
                    double average;
                    List<int> numbers = new List<int>();
                    Console.Write("Enter size of your list: ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Enter a number: ");
                        numbers.Add(int.Parse(Console.ReadLine()));
                        ctr += numbers[i];
                    }
                    average = ctr / n;
                    Console.WriteLine("The average value, " + average + ((average % 1 == 0) ? ",is a whole number." : ",is not a whole number."));
                    finished = true;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        //Write a C# Sharp program to check if a given string contains two similar consecutive letters
        public static bool twoConsec()
        {
            bool finished = false;
            bool result = false;
            while (!finished)
            {
                try
                {

                    Console.Write("Enter a string: ");
                    string word = Console.ReadLine();
                    List<char> characters = new List<char>();
                    characters.AddRange(word);
                    for(int i = 1; i < characters.Count; i++)
                    {
                        var a = characters[i];
                        var b = characters[i - 1];
                        if (a == b)
                        {
                            result = true;
                            break;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                    finished = true;
                    return result;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return result;
            }
            return result;
        }
        //Write a C# Sharp program to create a coded string from a given string, using specified formula
        public static void coded()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    Console.Write("Enter a string: ");
                    string word = Console.ReadLine();
                    List<char> characters = new List<char>();
                    characters.AddRange(word);
                    foreach(char c in characters)
                    {
                        if (c == 'P')
                        {
                            Console.Write("9 ");
                        }
                        else if (c == 'T')
                            {
                            Console.Write("0 ");
                        }
                        else if (c == 'S')
                        {
                            Console.Write("1 ");
                        }
                        else if (c == 'H')
                        {
                            Console.Write("6 ");
                        }
                        else if (c == 'A')
                        {
                            Console.Write("8 ");
                        }
                        else
                        {
                            Console.Write(c + " ");
                        }
                        finished = true;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        //Write a C# program to sort the integers in ascending order without moving the number -5
        public static void sortNo5()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    int ctr = 0;
                    List<int> numbers = new List<int>();
                    Console.Write("Enter size of your list: ");
                    int n = int.Parse(Console.ReadLine());
                    for(int i = 0; i < n; i++)
                    {
                        Console.Write("Enter a number: ");
                        numbers.Add(int.Parse(Console.ReadLine()));
                    }
                    List<int> ordered = numbers.Where(number => number != -5).OrderBy(number => number).ToList(); //Method
                    //List<int> ordered = (from number in numbers where number != -5 orderby number select number).ToList(); //Query
                    List<int> ordered2 = numbers.Select(number => number != -5 ? ordered[ctr++] : -5).ToList();
                    //List<int> ordered2 = from number in numbers select number
                    foreach (int number in ordered2)
                    {
                            Console.Write(number + " ");
                    }
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }


        public static void matrix()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    Console.WriteLine("Enter the dimensions of your matrix a x b : ");
                    Console.Write("a: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("b: ");
                    int b = int.Parse(Console.ReadLine());
                    int[,] numbers = new int[a, b];

                    for(int i = 0; i < a; i++)
                    {
                        for(int j = 0; j < b ; j++)
                        {
                            Console.Write("Enter matrix element for " + i + " x " + j + " : ");
                            int x = int.Parse(Console.ReadLine());
                            numbers[i, j] = x;

                        }
                    }
                    for(int i = 0; i < a; i++)
                    {
                        for(int j = 0; j < b; j++)
                        {
                            Console.Write("{0} ", numbers[i, j]);
                        }
                        Console.Write(Environment.NewLine + Environment.NewLine);
                    }
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        //Write a C# program which will accept a list of integers and checks how many integers are needed to complete the range
        public static void intList()
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    int ctr = 0;
                    Console.Write("Enter the size of your list: ");
                    int n = int.Parse(Console.ReadLine());
                    while (n <= 0)
                    {
                        Console.WriteLine("Please enter a positive integer: ");
                        n = int.Parse(Console.ReadLine());
                    }
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
                    for(int j = 0; j < n - 1; j++)
                    {
                        ctr += ordered[j + 1] - ordered[j] - 1;
                    }
                    Console.WriteLine("\nYou're missing " + ctr + " integer(s) for your consecutive list to be complete.");
                    finished = true;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        //Write a C# program to find the pair of adjacent elements that has the highest product of an given array of integers
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
        //Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers
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
        //Write a C# program to compute the sum of all the elements of an array of integers
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
        //Write a C# program to create a new string of every other character (odd position) from the first position of a given string
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
        //Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times
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
        //Write a C# program to find the largest and lowest values from three integer values
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
        //Write a C# program to check if a string starts with a specified word
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
        //Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7
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
        //Write a C# program to create a new string of four copies, taking last four characters from a given string. If the length of the given string is less than 4 return the original one
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
        //Write a C# program to multiply corresponding elements of two arrays of integers
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
        //Write a C# program to reverse the words of a sentence
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
        //Write a C# program and compute the sum of the digits of an integer
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
        //Write a C# Sharp program that takes four numbers as input to calculate and print the average
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
        //Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back
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
        //Write a C# program to check two given integers and return true if one is negative and one is positive
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
        //Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum
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
        //Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number
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
        //Write a C# program to find the longest word in a string
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
        //Write a C# program to print the odd numbers from 1 to 99
        public static void Odd()
        {
            Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
            for (int n = 1; n < 100; n++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n.ToString());
                }
            }

        }

    }

}

