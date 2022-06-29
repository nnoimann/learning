using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    class Program
    {
        static void Main(string[] args)
        {
  
                string a;
                string b;
                string c;
                a = Console.ReadLine("Enter a:");
                b = Console.ReadLine("Enter b:");
                c = a;
                
                Console.WriteLine(a = b);
                Console.WriteLine(b = a);
            
        }
    }
}
