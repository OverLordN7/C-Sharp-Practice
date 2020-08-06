using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    //Arithmetic expressions task 1-13
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            //Task 1
            Pre100 obj = new Pre100(100.789);
            obj.Show();
            */
            
            /*
            //task 2
            InputNumber obj = new InputNumber();
            obj.SetNumber(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("You entered: "+ obj.GetNumber());
            */
            
            /*
            //Task 3 
            int year = 2019;
            int month = 8;
            int day = 5;
            DateTime obj = new DateTime(year,month,day);
            
            Console.WriteLine(obj.DayOfWeek.ToString());
            */
            
            /*
            //Task 4
             MyQueue obj = new MyQueue();
                obj.Push(5);
                int param_2 = obj.Pop();
                int param_3 = obj.Peek();
                bool param_4 = obj.Empty();
                */
            

            /*
            //Task 5
            int n = 64;
            bool Success = false;
            if(n==1){
                Success =  true;
            }
            else{
                if(n%2 !=0){
                    Success = false;
                }
                else{
                    while(n>=2){
                        Console.WriteLine(n);
                        if(n%2 != 0){Success = false;break;}
                        if(n==2){Success = true;}
                        n/=2;
                    }
                    Console.WriteLine(Success);
                }
            
            }
            */

            /*
            //Task 6
            string dna = "TTTT";
            char[] DNA = dna.ToCharArray();
            string FDNA = "";

            for (int i = 0; i < DNA.Length; i++)
            {
                switch (DNA[i])
                {
                    case 'T':
                    {
                        DNA[i] = 'A';
                        break;
                    }
                    case 'A':
                    {
                        DNA[i] = 'T';
                        break;
                    }
                    case 'C':
                    {
                        DNA[i] = 'G';
                        break;
                    }
                    case 'G':
                    {
                        DNA[i] = 'C';
                        break;
                    }
                }
            }

            FDNA =  new string(DNA);
            
                
            Console.WriteLine(dna);
            Console.WriteLine(FDNA);
            */
            
            
            
        }
    }
}