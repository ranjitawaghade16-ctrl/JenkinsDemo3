using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsDemo3
{
    internal class Program
    {
        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public int Multi(int a, int b)
        {
            int c = a * b;
            return c;
        }

        public int Div(int a, int b)
        {
            int c = a / b;
            return c;
        }


        static void Main(string[] args)
        {
            Program program = new Program();
            program.Add(10, 20);
            program.Multi(10, 30);
            program.Div(10, 40);
            
        }
    }
}
