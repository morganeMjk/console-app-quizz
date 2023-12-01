using System.Collections.Generic;

namespace Quizz
{
    // Classe Question (type)
    public class Question
    {
        // QuestionText, Options et CorrectoptionIndex sont les noms des clés qui doivent être présent dans chaque objet de type Question
        public string QuestionText { get; set; }
        public List<string> Options { get; set; }
        public int CorrectOptionIndex { get; set; }
        public int CategoryIndex { get; set; }
    }
}