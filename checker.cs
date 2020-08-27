using System;

namespace Vitals
{
  class Checker
  {
    static int Main()
    {
            Expect.ExpectTrue(VitalsChecker.vitalsAreOk(100, 95, 60));
            Expect.ExpectFalse(VitalsChecker.vitalsAreOk(40, 91, 97));
            Expect.ExpectFalse(VitalsChecker.vitalsAreOk(151, 92, 94));
            Console.WriteLine("All ok");
            return 0;
    }
  }
}            
