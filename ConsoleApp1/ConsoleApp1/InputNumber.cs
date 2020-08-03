namespace ConsoleApp1
{
    
    //Simple class to demonstrate input of simple number and show it
    public class InputNumber
    {
        private int Number;

        public InputNumber()
        {
            Number = 0;
        }

        public void SetNumber(int value)
        {
            Number = value;
        }

        public int GetNumber()
        {
            return Number;
        }
    }
}