using System;

class Program
{
    static void Main(string[] args)
    {
        // Définir les variables
        double num1, num2, resultat;

        // Saisir les nombres en vérifiant que les valeurs saisies sont valides
        bool validInput = false;
        do
        {
            Console.WriteLine("Entrez le premier nombre : ");
            if (double.TryParse(Console.ReadLine(), out num1))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Nombre invalide, veuillez réessayer.");
            }
        } while (!validInput);

        validInput = false;
        do
        {
            Console.WriteLine("Entrez le deuxième nombre : ");
            if (double.TryParse(Console.ReadLine(), out num2))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Nombre invalide, veuillez réessayer.");
            }
        } while (!validInput);

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
                if (num2 != 0)
                {
                    resultat = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Division par zéro impossible !");
                    return; // Quitter le programme si la division par zéro est tentée
                }
                break;
            default:
                Console.WriteLine("Opération invalide !");
                return; // Quitter le programme si une opération invalide est choisie
        }

        // Afficher le résultat
        Console.WriteLine("Le résultat est : " + resultat);
    }
}
