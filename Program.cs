using System;

class Program
{
    static void Main(string[] args)
    {
        // Définir les variables
        double num1, num2, resultat;

        // Saisir les nombres
        Console.WriteLine("Entrez le premier nombre : ");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Entrez le deuxième nombre : ");
        num2 = double.Parse(Console.ReadLine());

        // Choisir l'opération
        Console.WriteLine("Choisissez l'opération (+, -, *, /) : ");
        string operation = Console.ReadLine();

        // Effectuer le calcul
        switch (operation)
        {
            case "+":
                resultat = num1 + num2;
                break;
            case "-":
                resultat = num1 - num2;
                break;
            case "*":
                resultat = num1 * num2;
                break;
            case "/":
                resultat = num1 / num2;
                break;
            default:
                Console.WriteLine("Opération invalide!");
                return;
        }

        // Afficher le résultat
        Console.WriteLine("Le résultat est : " + resultat);
    }
}