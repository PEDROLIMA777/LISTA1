
/*-------------------------------------------------------------------
Questão 5: Cálculo de Distância Percorrida
• Contextualização: Um veículo no jogo percorre uma certa distância em um tempo determinado.
• Comando: Crie um programa que receba a velocidade do veículo, o tempo de viagem e dois
multiplicadores (um para condições climáticas e outro para estado do veículo), e calcule a
distância total percorrida.

@Lista: 01 - Lógica de Programação
@Autor: PEDRO LIMA
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;

class Program 
{
    static void Main(string[] args)
    {
       int velocidade, tempo;
       Double mult1, mult2, Soma;

       Console.WriteLine("Velocidade do Veículo:");
       int.TryParse(Console.ReadLine(), out velocidade);

       Console.WriteLine("Tempo de Viagem:");
       int.TryParse(Console.ReadLine(), out tempo);

       Console.WriteLine("Multiplicador Climático:");
       Double.TryParse(Console.ReadLine(), out mult1);

       Console.WriteLine("Multiplicador Estado do Veículo:");
       Double.TryParse(Console.ReadLine(), out mult2);
       
       Soma = (velocidade * tempo * mult1 * mult2);
       
       Console.WriteLine($"Distância total percorrida: {Soma}");

       Console.ReadLine();
       

    } 


} 