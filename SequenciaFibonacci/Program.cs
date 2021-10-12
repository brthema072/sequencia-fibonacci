using System;

namespace SequenciaFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            p.GenerateFibonacciSequence();
        }

        public void GenerateFibonacciSequence()
        {
            Console.WriteLine("Defina o tamanho da sequência");
            string strSequenceLength = Console.ReadLine();
            Console.WriteLine();

            short.TryParse(strSequenceLength, out short sequenceLength);

            int num1 = 0, num2 = 1, aux;

            if (sequenceLength > 0)
            {
                int[] numbers = new int[sequenceLength];

                for (short i = 0; i < sequenceLength; i++)
                {
                    if(i == 0)
                    {
                        numbers[i] = 0;
                    }
                    else
                    {
                        aux = num1;
                        num1 = num2;
                        num2 = num1 + aux;
                        numbers[i] = num2;
                    }

                }

                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }
            }

        }
    }
}
