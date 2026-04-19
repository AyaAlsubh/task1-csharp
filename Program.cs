using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name:");
            string name= Console.ReadLine();
            Console.WriteLine("Hello" + name);

            int age = 20;                      
            double price = 19.99;              
            char grade = 'A';                 
            bool isLoggedIn = true;          
            string address = "Amman, Jordan"; 
            float temperature = 36.5f;
            Console.WriteLine("age " + age);
            Console.WriteLine("price" + price);
            Console.WriteLine("grade  " + grade);
            Console.WriteLine("isLoggedIn " +  isLoggedIn);
            Console.WriteLine("address" +  address);
            Console.WriteLine("temperature" + temperature);





        }
    }
}
