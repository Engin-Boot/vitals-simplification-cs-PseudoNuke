using System;
using System.Diagnostics;

namespace Vitals
{
    class ExpectTrue
    {
        static void ExceptTrue(bool expression){
              if(!expression) {
                  Console.WriteLine("Expected true, but got false");
                  Environment.Exit(1);
                  }
          }
      }
 }
                  
