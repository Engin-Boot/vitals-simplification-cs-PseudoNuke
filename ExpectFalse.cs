using System;
using System.Diagnostics;


namespace Vitals
{

        class ExpectFalse
        {
                
                static void ExpectFalse(bool expression)
                {
                        if(expression) {
                                
                                 Console.WriteLine("Expected false, but got true");
                                 
                                 Environment.exit(1);
                                 
                        }
                 
                 }
 
        }

}
