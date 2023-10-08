using System.IO;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The first homework
            Homework1();
            // The Second homework
            string FileName = "C:\\Users\\moham\\Desktop\\Shadi-Moh.txt";
            Homework2(FileName);

        }



        public static void Homework1()
        {
           
            List<int> List1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < List1.Count; i++)
            {
                Console.WriteLine(List1[i]);
            }

            List<string> List2 = new List<string> { "Moh", "Shadi", "Faris", "Omar" };

            for (int i = 0; i < List2.Count; i++)
            {
                Console.WriteLine(List2[i]);
            }

            List<double> List3 = new List<double> { 1.0, 2.5, 3.5, 4.5 };

            for (int i = 0; i < List3.Count; i++)
            {
                Console.WriteLine(List3[i]);
            }
        }
        public static string Homework2(string FileName)
        {
            Console.WriteLine("type a string to save it in the file");
            string stringToSave = Console.ReadLine();
            File.AppendAllText(FileName, stringToSave );
            string newLines = "\n";
            File.AppendAllText(FileName, newLines);

            return "";
        }
    }
}