using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTable Program");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            string hash5 = hash.Get("5");
            Console.WriteLine("The value of 5th index is: {0} ", hash5);
            string hash2 = hash.Get("2");
            Console.WriteLine("The value of 2nd index is: {0} ", hash2);
        }
    }
}
