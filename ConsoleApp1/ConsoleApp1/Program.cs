using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean flag = true;
            while (flag)
            {

                Console.Write("Digite um número ('fim' para sair) : ");
                String result = Console.ReadLine();
                if (result.ToLower().Equals("fim"))
                {
                    flag = false;
                }
                else
                {
                    int numeroUm;
                    if (Int32.TryParse(result, out numeroUm))
                    {
                        Console.Write("Digite outro número: ");
                        result = Console.ReadLine();
                        int numeroDois;
                        if (Int32.TryParse(result, out numeroDois))
                        {
                            Console.Write("Digite um sinal para essa conta: ");
                            result = Console.ReadLine();
                            Console.Clear();
                            switch (result)
                            {
                                case "+":
                                    Console.WriteLine(numeroUm + " + " + numeroDois + " = " + (numeroUm + numeroDois));
                                    break;
                                case "-":
                                    Console.WriteLine(numeroUm + " - " + numeroDois + " = " + (numeroUm - numeroDois));
                                    break;
                                case "*":
                                    Console.WriteLine(numeroUm + " * " + numeroDois + " = " + (numeroUm * numeroDois));
                                    break;
                                case "/":
                                    if (numeroUm == 0 || numeroDois == 0)
                                    {
                                        Console.WriteLine("Não é possivel dividir por zero!");
                                    }
                                    else
                                    {
                                        Console.WriteLine(numeroUm + " / " + numeroDois + " = " + (Double.Parse(numeroUm.ToString()) / Double.Parse(numeroDois.ToString())));
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
        }
    }
}
