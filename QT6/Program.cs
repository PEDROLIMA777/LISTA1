/*-------------------------------------------------------------------
Questão 6: Conversão de Moeda do Jogo
• Contextualização: O jogo possui uma loja onde os jogadores podem trocar moedas de ouro por
cristais.
• Comando: Desenvolva um programa que receba o valor de moedas de ouro, o valor da taxa de
conversão (1 cristal = X moedas de ouro), e dois bônus de conversão (um baseado em eventos
e outro em habilidades), e calcule o número de cristais que o jogador pode obter.

@Lista: 01 - Lógica de Programação
@Autor: PEDRO ÍCARO
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
class Program 
{
    static void Main(string[] args) 
    {
       int moedasOuro, taxaConversao; 
       double bonusConversaoOuro, bonusConversaoHabilidades, Soma;

       Console.WriteLine("Moedas de Ouro:");
       int.TryParse(Console.ReadLine(), out moedasOuro);

       Console.WriteLine("Taxa de Conversão:");
       int.TryParse(Console.ReadLine(), out taxaConversao);

       Console.WriteLine("Bônus de Evento:");
       Double.TryParse(Console.ReadLine(), out bonusConversaoOuro);

       Console.WriteLine("Bônus de Habilidade:");
       Double.TryParse(Console.ReadLine(), out bonusConversaoHabilidades);

       Soma = ((moedasOuro / taxaConversao) + bonusConversaoOuro) * bonusConversaoHabilidades;

       Console.WriteLine("Cristais obtidos: "+ Math.Floor(Soma));

       Console.ReadLine(); 
    } 


} 