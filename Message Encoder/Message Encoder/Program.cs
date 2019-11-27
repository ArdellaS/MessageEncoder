using System;
using System.Text;

namespace Message_Encoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your message? ");
            string input = Console.ReadLine().ToUpper();
            
                     
            UTF32Encoding encoding = new UTF32Encoding();
            byte[] bytes = encoding.GetBytes(input);
            
            double checkSum = 0.0;
            
            Console.Write("Your encoded message is: ");
            for (int i = 0; i < bytes.Length; i += sizeof(int))
            {
                double num = BitConverter.ToInt32(bytes, i) - 64;
              Console.Write($"{num}-");
                checkSum += num;                   
            }

            Console.WriteLine($"\nMessage checksum is: {checkSum}");
            
            
        }
       
    }
}
