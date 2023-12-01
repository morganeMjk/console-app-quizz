using System;

namespace Quizz;

public static class Response
{
    public static bool Verify(Question currentQuestion, string userResponse)
    {

        while (true)
        {
            // Vérifier si la réponse de l'utilisateur est un int, et qu'elle est incluse parmi les choix possibles
            if (!int.TryParse(userResponse, out int userResponseInt) || userResponseInt < 1 || userResponseInt > currentQuestion.Options.Count)
            {
                Console.ForegroundColor = ConsoleColor.Red; // Set text color to red
                Console.WriteLine("Erreur : Veuillez saisir une réponse valide.");
                Console.ResetColor(); // Reset text color to default
                // Prompt user for input again
                Console.WriteLine("Réessayez :");
                userResponse = Console.ReadLine();
            }
            else
            {
                Console.Clear();

                // Vérifier si la réponse est correcte et incrémenter le score en cas de réponse correcte
                if (userResponseInt == currentQuestion.CorrectOptionIndex)
                {
                    Console.WriteLine("Bonne réponse :)");
                    Console.WriteLine("Appuyez sur une touche pour continuer");
                    Console.ReadLine();
                    Console.Clear();
                    return true;
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse :(");
                    Console.WriteLine("Appuyez sur une touche pour continuer");
                    Console.ReadLine();
                    Console.Clear();
                    return false;
                }
            }
        }
    }
}
