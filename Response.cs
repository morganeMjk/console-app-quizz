// using System;
// using System.Collections.Generic;

// namespace Quizz;

// public static class Response
// {
//     public static void Verify(string userResponse)
//     {
//         // Vérifier si la réponse de l'utilisateur est un int, et qu'elle est incluse parmis les choix possibles
//             if (!int.TryParse(userResponse, out int userResponseInt) || userResponseInt < 1 || userResponseInt > questions[randomIndex].Options.Count)
//             {
//                 Console.WriteLine("Erreur : Veuillez saisir une réponse valide.");
//             }
//             else
//             {
//                 // Vérifier si la réponse est correcte et incrémenter le score en cas de réponse correcte
//                 if (userResponseInt == questions[randomIndex].CorrectOptionIndex)
//                 {
//                     Console.WriteLine("Bonne réponse :)");
//                     Console.WriteLine("Appuyez sur une touche pour continuer");
//                     Console.ReadLine();
//                     score++;
//                 }
//                 else
//                 {
//                     Console.WriteLine("Mauvaise réponse :(");
//                     Console.WriteLine("Appuyez sur une touche pour continuer");
//                     Console.ReadLine();
//                 }
//             }
//     }

//     // public static HandleInorrectResponse()
//     // {

//     // }
// }