using System;

namespace Quizz;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bienvenue ! ");
        Console.WriteLine("Que souhaitez vous faire ?");
        var actions = Actions.GetAll();
        Actions.Select(actions);
    }
}