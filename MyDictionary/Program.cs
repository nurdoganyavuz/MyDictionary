using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

            myDictionary.Add("Böğürtlen", 40);
            myDictionary.Add("Ananas", 50);
            myDictionary.Add("Armut", 60);
            myDictionary.Add("Karpuz", 30);
            myDictionary.Add("Nar", 80);

            myDictionary.GetAll();
        }
    }
}