using System;
using System.Collections.Generic;

namespace Quizz;

public static class Actions
{
    /// <summary>
    /// Méthode GetAll
    /// </summary>
    public static List<string> GetAll()
    {
        // Définir & afficher les différentes actions possibles pour l'utilisateur
        var actions = new List<string> { "Démarrer un Quizz au hasard", "Choisir une Catégorie", "Quitter" };

        foreach (var action in actions)
        {
            Console.WriteLine($"{actions.IndexOf(action) + 1}. {action}");
        }

        return actions;
    }


    /// <summary>
    /// Méthode Select
    /// </summary>
    public static void Select(List<string> actions)
    {
        // Récupérer le choix de l'utilisateur
        var selectedAction = Console.ReadLine();

        if (!int.TryParse(selectedAction, out int selectedActionInt) || selectedActionInt < 0 || selectedActionInt > actions.Count)
        {
            Console.WriteLine("Erreur : Veuillez selectionner une action valide");
        }
        else
        {
            if (selectedActionInt == 1)
            {
                var allQuestions = Questions.FetchAll();
                QuizzActions.Start(allQuestions);
            }

            // else if (selectedActionInt == 2)
            // {
            //     var questionsByCategory = Questions.GetByCategory();
            //     QuizzActions.StartQuizz(questionsByCategory);
            // }
            
            else
            {
                Console.WriteLine("A bientôt");
            }
        }
    }
}