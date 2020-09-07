using System;
using System.Diagnostics;

class Checker
{
    static int Main() {
        Expect.ExpectTrue(VitalsChecker.vitalsAreOk(100, 95, 60)); //(1,1,1,)
        Expect.ExpectFalse(VitalsChecker.vitalsAreOk(40, 91, 92)); //(0,1,1)
        Expect.ExpectFalse(VitalsChecker.vitalsAreOk(151, 92, 94)); //(0,1,1)
        Expect.ExpectFalse(VitalsChecker.vitalsAreOk(72, 80, 92));  //(1,0,1)
        Expect.ExpectFalse(VitalsChecker.vitalsAreOk(80, 92, 20)); //(1,1,0)
        Expect.ExpectFalse(VitalsChecker.vitalsAreOk(80, 92, 100)); //(1,1,0)
	Expect.ExpectTrue(VitalsChecker.vitalsAreOk(70, 92, 95));  //(1,1,1)
	Expect.ExpectTrue(VitalsChecker.vitalsAreOk(150, 90, 30));  //(1,1,1)

        Console.WriteLine("All ok");
        return 0;
    }
}
