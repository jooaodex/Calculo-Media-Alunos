using Calculo_Media_Alunos;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;
            Aluno aluno;
            aluno = new Aluno();



            Console.WriteLine("Digite seu Nome: ");
            aluno.nome = Console.ReadLine();


            Console.WriteLine("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a quarta nota: ");
            nota4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (nota1+nota2+nota3+ nota4)/4;

            Console.WriteLine("Olá " + aluno.nome + " sua média é " + media + " e vocÊ está: ") ;
            if(media < 6)
            {
                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Aprovado");
            }

        }
    }
}
