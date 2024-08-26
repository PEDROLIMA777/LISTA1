/*-------------------------------------------------------------------
Questão 2: Pontuação Final
• Contextualização: No final de uma missão em um jogo, a pontuação do jogador é calculada com
base nos inimigos derrotados e pontos adicionais.
• Comando: Desenvolva um programa que receba o número de inimigos derrotados, a pontuação
por inimigo, bônus por missão, e dois multiplicadores (um para tipo de inimigo e outro para
dificuldade), e então calcule e exiba a pontuação final.

@Lista: 01 - Lógica de Programação
@Autor: PEDRO ÍCARO
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
using System.Runtime.InteropServices;

class Program 
{
    static void Main(string[] args) 
    { 
       int inimigos, bonus, pontos;
       Double mult1, mult2, Soma;

       Console.WriteLine("inimigos derrotados");
       int.TryParse(Console.ReadLine(), out inimigos);

       Console.WriteLine("pontos por inimigo");
       int.TryParse(Console.ReadLine(), out pontos);

       Console.WriteLine("bonus por missão");
       int.TryParse(Console.ReadLine(), out bonus);

       Console.WriteLine("mult1");
       Double.TryParse(Console.ReadLine(), out mult1);

       Console.WriteLine("mult2");
       Double.TryParse(Console.ReadLine(), out mult2);

       Soma = (inimigos * pontos * mult1 * mult2) + bonus;

       Console.WriteLine($"pontuacao: {Soma}");

       Console.ReadLine(); 
    } 


} 

