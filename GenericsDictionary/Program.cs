using System;

namespace GenericsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Ali", "Veli");
            myDictionary.Add("Hasan", "Hüseyin");

            myDictionary.GetAll();
        }
    }
}
