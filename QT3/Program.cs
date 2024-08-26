/*-------------------------------------------------------------------
Questão 3: Cálculo de Vida Restante
• Contextualização: Durante um combate, o jogador recebe dano e a vida do personagem
diminui.
• Comando: Crie um programa que receba o valor da vida inicial, o dano recebido, o bônus de
regeneração, do atacado, e dois modificadores, do atacante, (um para equipamentos e outro
para habilidades), e calcule a vida restante.

@Lista: 01 - Lógica de Programação
@Autor: PEDRO LIMA
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
class Program 
{
    static void Main(string[] args) 
    {
       Double vida, dano, bonus, atacado, modEquipamentos, modHabilidades;
       Console.WriteLine("Vida Inicial:");
       Double.TryParse(Console.ReadLine(), out vida);

       Console.WriteLine("Dano Recebido:");
       Double.TryParse(Console.ReadLine(), out dano);

       Console.WriteLine("Bônus de Regeneração:");
       Double.TryParse(Console.ReadLine(), out bonus);

       Console.WriteLine("Modificador Equipamentos:!");
       Double.TryParse(Console.ReadLine(), out modEquipamentos);

       Console.WriteLine("Modificador Habilidades:");
       Double.TryParse(Console.ReadLine(), out modHabilidades);

       Double Soma = ((vida - dano * modEquipamentos) + bonus * modHabilidades);
       Console.WriteLine($"Vida Restante: {Soma}");
       Console.ReadLine(); 
    } 


} 