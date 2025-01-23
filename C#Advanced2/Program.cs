using System.Collections;
using System.Globalization;

namespace C_Advanced2
{
    internal class Program
    {
        public static int SumOfArray(ArrayList array)
        {
            int sum = 0;
            if (array != null)
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
            #region Methods of List
            //List<int> nums = new List<int>(5) {5, 1,2, 3, 4, 5 };
            ////nums.Insert(0, 100);
            ////nums.InsertRange(1, [101, 102, 103, 104, 105]);
            ////IReadOnlyList<int> ReadOnlynums=  nums.AsReadOnly();//can not make any change like add or update
            ////                                                    //but any change in base list reflect to it 
            ////nums.AddRange([6,7,8]);
            ////nums[0] = 0;
            ////foreach (int x in ReadOnlynums)
            ////{
            ////    Console.WriteLine(x);
            ////}
            //Console.WriteLine(value: $"Count:{nums.Count},Capacity:{nums.Capacity}");
            //nums.Clear();
            //Console.WriteLine(value: $"Count:{nums.Count},Capacity:{nums.Capacity}");

            //List<long> newNumbers = nums.ConvertAll<long>(N=>N);// Not Recommended
            //List<long> newNumbers = nums.Select<int,long>(N => N).ToList();//Return Interface Implement all Collection 

            //foreach (int n in newNumbers)
            //{
            //    Console.WriteLine(n);
            //}
            #region Bineary Search
            //int Index =nums.BinarySearch(4);
            //Index = nums.BinarySearch(10);//-6
            //Index = nums.BinarySearch(2);//-2
            //Console.WriteLine($"Index={Index}");
            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee(1,"Nada", 3000),
            //    new Employee(2,"Noura", 40000),
            //    new Employee(3,"Nour", 5000)
            //};
            //int Index = employees.BinarySearch(new Employee(5, "Radwa", 40000));
            //employees.Sort(new EmployeeComparerByName());
            //Index = employees.BinarySearch(new Employee(3, "Nour", 40000), new EmployeeComparerByName());
            //Index = employees.BinarySearch(1, 2, new Employee() { Name = "Nour" }, new EmployeeComparerByName());

            //Console.WriteLine($"Index={Index}"); 
            #endregion
            #region Copy
            //int[] Arr = new int[10];
            //nums.CopyTo(Arr);
            //nums.CopyTo( Arr, 5 );
            //nums.CopyTo(2, Arr, 2, 3);
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Console.WriteLine(Arr[i]);
            //} 
            #endregion
            #region FindMethods
            //int FirstEvenNumbers = nums.Find(N => N % 2 == 0);
            //int Index = nums.FindIndex(N => N % 2 == 0);
            //int LastEvenNumbers = nums.FindLast(N => N % 2 == 0);
            //int lastIndex = nums.FindLastIndex(N => N % 2 == 0);
            //List<int> EvebNumbers = nums.FindAll(N => N % 2 == 0);

            #endregion
            #region Index
            //bool isExist = nums.Exists(N => N % 2 == 0);
            //nums.TrueForAll(N => N % 2 == 0);
            //nums.ForEach(N =>
            //{
            //    N += 100;
            //    Console.WriteLine(N);
            //});
            //for (int i = 0; i < nums.Count; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //List<int> Numbers01 = nums.GetRange(0, 3);
            //List<int> Numbers02 = nums.Slice(0, 3);
            //Console.WriteLine(nums.IndexOf(3));
            //Console.WriteLine(nums.IndexOf(3, 1));
            //Console.WriteLine(nums.IndexOf(5, 1, 2));

            //Console.WriteLine(nums.LastIndexOf(3));
            //Console.WriteLine(nums.LastIndexOf(3, 1));
            //Console.WriteLine(nums.LastIndexOf(5, 1, 2)); 
            #endregion



            #endregion
            #region Generic Collection Linked List
            //Double Linked List
            //LinkedList<int> Numbers = new LinkedList<int>();
            //LinkedListNode<int> FirstNode = Numbers.AddFirst(1);
            //LinkedListNode<int> FourthNode = Numbers.AddLast(value: 4);
            //Numbers.AddAfter(FirstNode, 2);
            //Numbers.AddBefore(FourthNode, 3);
            //Console.WriteLine(FirstNode.Next.Value);//2
            #endregion

        }
    }
   
}
