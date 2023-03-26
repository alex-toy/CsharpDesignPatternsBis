using DesignPatterns.Commands;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var textContext = new TextContext();
            var c1 = new DynamicCommand<TextContext>(textContext, tc => tc.HighLightText());
            var c2 = new DynamicCommand<TextContext>(textContext, tc => tc.BoldText());

            c1.Execute();
            c2.Execute();

            System.Console.ReadLine();
        }
    }
}
