using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace FuzzyLogic_FIS
{
    [ComVisible(true)]
    public class Program
    {
        
        public static double L1, L2, L3;
        public static double in1, in2, in3;
        public static Execute ex;
        public static string execute;

      
        public static void Main(string[] args)
        {

            while (execute != "n")
            { 
            Console.WriteLine("Enter input 1:");
            L1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter input 2:");
            L2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter input3:");
            L3 = Convert.ToDouble(Console.ReadLine());

            in1 = L1 - L2;
            in2 = L2 - L3;
            in3 = L3 - L1;

            ex = new Execute(in1, in2, in3);

            Console.WriteLine("input 1: " + in1);
            Console.WriteLine("input 2: " + in2);
            Console.WriteLine("input 3: " + in3);
           
             
            ex.KnowledgeBaseFuzzification(in1, in2, in3);
            ex.Inference();
            ex.Deffuzzification();

            Console.WriteLine("Do you want to continue?");
            execute = Console.ReadLine();

            }

        }

    }
}
