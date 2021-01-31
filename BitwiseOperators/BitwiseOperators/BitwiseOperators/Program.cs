using System;

namespace BitwiseOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 0 - 0
            // 1 - 1
            // 2 - 10
            // 3 - 11
            // 4 - 100
            // 5 - 101
            // 6 - 110
            // 7 - 111
            // 8 - 1000
            // 9 - 1001
            // 10 - 1010
            // 11 - 1011
            // 12 - 1100
            // 13 - 1101
            // 14 - 1110
            // 15 - 1111
            // 16 - 10000
            // 17 - 10001
            // 18 - 10010
            // 19 - 10011
            // 20 - 10100
            // 21 - 10101
            // 22 - 10110
            // 23 - 10111
            // 24 - 11000
            // 25 - 11001
            // 1 + 8 + 16 = 25


            var a = 10;    //  1010  //if 2 ones - 1   else 0
            var b = 14;    //  1110
            var c = a & b; //  1010

            var first = 10;  // 1010
            var second = 14;  //1110

            var ili = first | second; // 1110

            

            var k = 10; //1010 // if same - 0 , if different - 1
            var f = 14; //1110
            var xor = k ^ f; // 0100 - 4



            var twentyFive = 25; // 00011001  // move to the left 2 times - 1100100
            var leftTwentyFive = twentyFive << 2;



            var rightTwentyFive = twentyFive >> 3; // 11
            Console.WriteLine(rightTwentyFive); 
            Console.WriteLine(ConvertToBinary(rightTwentyFive));
         }

        public static string ConvertToBinary(int decimalNumber)
        {
            int remainder;
            var result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }

            return result;
        }

        public static int ConvertToDecimalNumber(string binaryNumber)
        {
            var currentStepen = binaryNumber.Length - 1;
            var backToDecimal = 0.0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[i] == '0')
                {
                    currentStepen--;
                    continue;
                }
                backToDecimal += Math.Pow(int.Parse(binaryNumber[i].ToString()) * 2, currentStepen);
                currentStepen--;
            }

            return (int)backToDecimal;
        }
    }
}
