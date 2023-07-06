using System;
using System.Collections.Generic; // generic classların oldugu namespace
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorduncuGunOdevler
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionaryClass<string, string> myDict = new MyDictionaryClass<string, string>();

            myDict.Add("player1", "abidin");
            myDict.Add("player2", "ahmet");
            myDict.Add("player3", "muhsin");
            myDict.Add("player4", "burak");
            myDict.Add("player5", "selahattin");



            // Testing Remove method 
            myDict.ListAllPairs();
            myDict.Remove("player3");
            myDict.Remove("player2");
            myDict.ListAllPairs();








            Console.ReadKey();
        }
    }
}
