using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Assignment
{
    internal class Program
    {
        static void ReverseQueue(Queue<int> queue)
        {
           
            Stack<int> stack = new Stack<int>();

          
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
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
            #region Q3: Given a Queue, implement a function to reverse the elements of a queue using a stack.
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //ReverseQueue(queue);
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q4:Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
            //Console.WriteLine("Enter the string:");
            //string s=Console.ReadLine();
            //Stack<char> stack = new Stack<char>();
            //bool f = true;
            //for(int i = 0; i < s.Length; i++)
            //{
            //    if (s[i]=='(' || s[i]=='{' || s[i] == '[') stack.Push(s[i] );
            //    else if (s[i] == ')' || s[i] == '}' || s[i] == ']')
            //    {

            //        if (stack.Count == 0)
            //        {
            //           f=false;
            //        }
            //        char c = stack.Pop();
            //        f= (c == '(' && s[i] == ')') ||
            //        (c == '{' && s[i] == '}') ||
            //          (c == '[' && s[i] == ']');
            //    }
            //    else if(f==false) break;


            //}
            //if (f && stack.Count==0) Console.WriteLine("Yes");
            //else Console.WriteLine("No");

            #endregion
            #region Q5
            //List<int> list = new List<int>(10) {1,1,1,6,9,8,4,4,6,8};
            //for (int i = 0; i < list.Count; i++)
            //{
            //    for (int j = i + 1; j < list.Count; j++)
            //    {

            //        if (list[i].Equals(list[j]))
            //        {
            //            list.RemoveAt(j);
            //            j--;
            //        }
            //    }
            //}
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Q6
            //List<int> list = new List<int>(5) {1,2,3,4,5 };
            //list.RemoveAll(item => (int)item % 2 != 0);
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q7
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2.9);
            //queue.Enqueue("Apple");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q8
            //Stack<int>st = new Stack<int>();
            //st.Push(42);
            //st.Push(43);
            //st.Push(60);
            //st.Push(10);
            //st.Push(20);
            //st.Push(30);
            //Console.WriteLine("Enter the target integer to search for:");
            //int target = int.Parse(Console.ReadLine());
            //int Count = 0;
            //bool f= false;
            //while (st.Count > 0)
            //{
            //    int current = st.Pop();
            //    Count++;

            //    if (current == target)
            //    {
            //        Console.WriteLine($"Target was found successfully and the count = {Count}");
            //        f = true;
            //        break;
            //    }
            //}

            //if(!f)Console.WriteLine("Target was not found");
            #endregion
            #region Q9
            //List<int> list = new List<int>(5) { 1, 2, 3, 4, 4 };
            //List<int> list02 = new List<int>(3) { 10, 4, 4 };
            //List<int>Result=new List<int>();

            //foreach(int i in list)
            //{
            //    if (list02.Contains(i))
            //    {
            //        Result.Add(i);
            //        list02.Remove(i);
            //    }
            //}

            //foreach (int i in Result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Q10
            //List<int> list = new List<int>() { 1, 2, 3, 7, 5 };
            //bool f = false;
            //int target = 12;
            //for(int i = 1; i < 5; i++)
            //{
            //    if (list[i] == target)
            //    {
            //        f=true;
            //        break;
            //    }
            //    list[i] += list[i - 1];
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = i; j < 5; j++)
            //    {
                   
            //        int Sum = (i == 0) ? list[j] : list[j] - list[i - 1];

            //        if (Sum == target)
            //        {
            //            f= true;
            //        }
            //    }
            //}
            //if (f) Console.WriteLine("Yes");
            //else Console.WriteLine("False");
            #endregion
        }
    }
}
