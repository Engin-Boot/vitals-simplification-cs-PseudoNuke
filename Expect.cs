using System;
using System.Diagnostics;
class Expect
{
    static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }   
    }
    static void ExceptTrue(bool expression) {
         if(!expression) {
              Console.WriteLine("Expected true, but got false");
              Environment.Exit(1);
          }
      } 
 } 
