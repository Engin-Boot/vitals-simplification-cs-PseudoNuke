using System;

namespace Vitals
{
  class Test
  {
    static int Main()
    {
            Expect.ExpectTrue(VitalsChecker.vitalsAreOk(100, 95, 60));
            Expect.ExpectFalse(VitalsChecker.vitalsAreOk(40, 91, 97));
            Expect.ExpectFalse(VitalsChecker.vitalsAreOk(151, 92, 94));
            Expect.ExpectFalse(VitalsChecker.vitalsAreOk(60, 92, 20));
            Expect.ExpectTrue(VitalsChecker.vitalsAreOk(70, 101, 94));
            Expect.ExpectTrue(VitalsChecker.vitalsAreOk(150, 120, 75));
            Expect.ExpectFalse(VitalsChecker.vitalsAreOk(80, 92, 127));
            Expect.ExpectFalse(VitalsChecker.vitalsAreOk(101, 100, 135));
            Console.WriteLine("All ok");
            return 0;
    }
  }
}            
