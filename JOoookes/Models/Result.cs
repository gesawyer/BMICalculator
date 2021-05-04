using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JOoookes.Models
{
    public class Result
    {
        public int feet { get; set; }
        public int inches { get; set; }
        public int weight { get; set; }
        public int bmi { get; set; }

        public string CalculateBMI(int f, int i, int w)
        {

            float totalHeight = (float)((f * 12 + inches)*0.0254);
            float kgWeight = (float)(w * 0.453592);
            float bmiFinal = (kgWeight / totalHeight) * (kgWeight / totalHeight);
            string bmiStatus;
            
            
            if(bmiFinal <= 18.5)
            {
                bmiStatus = "underweight!";
            }
            if (bmiFinal >= 18.5 && bmiFinal <= 24.9)
            {
                bmiStatus = "healthy!";
            }
            if (bmiFinal >= 25 && bmiFinal <= 29.9)
            {
                bmiStatus = "overweight!";
            }
            if (bmiFinal >= 30 && bmiFinal <= 39.9)
            {
                bmiStatus = "obese!";
            }
            string message = "Your body mass index is" + bmiFinal + "which means you are";  //+ bmiStatus;
            return message;
        }
       
    }

    
}
