using System;

namespace bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a calculadora de Bhaskara, entre com os valores para comecar:");
            Console.WriteLine("atencao: insira valores com uma casa decimal para os valores da raizes serem exatos, exemplo: 2.0");
            Console.WriteLine("valor de a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor de b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor de c: ");
            double c = double.Parse(Console.ReadLine());
         

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (+b + Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            if(delta < 0)
            {
                Console.WriteLine("Delta menor que 0, logo nao possui raiz");
            }
            if(delta > 0)
            {
                Console.WriteLine("Delta maior que 0, logo temos duas raizes reais e distintas");
            }
            if (delta == 0)
            {
                Console.WriteLine("Delta igual a zero, logo temos apenas uma raiz real");
            }
        }
    }
}
