using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double salario = 0;

                Console.Write("Informe o salario do Funcionario: R$ ");
                salario += double.Parse(Console.ReadLine());

                if (salario > 4000)
                {
                    salario -= salario * 0.15;
                }
                else
                {
                    salario -= salario * 0.11;
                }

                Console.WriteLine("Salario com desconto de impostos: " + salario.ToString("C"));

                if (salario > 0)
                {
                    
                    Console.Write("O Funcionario possui filhos? (S/N): ");
                    string filhos = Console.ReadLine().ToUpper();

                    if (filhos == "S")
                    {
                        salario += 200;
                        Console.WriteLine("Salario com Adicional de R$ 200,00 : " + salario.ToString("C"));
                    }
                    else if (filhos == "N")
                    {
                        Console.WriteLine("O Funcionario nao possui filhos.");
                    }

                    Console.Write("O Funcionario possui plano de saude? (S/N): ");
                    string planoSaude = Console.ReadLine().ToUpper();

                    if (planoSaude == "S")
                    {
                        salario -= 300;
                        Console.WriteLine("Salario com desconto de R$ 300,00 : " + salario.ToString("C"));
                    }
                    else if (planoSaude == "N")
                    {
                        Console.WriteLine("O Funcionario nao possui plano de saude.");
                        
                    }
                    else
                    {
                        Console.WriteLine("Opção Invalida");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }

                    Console.WriteLine("Salario Final: " + salario.ToString("C"));

                }
                else
                {
                    Console.WriteLine("Informe um valor maior do que 0 (Zero)");
                }

               
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Insira apenas numeros");
            }
            finally
            {
                Console.WriteLine("Programa encerrado");
                Console.ReadKey();
            }
        } 
    }
}
