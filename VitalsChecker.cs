using System;
using System.Diagnostics;
namespace Vitals{
    
    class VitalsChecker
    {
        static bool vitalsAreOk(float bpm, float spo2, float respRate) {
            var bpm_check = (bpm < 70 || bpm > 150);
            var spo2_check = (spo2 < 90);
            var respRate_check = (respRate < 30 || respRate > 95);
            if( bpm_check || spo2_check || respRate_check )
                return false;
            return true;
        }
    }   
}
