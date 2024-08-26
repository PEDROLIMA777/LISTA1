/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir
as informações básicas do personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial,
classe, e raça do personagem e exiba esses dados no console.
@Lista: 01 - Lógica de Programação
@Autor: PEDRO LIMA
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;

class Program 
{
    static void Main(string[] args) 
    {
       int fc, ag, ig, dt, vt, Soma;

       Console.WriteLine("fc");
       int.TryParse(Console.ReadLine(), out fc);

       Console.WriteLine("ag");
       int.TryParse(Console.ReadLine(), out ag);

       Console.WriteLine("ig");
       int.TryParse(Console.ReadLine(), out ig);

       Console.WriteLine("dt");
       int.TryParse(Console.ReadLine(), out dt);

       Console.WriteLine("vt");
       int.TryParse(Console.ReadLine(), out vt);
       

       Soma = (fc + ag + ig + dt + vt);
       Console.WriteLine($"Soma: {Soma}");

       

       Console.ReadLine(); 
    } 


} 