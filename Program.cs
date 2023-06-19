using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace Class03
{
    public class Program
    {
        static void Main(string[] args)
        {

            //product3Number();
            //AvgNumber();
            //Star();
            int[] arrayNumber = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 4, 5, 5, 5, 5, 5 ,8};
            string path = @"F:\asp\newApp\acas\Class03\words.txt";
            //Console.WriteLine(ArrayNum(arrayNumber));

            // Console.WriteLine(ArrayMax(arrayNumber));
            // WriteFile(path);
            // ReadWriteFile(path);
            // ReadFile(path);
            //SentenceLength();
            Console.Read();
            
        }
        public static int product3Number()
        {
            Console.Write("Please enter 3 numbers:");
            string input = Console.ReadLine();
            string[] inputs = input.Split(" ");
            if (inputs.Length < 3) {
                return 0;
            }
           
            int sum = 1;
            for (int i = 0; i < 3; i++)
            {
                sum *= int.Parse(inputs[i]);
            }
            Console.WriteLine("The product of these 3 numbers is: "+ sum);
                return sum;
           
        }
        public static int AvgNumber() 
        {
            Console.Write("Please enter a number between 2 - 10: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[num];
            int avg = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{i+1} of {num} - Enter a number: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
                avg += nums[i];
            }
            avg /= num;
            Console.WriteLine($"The average of these {num} numbers is: {avg}");
            return avg;

        }
        static void Star()
        {
            string[] s = {" "," ", " ", " ","*", " ", " ", " ", " " };
            string star = "*";
            string space = " ";
            string center = "*********";
            Console.WriteLine(string.Join("", s));
            for (int i =0; i < s.Length-1; i++)
            {
                if (i < 4) 
                { 
                s[5+i] = star;
                s[3-i] = star;
                }
                else
                {
                    s[i-4] = space;
                    s[12-i] = space;
                }
                Console.WriteLine(string.Join("",s));
            }
        }
        public static int ArrayNum(int[] arr)
        { 
            int count = 1;
            int max = 0;
            int ans=arr[0];
            foreach(int num in arr)
            {
                foreach(int num2 in arr)
                {
                    if (num2 == num)
                    {
                        count++;
                    }
                }
                if (count > max)
                {
                    max = count;
                    ans = num;
                }
                count = 1;
            }
            
            return ans;

        }
        public static int ArrayMax(int[] arr)
        {
            int max =arr[0];
            foreach (int num in arr)
            {
                if (num  > max)
                {
                    max = num;
                }
            }
            return max;

        }

        public static void WriteFile(string path)
        {
            
            Console.WriteLine("input Word :");
            string str = Console.ReadLine();
            File.WriteAllText(path, str);
        }
        public static void ReadFile(string path)
        {
            string ans= File.ReadAllText(path);
            Console.WriteLine(ans);
        }
        public static void ReadWriteFile(string path)
        {
             string[]words = File.ReadAllText(path).Split(" ");
            Console.WriteLine(File.ReadAllText(path));
            Console.WriteLine("input word you want remove");
            string input =Console.ReadLine();
            Console.WriteLine("input word you want add");
            string output =Console.ReadLine();
            for (int i=0; i<words.Length; i++)
            {
                if (words[i] == input)
                {
                    words[i] = output;
                }
            }
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            string add = string.Join(" ", words);
            File.WriteAllText(path, add);
        }
        public static string[] SentenceLength()
        {
            Console.WriteLine("input a sentence");
            string input= Console.ReadLine();
            string[] arr = input.Split(" ");

            string[] words = new string[arr.Length];
            for (int i=0; i<arr.Length;i++) 
            {
                words[i] = arr[i].ToLower() + ": " + arr[i].Length;
            }
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
            return words;
        }
    }
}