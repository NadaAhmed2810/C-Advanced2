using System.Collections.Immutable;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.
            //int sz, NumberofQuery;
            //bool f =false;
            //do
            //{
            //    Console.WriteLine("Enter the Size Of Array:");
            //    f = int.TryParse(Console.ReadLine(), out sz);
            //} while (!f && sz<0);
            //f=false;
            //do
            //{
            //    Console.WriteLine("Enter the Number Of query :");
            //    f = int.TryParse(Console.ReadLine(), out NumberofQuery);
            //} while (!f && NumberofQuery > 0);
            //List<int> Numbers = new List<int>(sz);
            //List<int> Queries = new List<int>(NumberofQuery);
            //List<int> Answers = new List<int>(NumberofQuery);



            //for (int i = 0; i < sz; i++) {
            //    Console.WriteLine(value: $"Enter Element{i+1}:");
            //    int x=int.Parse(Console.ReadLine());
            //    Numbers.Add(x);
            //}
            //Numbers.Sort();
            //for (int i = 0; i < NumberofQuery; i++)
            //{
            //    Console.WriteLine(value: $"Enter Query{i + 1}:");
            //    int x = int.Parse(Console.ReadLine());
            //    Queries.Add(x);

            //    Answers .Add(Numbers.Count(N=>N>x));
            //}
            //for (int i = 0; i < Answers.Count; i++)
            //{
            //    Console.WriteLine(Answers[i]);
            //}



            #endregion
            #region Q2: Given a number N and an array of N numbers. Determine if it's palindrome or not.
            // int sz;
            // bool f = false;
            // do
            // {
            //     Console.WriteLine("Enter the Size Of Array:");
            //     f = int.TryParse(Console.ReadLine(), out sz);
            // } while (!f && sz <0);
            // List<int> Numbers = new List<int>(sz);
            // for (int i = 0; i < sz; i++)
            // {
            //     Console.WriteLine(value: $"Enter Element{i + 1}:");
            //     int x = int.Parse(Console.ReadLine());
            //     Numbers.Add(x);
            // }
            //int[] arr=new int[sz];
            // Numbers.CopyTo(arr);
            // Numbers.Reverse();  
            // f = false;
            // for (int i = 0;i < sz; i++)
            // {
            //     if (arr[i] != Numbers[i])f=true;
            // }
            // if (f)
            // {
            //     Console.WriteLine("No");
            // }
            // else Console.WriteLine("Yes");
            #endregion
        }
    }
}
