using System;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite uma opção: ");
            Console.WriteLine("[ 1 ] - Somar ");
            Console.WriteLine("[ 2 ] - Subtrair ");
            Console.WriteLine("[ 3 ] - Multiplicar ");
            Console.WriteLine("[ 4 ] - Dividir ");
            int opc = Convert.ToInt32(Console.ReadLine());

            if(opc == 1)
            {
                Console.WriteLine("Você escolheu SOMAR");
                double soma = n1 + n2;
                Console.WriteLine("A soma dos números é: {0}", soma);
            }else if(opc == 2)
            {
                Console.WriteLine("Você escolheu SUBTRAÇÃO");
                double sub = n1 - n2;
                Console.WriteLine("A subtração dos números é: {0}", sub);
            }else if(opc == 3)
            {
                Console.WriteLine("Você escolheu MULTIPLICAÇÃO");
                double mult = n1 * n2;
                Console.WriteLine("A multiplicação dos números é: {0}", mult);
            }else if(opc == 4)
            {
                Console.WriteLine("Você escolheu DIVISÃO");
                double div = n1 / n2;
                Console.WriteLine("A divisão dos números é: {0}", div);
            }
            else
            {
                Console.WriteLine("DIGITE UMA OPÇÃO VÁLIDA");
            }
            Console.ReadLine();

        }
    }
}
