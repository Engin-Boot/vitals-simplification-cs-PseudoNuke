using System;
using System.Diagnostics;
public class Expect
{
    public static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }   
    }
    public static void ExceptTrue(bool expression) {
         if(!expression) {
              Console.WriteLine("Expected true, but got false");
              Environment.Exit(1);
          }
      } 
 } 
