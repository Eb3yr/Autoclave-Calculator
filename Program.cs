using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoclave
{
    class Program
    {
        static void Main(string[] args)
        {
            float numOfRegulars = 0;
            float numOfToolOut = 0;
            float WLout = 0;
            string[] toolArr = { "Sponge", "Splint", "Antiseptic", "Antibiotics", "Anaesthetic", "Scalpel", "Lab kit", "Clamp", "Pins", "Transfusion", "Ultrasound", "Defibrillator" };
            //Excluding stitch from toolArr to handle separately
            Dictionary<string, float> tools = new Dictionary<string, float>();

            foreach (string i in toolArr)
            {
                tools.Add(i, 0);
            }

            Console.Write("Input typical tool rate to buy (per WL): ");
            float buyRate = float.Parse(Console.ReadLine());
            Console.Write("Input typical tool rate to sell (per WL): ");
            float priceOfRegular = float.Parse(Console.ReadLine());
            Console.Write("Enter stitch rate (per WL): ");
            float priceOfStitch = float.Parse(Console.ReadLine());
            Console.Write("Input number of WLs in: ");
            int WLIn = int.Parse(Console.ReadLine());

            float addRate = (WLIn * buyRate) / 20;


            Console.WriteLine("\nTools given (ignore row for the tool claved, accounted for in the profit calc): \n");
            float profit = 0;
            foreach (string i in toolArr)
            {
                Console.WriteLine(i + ": " + addRate + " (" + (addRate / priceOfRegular) + " WLs)");
                profit += addRate / priceOfRegular;
            }
            Console.WriteLine("Stitch: " + WLIn + "(" + (WLIn / priceOfStitch) + " WLs)");
            profit += WLIn / priceOfStitch;

            profit -= addRate / priceOfRegular;
            Console.WriteLine("\nGross earnings: " + profit + "WLs");

            profit -= WLIn;
            profit = (float)Math.Round(profit, 3); //Making it look slightly less disgusting
            Console.WriteLine("\nThis gives " + profit + " WLs profit from " + WLIn + "WLs in");
            Console.WriteLine("\n(Note: You may need 13 vends to use to sell, which @ rate 2/9 is 59WL)");
            Console.ReadLine();
        }
    }
}
