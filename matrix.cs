/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;


namespace Sandbox  
{  
  public class Program  
  {  
    //public static int[,] numbers = { {0, 0, 0}, {0, 0, 0}, {0, 0, 0} };
    public static int[,] numbers;
    static void gen()
    {
      int n = Convert.ToInt32(Console.ReadLine());
      numbers = new int [n,n];
      Random rnd = new Random();

      for (int i = 0; i < numbers.GetLength(0); i++) 
      { 
        for (int j = 0; j < numbers.GetLength(1); j++) 
        { 
          numbers[i, j] = rnd.Next(0, 5); 
        } 
      } 
    }
    
    static void show()
    {
      for (int i = 0; i < numbers.GetLength(0); i++) 
      { 
        for (int j = 0; j < numbers.GetLength(1); j++) 
        { 
          Console.Write(numbers[i, j] + " "); 
        } 
        Console.WriteLine();
      }  
    }
    
    static void checkK()
    {
        for (int i = 0; i < numbers.GetLength(1); i++)
        {
            bool hasZero = false;
    
            for (int j = 0; j < numbers.GetLength(0); j++)
            {
                if (numbers[j, i] == 0)
                {
                    hasZero = true;
                    break; 
                }
            }
            if (!hasZero)
            {
                Console.WriteLine(i);
            }
        }
    }
    
    static void checkKSum()
    {
        List<int> arr = new List<int>();
        int sum = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                sum = sum + numbers[i, j];
            }
            arr.Add(sum);
            sum = 0;
        }
        
        int max = arr[0];
        int cntIndex = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
                cntIndex = i;
            }
        }
        
        Console.WriteLine("sum index " + cntIndex);
    }
    
    static void Main(string[] args)  
    {  
      // --------------------------------  
      gen();
      show();
      checkK();
      checkKSum();
    }
  } 
}