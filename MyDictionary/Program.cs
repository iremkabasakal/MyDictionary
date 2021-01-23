using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> SehirleriYaz = new MyDictionary<string, string>();

            SehirleriYaz.Add("06", "Ankara");
            SehirleriYaz.Add("34", "İstanbul");
            SehirleriYaz.Add("35", "İzmir");

            SehirleriYaz.sehirler();

        }
    }

}
