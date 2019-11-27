using System;

namespace Message_Encoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the message you would like coded: ");
            string input = Console.ReadLine().ToUpper();
            Console.WriteLine(input);
                      
            System.Text.UTF32Encoding encoding = new System.Text.UTF32Encoding();
            byte[] bytes = encoding.GetBytes(input);

            for (int i = 0; i < bytes.Length; i += sizeof(int))
            {
                Console.WriteLine(BitConverter.ToInt32(bytes, i-64));
            }


            //string message = "Your encoded message is: " + Code(input);

            double checkSum;

        }
        public void Code(string input)
        {

        }

    }
}
