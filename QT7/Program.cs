/*-------------------------------------------------------------------
Atividade 7: Experiência e Nível do Jogador após Batalha
• Contextualização: Em um jogo, o jogador enfrenta dois tipos diferentes de inimigos em uma
batalha. Cada tipo de inimigo concede uma quantidade específica de XP. Após a batalha, o
jogador ganha esse XP e precisa somá-lo ao XP total acumulado para determinar o nível atual
do personagem.
• Comando:Desenvolva um programa que receba a quantidade de XP acumulado, o XP concedido
pelo primeiro tipo de inimigo, o XP concedido pelo segundo tipo de inimigo, o número de cada
tipo de inimigo derrotado, e a constante de nível. O programa deve calcular o XP total
acumulado após a batalha e determinar o nível atual do jogador.

@Lista: 01 - Lógica de Programação
@Autor: PEDRO LIMA
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;

class Program 
{
    static void Main(string[] args) 
    {
       int inim1, inim2, nvl;
       double xpTotal, soma,  xpAcumu, xpConc1, xpConc2;

       Console.WriteLine("XP Acumulado:");
       double.TryParse(Console.ReadLine(), out xpAcumu);

       Console.WriteLine("XP Inimigo");
       double.TryParse(Console.ReadLine(), out xpConc1);

       Console.WriteLine("Inimigos 1 Derrotados:");
       int.TryParse(Console.ReadLine(), out inim1);

       Console.WriteLine("XP Inimigo 2:");
       double.TryParse(Console.ReadLine(), out xpConc2);

       Console.WriteLine("Inimigos 2 Derrotados:");
       int.TryParse(Console.ReadLine(), out inim2);

       soma = (xpAcumu + xpConc1 * inim1 + xpConc2 * inim2);

       Console.WriteLine($"XP Total: {soma}");


       Console.ReadLine(); 
    } 


} 