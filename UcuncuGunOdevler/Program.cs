using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcuncuGunOdevler
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "a";
            string name2 = "b";
            string name3 = "c";
            string name4 = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";

            byte[] bytes_name1 = Encoding.ASCII.GetBytes(name1);
            int evenParityBit=CalculateEvenParity(ref bytes_name1); // ref keyworduyle parametre pass ( pass by reference )


            // 10 bayttan buyuk veri hata veriyor.
            //byte[] bytes_name4 = Encoding.ASCII.GetBytes(name4);
            //int evenParityBit = CalculateEvenParity(ref bytes_name4); // ref keyworduyle parametre pass ( pass by reference )


            Console.WriteLine("Event Parity Bit:"+evenParityBit.ToString());


            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            byte[] bytes_name2 = Encoding.ASCII.GetBytes(name2);
            int oddParityBit = CalculateOddParity(ref bytes_name2);
            Console.WriteLine("Odd Parity Bit:" + oddParityBit.ToString());

            Console.ReadKey();


        }


        // default parameterli ve ref keyworduyle methos kullanımı
        static int CalculateEvenParity(ref byte[] sampleByte , int MAX_LENGTH = 10)
        {
            byte parityBit;
            byte lastBit;
            int countOnes = 0;



            if ( !(sampleByte.Length > MAX_LENGTH) )

            {
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < sampleByte.Length; j++)
                    {

                        byte sample = (byte)(sampleByte[j] >> i);
                        lastBit = (byte)(sample & 0x01);

                        if (lastBit ==1)
                            countOnes++;

                        Console.WriteLine("Sequence: " + Convert.ToString(sample, 2));  
                        Console.WriteLine("Last bit: "+Convert.ToString(lastBit,2));
                        Console.WriteLine("-----------------------------------");

                    }
                }



                return countOnes%2;

            }

            else
            {
                Console.WriteLine("Input is larger than 10 bytes !");
                return 0;
            }

        }

        static int CalculateOddParity(ref byte[] sampleByte, int MAX_LENGTH = 10)
        {
            byte parityBit;
            byte lastBit;
            int countOnes = 0;


            if (!(sampleByte.Length > MAX_LENGTH))

            {
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < sampleByte.Length; j++)
                    {

                        byte sample = (byte)(sampleByte[j] >> i);
                        lastBit = (byte)(sample & 0x01);

                        if (lastBit == 1)
                            countOnes++;

                        Console.WriteLine("Sequence: " + Convert.ToString(sample, 2));
                        Console.WriteLine("Last bit: " + Convert.ToString(lastBit, 2));
                        Console.WriteLine("-----------------------------------");

                    }
                }



                return 1-countOnes % 2;

            }

            else
            {
                Console.WriteLine("Input is larger than 10 bytes !");
                return 0;
            }

        }



    }
}
