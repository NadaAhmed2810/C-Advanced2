using System.Collections;

namespace C_Advanced2
{
    internal class Program
    {
        public static int SumOfArray(ArrayList array)
        {
            int sum = 0;
            if(array != null) 
                for (int i = 0; i < array.Count; i++)
                {
                    sum += (int?)array[i] ?? 0;//Casting from [ReferenceType] to [ValueType]
                                               //unboxing [unsafe] 
                                               //Compiler Can not unforce Type Safety

                }
            return sum;
        }
        static void Main(string[] args)
        {
            #region Non_Generic_Collection_ArrayList

            #region Constructors
            ////Boxing and un Boxing 
            //ArrayList Numbers = new ArrayList();
            //Console.WriteLine($"Count:{Numbers.Count},Capacity:{Numbers.Capacity}");
            //Numbers.Add(1);
            //Numbers.Add(2);
            //Numbers.AddRange(new int[] { 3, 4 });
            //Console.WriteLine(value: $"Count:{Numbers.Count},Capacity:{Numbers.Capacity}");
            //Numbers.Add(5);
            //Console.WriteLine(value: $"Count:{Numbers.Count},Capacity:{Numbers.Capacity}");
            //Numbers.TrimToSize();
            //Console.WriteLine("____After Trim____");
            //Console.WriteLine(value: $"Count:{Numbers.Count},Capacity:{Numbers.Capacity}");


            ////overloading Constructor take the Capacity
            //ArrayList Numbers01 = new ArrayList(9) { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(value: $"Count:{Numbers01.Count},Capacity:{Numbers01.Capacity}");

            ////overloading Constructor take object From Class Implement ICollection 
            //int[] Arr = { 1, 2, 3, 5, 6, 7, 8, 9 };
            //ArrayList Numbers02 = new ArrayList(Arr); 
            #endregion

            #region Improve Double of Capacity
            //ArrayList Numbers = new ArrayList(5) { 1, 2, 3, 4, 5 };
            ////Numbers[5] = 6;// index Out Of Range Can not Access Index<0 || Index >= Count 
            ////Numbers[3] = 7; //Can make get or set in Index in Range 0 to Count -1

            //Console.WriteLine(value: $"Count:{Numbers.Count},Capacity:{Numbers.Capacity}");
            ////Numbers.EnsureCapacity(21);
            ////here i do 3 copy to array and will have 19 element extra

            //// But I Can Do this 
            //if (Numbers.Capacity < 21)
            //{
            //    Numbers.Capacity = 21;
            //}
            //for (int i = 6; i <= 21; i++)
            //{
            //    Numbers.Add(i);
            //}
            //Console.WriteLine(value: $"Count:{Numbers.Count},Capacity:{Numbers.Capacity}"); 
            #endregion



            #endregion
            #region Problems in NonGenericCollection
            //ArrayList Numbers= new ArrayList();
            //Numbers.Add(1);//Casting from int[ValueType] to object [Reference type]==>Boxing
            //int result=SumOfArray(Numbers);
            //Console.WriteLine($"Result:{result}");

            #endregion
            #region Generic Collection List
           // List<int> Numbers = new List<int>();
            //Console.WriteLine($"Count:{Numbers.Count},Capacity:{Numbers.Capacity}");
            //Numbers.Add(1);
            //Numbers.Add(2);
            //Numbers.AddRange(new int[] { 3, 4 });
            //Console.WriteLine(value: $"Count:{Numbers.Count},Capacity:{Numbers.Capacity}");
            //Numbers.Add(5);
            //Console.WriteLine(value: $"Count:{Numbers.Count},Capacity:{Numbers.Capacity}");
            //Numbers.TrimExcess();
            //Console.WriteLine("____After Trim____");
            //Console.WriteLine(value: $"Count:{Numbers.Count},Capacity:{Numbers.Capacity}");
            //List<int> Numbers01 = new List<int>(5) { 1,2,3,4,5};
            //Console.WriteLine($"Count:{Numbers01.Count},Capacity:{Numbers01.Capacity}");
            //Numbers01.Add(6);
            //Numbers01.Add(7);
            //Numbers01.AddRange([8, 9,10]);
            //Console.WriteLine(value: $"Count:{Numbers01.Count},Capacity:{Numbers01.Capacity}");
            //Numbers01.Add(11);
            //Console.WriteLine(value: $"Count:{Numbers01.Count},Capacity:{Numbers01.Capacity}");
            //int[] arr = [1,2,3,4,5,6];
            //List<int>Numbers02 = new List<int>(arr);
            //Console.WriteLine(value: $"Count:{Numbers02.Count},Capacity:{Numbers02.Capacity}");
            //Numbers02.EnsureCapacity(21);
            //for(int i =7 ; i<= 21; i++)
            //{
            //    Numbers02.Add(i);
            //}

            #endregion


        }
    }
}
