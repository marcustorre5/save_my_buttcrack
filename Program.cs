using System;

namespace nameprogram
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("\nsave_my_buttcrack v-1.0\n");
            buttcrack();
            reboot();
        }

        static void buttcrack(){
            Console.WriteLine("\nDigite seu salario:");
            var salarioStr = Console.ReadLine();
            double salario = Convert.ToDouble(salarioStr);

            Console.WriteLine("Seu salario é de " + salario);

            Console.WriteLine("\nDigite o valor de suas despesas deste mes : ");
            var despesasStr = Console.ReadLine();
            double despesas = Convert.ToDouble(despesasStr);

            Console.WriteLine("\nSuas despesas são de: " + despesas);

            double restante = salario - despesas;
            Console.WriteLine("\nRestante: " + restante);

            double buttcrack = restante * 0.7;
            Console.WriteLine("\nO ideal para seu buttcrack é de: R$" + buttcrack);

            Console.WriteLine("O restante que deverá ser gasto com cautela!");
        }

        static void reboot(){
            Console.WriteLine("\nDeseja repetir? \n[s] para sim\n[n] para nao");
            string restart = Console.ReadLine();

            while (true)
            {
                if (restart == "s"){
                    buttcrack();
                }

                if (restart == "n"){
                    Console.WriteLine("saindo.");
                    System.Threading.Thread.Sleep(3000); //sleep de 3 segundos
                    break;
                }

                if (restart != "s" && restart != "n"){
                    Console.WriteLine("Opcao invalida, tente novamente!");
                    reboot();
                }
            }
        }
    }
}
