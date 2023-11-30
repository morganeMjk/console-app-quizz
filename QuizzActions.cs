using System;
using System.Collections.Generic;
using System.Net;

namespace Quizz;

public static class QuizzActions
{
    // Méthode Start
    public static void Start(List<Question> questions)
    {
        // Initialiser le score de l'utilisateur
        int score = 0;

        // Boucle pour poser trois questions
        for (int i = 0; i < 3 && questions.Count > 0; i++)
        {
            Questions.GetRandomOne(questions);

            // Demander sa réponse à l'utilisateur
            var userResponse = Console.ReadLine();
        }

        Finish();
    }




    // Méthode Finish
    public static void Finish()
    {
        // Afficher le score après avoir posé les trois questions
        Console.WriteLine($"Votre score final : \n");
        Console.WriteLine("Que souhaitez-vous faire ?");

        // Définir & afficher les différents choix possibles pour l'utilisateur
        var nextSteps = new List<string> { "Retourner au menu principal", "Quitter" };
        foreach (var nextStep in nextSteps)
        {
            Console.WriteLine($"{nextSteps.IndexOf(nextStep) + 1}. {nextStep}");
        }

        var userStep = Console.ReadLine();

        // Vérification : si le choix de l'utilisateur (conversion) est valide et est égale à 1, appel de la méthode Steps. Sinon, arrêt du programme
        if (int.TryParse(userStep, out int userStepInt) && userStepInt == 1)
        {
            Console.Clear();
        }
        
        Console.ReadLine();
    }

}