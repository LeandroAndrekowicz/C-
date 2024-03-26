using System;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bolean = true;
            string peso;
            string altura;
            double doublePeso;
            double doubleAltura;
            double imc;

            string continuar;
            char stringContinuar;

            while (bolean)
            {
                Console.WriteLine("####################################");
                Console.WriteLine("##       Calculo de IMC           ##");
                Console.WriteLine("####################################");

                Console.WriteLine("\n");

                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();

                if(nome != "")
                {
                    Console.Write("Digite seu peso (cm): ");
                    peso = Console.ReadLine();
                    doublePeso = Convert.ToDouble(peso);

                    Console.Write("Digite sua Altura (cm): ");
                    altura = Console.ReadLine();
                    doubleAltura = Convert.ToDouble(altura);

                    imc = doublePeso / (doubleAltura * doubleAltura) ;

                    if(imc < 18.5)
                    {
                        Console.WriteLine("{0} você está com o peso [Baixo]", nome);
                        Console.WriteLine("Seu IMC eh : {0}", imc);
                    }

                    else if (imc >= 18.5 && imc < 25){
                        Console.WriteLine("{0} você está com o peso [Normal]", nome);
                        Console.WriteLine("Seu IMC eh : {0}", imc);
                    }

                    else if( imc >= 25 && imc < 30)
                    {
                        Console.WriteLine("{0} você está com o peso [Sobrepeso]", nome);
                        Console.WriteLine("Seu IMC eh : {0}", imc);
                    }

                    else
                    {
                        Console.WriteLine("{0} você está com o peso [Gordo pra krl]", nome);
                        Console.WriteLine("Seu IMC eh : {0}", imc);
                    }
                }

                Console.WriteLine("Deseja continuar ? S/N");
                continuar = Console.ReadLine();

                stringContinuar = Convert.ToChar(continuar);

                if(stringContinuar != 'S' || stringContinuar!= 's')
                {
                    bolean = true;
                }
                else
                {
                    bolean = false;
                }
            }

        }
    }
}
