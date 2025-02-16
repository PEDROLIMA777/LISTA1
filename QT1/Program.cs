﻿/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
personagem e exiba esses dados no console.

@Lista: 01 - Lógica de Programação
@Autor: PEDRO LIMA
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;

class Program 
{
    static void Main(string[] args)
    {
        int idade, nivel;
        string nome, classe, raca;
       
        Console.WriteLine("Informe seu nome");
        nome = Console.ReadLine();

        Console.WriteLine("informe sua idade");
        int.TryParse(Console.ReadLine(), out idade);

        Console.WriteLine("informe seu nivel");
        int.TryParse(Console.ReadLine(), out nivel);

        Console.WriteLine("informe sua classe");
        classe = Console.ReadLine();

        Console.WriteLine("informe sua raca");
        raca = Console.ReadLine();  

        Console.WriteLine($"nome: {nome}");
        Console.WriteLine($"idade: {idade}");
        Console.WriteLine($"nivel: {nivel}");
        Console.WriteLine($"classe: {classe}");
        Console.WriteLine($"raca: {raca}");

        Console.WriteLine("\nPress ENTER to back");
        Console.ReadLine();
    }
}    