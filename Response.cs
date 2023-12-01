using System;

namespace Quizz;

public static class Response
{
    public static bool Verify(Question currentQuestion, string userResponse)
    {
        // Vérifier si la réponse de l'utilisateur est un int, et qu'elle est incluse parmis les choix possibles
        if (!int.TryParse(userResponse, out int userResponseInt) || userResponseInt < 1 || userResponseInt > currentQuestion.Options.Count)
        {
            Console.WriteLine("Erreur : Veuillez saisir une réponse valide.");
            return false;
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