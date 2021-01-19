using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            matematik mat = new matematik();
            mat.selamVer();
            mat.Topla(15,56);
            mat.kareAl(5);

            int sonuc = mat.kareDondur(5);//işlemi yapıp sonuc un içine atar.
            Console.WriteLine(sonuc);

            mat.usAl(5, 2);

            Console.WriteLine(mat.buyukOlan(157,300));
            

        }
    }
    class matematik
    {
        public void selamVer()
        {
            Console.WriteLine("selam");
        }
        public void Topla(int s1,int s2)
        {
            int toplam = s1 + s2;
            Console.WriteLine(toplam);
        }
        public void kareAl(int s1)
        {
            int kare = s1 * s1;
            Console.WriteLine(kare);
        }
        public int kareDondur(int s1)
        {
            int kare = s1 * s1;
            return kare;
        }
        //üs alan metot
        public void usAl(int s1,int s2)
        {
            for (int i = 1; i < s2; i++)
            {
                s1 *= s1;
            }
            Console.WriteLine(s1);
        }
        //alınan 2 sayıdan büyük olanı döndüren metot
        public int buyukOlan(int s1,int s2)
        {
            int buyukSayi = 0;
            if (s1 > s2)
                buyukSayi = s1;
            else
                buyukSayi = s2;
            return buyukSayi;
            //return e bir kere geldiğinde metotdan çıkar. iki kere return döndürmez.
        }
    }

}
