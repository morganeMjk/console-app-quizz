using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Quizz
{
    public static class Questions
    {
        private const int indexQuestionText = 0;
        private const int indexOptions = 1;
        private const int indexCorrectOption = 2;
        private const int CategoryIndex = 3;



        // Méthode FetchAll
        public static List<Question> FetchAll()
        {
            List<Question> questions = new List<Question>();
            try
            {
                // Lire toutes les lignes du fichier CSV et les stocker dans une liste
                using (StreamReader sr = new StreamReader("questions.csv"))
                {
                    string? line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Diviser chaque élément d'une ligne en utilisant le point-virgule comme séparateur
                        string[] parts = line.Split(';');

                        // Vérifier que chaque ligne comporte bien 3 éléments (questions, choix, réponse)
                        if (parts.Length == 4)
                        {
                            // Créer une nouvelle question en suivant la classe Question
                            Question question = new Question
                            {
                                QuestionText = parts[indexQuestionText],
                                Options = new List<string>(parts[indexOptions].Split('/')),
                                CorrectOptionIndex = int.Parse(parts[indexCorrectOption])
                            };

                            // Ajouter la question à la liste
                            questions.Add(question);
                        }
                        else
                        {
                            Console.WriteLine($"Erreur : Format incorrect dans la ligne du fichier CSV : {line}");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de la lecture du fichier CSV :");
                Console.WriteLine(e.Message);
            }
            return questions;
        }



        // Méthode GetRandomOne
        public static Question? GetRandomOne(List<Question> questions)
        {
            // Vérifier la nullité et la validité de la liste de questions
            if (questions == null || questions.Count == 0)
            {
                Console.WriteLine("Aucune question disponible.");
                Console.ReadLine();
                return null;
            }
            else
            {
                // Générer une instance de la classe Random
                Random random = new();

                // Utiliser la méthode .Next() pour choisir un index entre 0 et le nombre total de questions grâce à l'instance random
                int randomIndex = random.Next(questions.Count);

                Question currentQuestion = questions[randomIndex];

                // Afficher la question sélectionnée aléatoirement
                Console.WriteLine(currentQuestion.QuestionText);

                if (currentQuestion.Options == null || currentQuestion.Options.Count == 0)
                {
                    Console.WriteLine("Aucune option disponible.");
                    Console.ReadLine();
                    return null;
                }
                else
                {
                    // Afficher chaque option de la question sélectionnée aléatoirement
                    for (int index = 0; index < currentQuestion.Options.Count; index++)
                    {
                        Console.WriteLine($"{index + 1}. {currentQuestion.Options[index]}");
                    }

                    questions.Remove(currentQuestion);

                    return currentQuestion;
                }
            }
        }




        public static List<Question> GetByCategory(int category)
        {
            try
            {
                // Lire toutes les lignes du fichier CSV
                var questions = File.ReadAllLines("questions.csv")
                    .Select(line =>
                    {
                        // Diviser chaque élément d'une ligne en utilisant le point-virgule comme séparateur
                        var parts = line.Split(';');

                        // Vérifier que chaque ligne comporte bien 4 éléments (questions, choix, réponse, catégorie)
                        if (parts.Length == 4 && int.Parse(parts[CategoryIndex]) == category)
                        {
                            // Créer une nouvelle question en suivant la classe Question
                            return new Question
                            {
                                QuestionText = parts[indexQuestionText],
                                Options = new List<string>(parts[indexOptions].Split('/')),
                                CorrectOptionIndex = int.Parse(parts[indexCorrectOption]),
                                CategoryIndex = int.Parse(parts[CategoryIndex])
                            };
                        }
                        else
                        {
                            return null;
                        }
                    })
                    .Where(question => question != null)
                    .ToList();

                return questions;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de la lecture du fichier CSV :");
                Console.WriteLine(e.Message);
                return new List<Question>();
            }
        }
    }
}