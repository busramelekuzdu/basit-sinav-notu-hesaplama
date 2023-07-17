using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavNotu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vize, final;
            double sonuc;
            Console.Write("Vize notunu giriniz:");
            vize= Convert.ToInt32(Console.ReadLine());

            Console.Write("Final notunuz:");
            final= Convert.ToInt32(Console.ReadLine());

            sonuc = final * 0.7 + vize * 0.4;

            if (sonuc < 50)
                Console.WriteLine("Ortalamanız:"+sonuc+" Sınavdan kaldınız.");
            else
                Console.WriteLine("Ortalamanız:" + sonuc + " Sınavdan geçtiniz.");

            Console.ReadLine();
        }
    }
}
