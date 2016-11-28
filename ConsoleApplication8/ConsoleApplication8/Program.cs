using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome storyTime = new Welcome(false, "Jack", 15, false);
            
            Console.WriteLine();
            storyTime.WelcomeFirst();
            storyTime.WelcomeSecond();
            storyTime.SplitOne();
            Console.ReadKey();
        
            



        }
    }
}
