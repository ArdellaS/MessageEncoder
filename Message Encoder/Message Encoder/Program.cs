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
            string message = "Your encoded message is: ";
            Console.Write(message);
            for (int i = 0; i < bytes.Length; i += sizeof(int))
            {
                double num = BitConverter.ToInt32(bytes, i);
                double codedNum = num - 64;
              Console.Write($"{codedNum}-");
                checkSum += num;                   
            }

            Console.WriteLine($"\nMessage checksum is: {checkSum}");
            
            
        }
       
    }
}
