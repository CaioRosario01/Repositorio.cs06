using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Chamando a função
            Calculando_MC();
            
            //ReadLine para deixar o console aberto
            Console.ReadLine();


            //Função para calcular o IMC
            void Calculando_MC()
            {
                Console.WriteLine("Digite o seu peso: ");
                double Peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Agora digite a sua altura. Ex: 1,75");
                double Altura = double.Parse(Console.ReadLine());

                //Calculando IMC
                double altura2 = Altura * Altura;
                double IMC = Peso / altura2;
                
                //Limitando as casas decimais do IMC
                int CasaDecimal = 2;
                string resultadonoformato = IMC.ToString($"F{CasaDecimal}");

                //Mostrando o IMC no formato ideal
                Console.WriteLine($"O seu IMC foi: {resultadonoformato}");

                //"Tabela" Do IMC
                if (IMC < 16)
                {
                    Console.WriteLine("Magreza grave");
                }

                else if (IMC > 16 && IMC < 16.9)
                {
                    Console.WriteLine("Magreza moderada");
                }

                else if (IMC > 17 && IMC < 18.5)
                {
                    Console.WriteLine("Magreza leve");
                }

                else if (IMC > 18.6 && IMC < 24.9)
                {
                    Console.WriteLine("Peso ideal");
                }

                else if (IMC > 25 && IMC < 29.9)
                {
                    Console.WriteLine("Sobrepeso");
                }

                else if (IMC > 30 && IMC < 34.9)
                {
                    Console.WriteLine("Obesidade grau I");
                }

                                               
            }
        }
    }
}
