using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            // Musteriyi olusturduk bu musteri objesiyle MusteriManager classından obje olusturacagiz
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Abidin Can";
            musteri1.Soyad = "Ozgirgin";
            musteri1.Id = 12;
            musteri1.TcNo = 123456;

            //MusteriManager 

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriDogrula(musteri1);








        }
    }
}
