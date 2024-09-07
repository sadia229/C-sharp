using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            int myInt = 5;             
            double myDoubleNum = 5.99D; 
            bool myBool = true;          
            string myText = "Hello"; 
            double converted ;
            int convertedInt ; 

            converted = Convert.ToDouble(myInt);
            convertedInt = (int)Math.Round(myDoubleNum);
            
            Console.WriteLine("Hello world!");
            Console.WriteLine("sum: " + (myInt + myDoubleNum));

            Console.WriteLine("string number: " + (myInt + myDoubleNum));
            Console.WriteLine("converted double: " + converted);
            Console.WriteLine("converted int: " + convertedInt);
            Console.WriteLine("converted String: " + myInt.ToString());
            
        }
    }
}