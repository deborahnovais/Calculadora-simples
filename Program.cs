using System;

namespace Calculadora_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a operação que deseja fazer \nSOMA, SUBTRACAO, MULTIPLICACAO OU DIVISAO");
            string operacao = Console.ReadLine();
            
            Console.WriteLine("Digite o primeiro número");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;
            
            // IF / ELSE PADRÃO
            // if(operacao == "SOMA") {
            //     resultado = num1 + num2;
            // }

            // else if(operacao == "SUBTRACAO") {
            //     resultado = num1 - num2;
            // }

            // else if(operacao == "MULTIPLICACAO") {
            //     resultado = num1 * num2;
            // }

            // else if(operacao == "DIVISAO") {
            //     resultado = num1 / num2;
            // }

            // else {
            //     Console.WriteLine("Operação inválida!");
            // }

            // SWITCH / CASE
            switch(operacao) {

                case "SOMA":
                    resultado = num1 + num2;
                    break;

                case "SUBTRACAO":
                    resultado = num1 - num2;
                    break;

                case "MULTIPLICACAO":
                    resultado = num1 * num2;
                    break;

                case "DIVISAO":
                    resultado = num1 / num2;
                    break;
                
                default:
                    Console.WriteLine("Operação inválida!");
                    break;

            }

            Console.WriteLine($"Cálculo: {num1} e {num2} = Resultado: {resultado}");
        }
    }
}
