using System;

//ref link:https://www.youtube.com/watch?v=0ILfp7cVE7g&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=16
// C# --CSC--> MSIL --JIT--> Machine Languange
//  MSIL(MS intermidiate langauge) - boxing/unboxing
//  Machine Languange - Stack/Heap

//  Heap -> 2 extra datamembers -- 1. sync block index - required threading knowledge , 2. type object pointer - requires reflection knowledge

class MainClass
{
    static void Main()
    {   // int -> System.Int32
        object o = 5;
        Type t = o.GetType();   // type object pointer
        Console.WriteLine(t.Name);  //Output: Int32    - type object pointer
        Console.WriteLine(t.Namespace); //Output: System   - type object pointer
    
        5.ToString();
        5.GetType();
    }
}