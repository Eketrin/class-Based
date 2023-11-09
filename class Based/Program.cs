using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Based
{
    interface ITarget
    {
        void ClientDouble(double value);
        void ClientInt(int value);
        void ClientChar(char value);
    }
    class Based
    {
        public void BasedDouble(double input)
        {
            Console.WriteLine(input);
        }
        public void BasedlInt(int input)
        {
            Console.WriteLine(input);
        }
        public void BasedChar(char input)
        {
            Console.Write(input);
        }
    }
    class Client : ITarget
    {
        private Based based1;
        public Client()
        {
            based1 = new Based();
        }
        public void ClientDouble(double input)
        {
            based1.BasedDouble(input);
        }
        public void ClientInt(int input)
        {
            based1.BasedlInt(input*2);
        }
        public void ClientChar(char input)
        {
            for (int i = 0; i < 5; i++)
            {
                based1.BasedChar(input);
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new Client();
            target.ClientChar('a');
            target.ClientDouble(12.5);
            target.ClientInt(8);
            Console.WriteLine();
            Based based = new Based();
            based.BasedChar('b');
            Console.WriteLine();
            based.BasedDouble(12.5);
            based.BasedlInt(5);
            Console.ReadLine();
        }
    }
}
