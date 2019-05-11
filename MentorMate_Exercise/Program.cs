using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorMate_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число отговарящо за дебелината на М: ");
            string input = Console.ReadLine();
            int N;
            while (!int.TryParse(input, out N))
            {
                Console.WriteLine("{0} не е цяло число, моля въведете ново число.", input);
                input = Console.ReadLine();
            }
            N = Int32.Parse(input);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("I", 0);
            dict.Add("II", 0);
            dict.Add("III", 0);
            int helper = 1;

                if (!int.TryParse(input, out N))
                {
                    Console.WriteLine("{0} не е цяло число", input);
                    dict["I"] = 1;
                }

                if (N <= 2 || N >= 10000)
                {
                    Console.WriteLine("Въведеното число не принадлежи на допустимите стойности, моля въведете ново число.");
                    dict["II"] = 1;
                }

                if (N % 2 == 0)
                {
                    Console.WriteLine("Въведеното число е четно, моля въведете ново число.");
                    dict["III"] = 1;
                }
                
            while(dict.ContainsValue(1))
            {
                dict["I"] = 0;
                dict["II"] = 0;
                dict["III"] = 0;
                input = Console.ReadLine();
               
                if (!int.TryParse(input, out N))
                {
                    Console.WriteLine("{0} не е цяло число", input);
                    dict["I"] = 1;
                }
                N = Int32.Parse(input);
                if (N <= 2 || N >= 10000)
                {
                    Console.WriteLine("Въведеното число не принадлежи на допустимите стойности, моля въведете ново число.");
                    dict["II"] = 1;
                }

                if (N % 2 == 0)
                {
                    Console.WriteLine("Въведеното число е четно, моля въведете ново число.");
                    dict["III"] = 1;
                }
            }

                Console.WriteLine(new String('-', N) + new String('*', N) + new String('-', N) + new String('*', N) + new String('-', 2 * N) + new String('*', N) + new String('-', N) + new String('*', N) + new String('-', N));
            for (int i = N-2; i >= 1; i=i-2)
            {
                Console.WriteLine(new String('-', N - helper) + new String('*', N + 2 * helper) + new String('-', N - 2 * helper) + new String('*', N + 2 * helper) + new String('-', 2 * N - 2 * helper) + new String('*', N + 2 * helper) + new String('-', N - 2 * helper) + new String('*', N + 2 * helper) + new String('-', N - helper));
                helper++;
            }
            int Localhelper = 0;
            for (int i = 1; i <= N; i=i+2)
            {
                
                Console.WriteLine(new String('-', N - helper) + new String('*', N) + new String('-', i) + new String('*', 2 * N - 1 - Localhelper) + new String('-', i) + new String('*', N) + new String('-', 2 * N - 2 * helper) + new String('*', N) + new String('-', i) + new String('*', 2 * N - 1 - Localhelper) + new String('-', i) + new String('*', N) + new String('-', N - helper));
                helper++;
                Localhelper = Localhelper + 2;
            }

            Console.Write("Continue? y/n: ");
            string ans = Console.ReadLine();
            if(ans=="n")
            {
                Console.WriteLine("Goodbye!");
                return;
            }
        }
    }
}
