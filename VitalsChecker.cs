using System;

public class VitalsChecker
{
     public static bool vitalsAreOk(float bpm, float spo2, float respRate) {
       return !(checkbpm(bpm)||checkspo2(spo2)||checkrespRate(respRate));
    }
    static bool checkbpm(float bpm)
    { 
         if(bpm < 70)
         {  
             Console.WriteLine("Low Beats Per Minute");
             return true;
         } 
         if( bpm > 150)
    {   Console.WriteLine("High Beats Per Minute");
        return true;
        
    }
    return false;

    }
    static bool checkspo2(float spo2)
    { 
         if(spo2 < 90)
         { Console.WriteLine("Low Oxygen Saturation");
         return true;
        
         }
         return false;
        
    }static bool checkrespRate(float respRate)
    { 
         if(respRate < 30)
         {
              Console.WriteLine("Low Respiration Rate");
            return true;
         } 
         if(respRate > 95)
         {
              Console.WriteLine("High Respiration Rate");
              return true;
         }
         return false;
            
    }
}
