using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
        void atividade01() {
            //NOME : literal
            string nome;
            //leia pessoa
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Olá seja bem vindo" + nome);
            Console.ReadKey();
        }
        void atividade02()
        { //Double e float são idênticos
          // Porém o float guarda mais numeros em casa decimais
            float numero;


            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 10)
            {
                numero = numero * 0.1f;
            }

            Console.WriteLine("O valor de número é " + numero);
            Console.ReadKey();

        }
        void atividade01pg77()
        {
            int numero;
            Console.WriteLine("Digite um número maior que 100: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 100)
            {
                numero = numero + 150;
            }
            Console.WriteLine("O valor de número é " + numero);
            Console.ReadKey();
        }
        void atividade02pg81()
        {
            double nota;
            string nome;

            Console.WriteLine("informe seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Informe sua media final");
            nota = double.Parse(Console.ReadLine());

            if (nota <= 6.0)
            {
                Console.WriteLine($"Parabens {nome} você foi aprovado com a média de  {nota}!!");

            }
            else
            {
                Console.WriteLine($"{nome} Infelizmente você reprovou =( ");
            }

            Console.ReadKey();
        }
        void atividade03pg84()
        {
            double nota1, nota2;

            Console.WriteLine("Digite sua 1º nota:");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor agora digite sua 2° nota:");
            nota2 = double.Parse(Console.ReadLine());
            double media = (nota1 + nota2) / 2;
            Console.WriteLine($"Sua media é {media}");
            if (media > 6.0)
            {
                Console.WriteLine("Média superior à média minima (6,0) ");

            }

            if (media == 6.0)
            {
                Console.WriteLine("Média igual à media minima ");
            }

            if (media < 6.0)
            {
                Console.WriteLine("Média inférior à média mínima");
            }
            Console.ReadKey();
        }
        void atividade04pg87() 
        {
            Console.WriteLine("digite a sua nota do ano retrasado");
            double nota = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a sua nota do ano passado");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a sua nota do ano atual");
            double nota3 = double.Parse(Console.ReadLine());
            double notafinal;
            if (nota > nota2)
            {
                notafinal = nota;
                Console.WriteLine($"o numero maior é {nota}");
                return;



            }
            if (nota > nota3)
            {
                notafinal = nota;
                Console.WriteLine($"o numero maior é {nota}");
                return;
            }
            if (nota2 > nota)
            {
                notafinal = nota2;
                Console.WriteLine($"o numero maior é {nota2}");
                return;
            }
            if (nota2 > nota3)
            {
                notafinal = nota2;
                Console.WriteLine($"o numero maior é {nota2}");
                return;
            }
            if (nota3 > nota)
            {
                notafinal = nota3;
                Console.WriteLine($"o numero maior é {nota3}");
                return;
            }
            if (nota3 > nota2)
            {
                notafinal = nota3;
                Console.WriteLine($"o numero maior é {nota3}");
                return;
            }
       
    }

