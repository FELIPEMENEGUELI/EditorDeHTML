using System.Text;

namespace EditHTML
{
    public class Edit
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Editor");
            Console.WriteLine("------------");
            Start();

        }

        public static void Start()
        {

            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("------------");
            Console.WriteLine(" Deseja salvar o arquivo?");
            View.Show(file.ToString());
        }
    }
}