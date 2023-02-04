using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İf_else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time>=6 && time<11)
            
                Console.WriteLine("Hayırlı Sabahlar Zehra!");
            
            else if (time<=18)
            
                Console.WriteLine("İyi günler!");
            
            else
            
                Console.WriteLine("İyi geceler!");

            string sonuc = time < 18 ? "İyi günler!" : "İyi geceler!";

            sonuc = time >= 6 && time < 11 ? "Hayırlı Sabahlar Zehra!" : time <= 18 ? "İyi günler!" : "İyi geceler!";
            Console.WriteLine(sonuc);
        }
    }
}
