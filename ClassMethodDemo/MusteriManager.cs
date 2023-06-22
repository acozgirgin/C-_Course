using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    public class MusteriManager
    {


        private Musteri _girisYapanMusteri;
        private int _islemSec;

        private static List<int> _IdDataBase = new List<int>();
        private static List<long> _tcNoDataBase = new List<long>();




        // parameteleri Musteri classından verdik bilgiyi olabildigince saklıyoruz : ENCAPSULATION
        // daha sonra degisiklik yapmak istersek daha az satır kod ile islemimizi gerceklestirebiliriz.
        // Direkt Musteri classına yeni propertyler ekleyebiliriz.
        // Daha sonra MusteriManager classında methodları guncelleyerek kodun diger kısımlarında degisiklik yapmamıza gerek kalmaz.


        // default constructor
        public MusteriManager()
        {
            Console.WriteLine("ABC Bankasına Hosgeldiniz.");

        }

        // static constructor databasede olacak verileri doldurmak icin olusturuldu.
        static MusteriManager()
        {
            // DataBase icerisine musteri Idleri ve Tc kimlik numaraları dolduralacak
         
            for (int i=0; i<15; i++)
            {

               _IdDataBase.Add(i);
            }

            for (int i = 123456; i < 123480; i++)
            {

                _tcNoDataBase.Add(i);
            }

        }


        public bool MusteriDogrula(Musteri musteri)
        {

            this._girisYapanMusteri = musteri;
            bool isTcNoCorrect = _tcNoDataBase.Contains(_girisYapanMusteri.TcNo);
            bool isIdCorrect = _IdDataBase.Contains(_girisYapanMusteri.Id);

            if(isIdCorrect & isTcNoCorrect)
            {
                GirisYap();
                return true;
            }

            else
            { 
                if(!isTcNoCorrect)
                {
                    Console.WriteLine("TcNo hatali girildi tekrar deneyiniz !");
                    Console.ReadKey();
                }

                else
                {

                    Console.WriteLine("Id hatali girildi tekrar deneyiniz !");
                    Console.ReadKey();


                }
                return false;

            }



        }
        public void GirisYap()
        {

            Console.WriteLine("Merhaba "+ _girisYapanMusteri.Ad + " Bey");
            Console.WriteLine("Lutfen yapmak istediginiz islemi seciniz.");
            string inputIslem = Console.ReadLine();
            this._islemSec = Convert.ToInt32(inputIslem);


        }














    }
}
