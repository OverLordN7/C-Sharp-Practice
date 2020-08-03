using System;

namespace ConsoleApp1
{
    
    //Class which converts double number to a double with precision to the nearest hundredths.
    public class Pre100
    {
        
        double FNumber;
        double SNumber;

        public Pre100(double value)
        {
            this.FNumber = value;
            this.SNumber = Math.Round(FNumber, 2);
        }
        public void Show()
        {
            Console.WriteLine("First number: "+FNumber);
            Console.WriteLine("First number with precision: "+SNumber);  
        }
    }
}