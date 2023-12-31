using System;
using System.Collections.Generic;

namespace Quizz;

public static class QuizzActions
{

    // Méthode Start
    public static void Start(List<Question> questions)
    {

        // Initialiser le score de l'utilisateur
        int score = 0;

        if (questions == null || questions.Count == 0)
        {
            Console.WriteLine("Aucune question disponible.");
            Console.ReadLine();
        }
        else
        {
            // Boucle pour poser trois questions
            for (int i = 0; i < 3 && questions.Count > 0; i++)
            {
                // Doit retourner la réponse de l'utilisateur
                var currentQuestion = Questions.GetRandomOne(questions);
                var userResponse = Console.ReadLine();

                bool isCorrect = Response.Verify(currentQuestion, userResponse);

                if (isCorrect)
                {
                    score++;
                }
            }
            Finish(score);
        }
    }




    // Méthode Finish
    public static void Finish(int score)
    {
        // Afficher le score après avoir posé toutes les questions
        Console.WriteLine($"Votre score final : {score} \n");
        Console.WriteLine("Que souhaitez-vous faire ?");
        var nextActions = new List<string> { "Retourner au menu principal", "Quitter" };
        foreach (var nextAction in nextActions)
        {
            Console.WriteLine($"{nextActions.IndexOf(nextAction) + 1}. {nextAction}");
        }

        bool verifyNextAction = false;

        while (!verifyNextAction)
        {
            var nextAction = Console.ReadLine();

            int.TryParse(nextAction, out int nextActionInt);

            if (nextActionInt <= 0 || nextActionInt > nextActions.Count)
            {
                Console.ForegroundColor = ConsoleColor.Red; // Set text color to red
                Console.WriteLine("Erreur : Veuillez selectionner une action valide");
                Console.ResetColor(); // Reset text color to default
            }
            else
            {
                verifyNextAction = true;
                Console.Clear();

                // Si le choix de l'utilisateur = 1, l'utilisateur est redirigé vers le menu principal
                if (nextActionInt == 1)
                {
                    Console.WriteLine("Que souhaitez-vous faire ?");
                    var actions = Actions.GetAll();
                    Actions.Verify(actions);
                }
                else if (nextActionInt == 2)
                {
                    Console.WriteLine("A bientôt");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                }
            }
        }
    }
}