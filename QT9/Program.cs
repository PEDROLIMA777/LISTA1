/*-------------------------------------------------------------------
Atividade 9: Comparação de Poder de Ataque 
* Contextualização: Em um jogo de luta, cada personagem tem um valor de ataque baseado em 
sua força, arma e bônus de habilidades. O total de ataque é afetado por modificadores críticos 
e pelo tipo da arma. 
* Crie um programa que receba o valor da força do personagem, o poder da arma, o bônus de 
Comando: habilidades, um modificador de crítico, e um modificador para o tipo da arma. O 
programa deve calcular o total de ataque do personagem 

@Lista: 01 - Lógica de Programação
@Autor: PEDRO LIMA
@Data: 25/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    static void Main()
    {
        int forca, poder;
        double bonus, modC, modA, soma;

        Console.Write("qual a sua forca?: ");
        int.TryParse(Console.ReadLine(), out forca);


        Console.Write("qual o seu poder da arma?: ");
        int.TryParse(Console.ReadLine(), out poder);

        Console.Write("qual o bonus de habilidade?: ");
        double.TryParse(Console.ReadLine(), out bonus);
        
        Console.Write("qual o modificador critico?: ");
        double.TryParse(Console.ReadLine(), out modC);

        Console.Write("qual o modificador de tipo de arma?: ");
        double.TryParse(Console.ReadLine(), out modA);
        
        soma = ((bonus * modC * modA * poder) + forca);

        Console.WriteLine("total de ataque é de: " + (soma));

        Console.WriteLine("APERTE ENTER PARA SAIR");
        Console.ReadLine();
    }
}