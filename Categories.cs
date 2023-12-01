using System;
using System.Collections.Generic;

namespace Quizz;

public static class Categories
{
    public static List<string> GetAll()
    {
        // Définir & afficher les différentes actions possibles pour l'utilisateur
        var categories = new List<string> { "C#", "Les raccourcis VS Code", "Les commandes" };

        foreach (var category in categories)
        {
            Console.WriteLine($"{categories.IndexOf(category) + 1}. {category}");
        }

        return categories;
    }


    public static void Select(List<string> categories)
    {
        bool verifyCategory = false;

        while (!verifyCategory)
        {
            var selectedCategory = Console.ReadLine();
            int.TryParse(selectedCategory, out int selectedCategoryInt);
            if (selectedCategoryInt <= 0 || selectedCategoryInt > categories.Count)
            {
                Console.WriteLine("Erreur : Veuillez selectionner une action valide");
                GetAll();
            }
            else
            {
                verifyCategory = true;
                var questionsByCategory = Questions.GetByCategory(selectedCategoryInt);
                QuizzActions.Start(questionsByCategory);
            }
        }
    }
}