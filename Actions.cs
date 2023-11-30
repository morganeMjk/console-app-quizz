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
        // creer bool false, tant que false on boucle. Si ok on passe en true

        bool verifyAction = false;

        while (!verifyAction)
        {
            var selectedAction = Console.ReadLine();
            int.TryParse(selectedAction, out int selectedActionInt);
            if (selectedActionInt <= 0 || selectedActionInt > actions.Count)
            {
                Console.WriteLine("Erreur : Veuillez selectionner une action valide");
                GetAll();
            }
            else
            {
                verifyAction = true;

                // Si le choix de l'utilisateur = 1, il est redirigé vers le début du quizz aléatoire
                if (selectedActionInt == 1)
                {
                    var allQuestions = Questions.FetchAll();
                    QuizzActions.Start(allQuestions);
                }

                else if (selectedActionInt == 2)
                {
                    var categories = GetCategories();
                }

                else
                {
                    Console.WriteLine("A bientôt");
                }
            }
        }
    }

    public static List<string> GetCategories()
    {
        // Définir & afficher les différentes actions possibles pour l'utilisateur
        var categories = new List<string> { "C#", "Les raccourcis VS Code", "Les commandes" };

        foreach (var category in categories)
        {
            Console.WriteLine($"{categories.IndexOf(category) + 1}. {category}");
        }

        return categories;
    }
}