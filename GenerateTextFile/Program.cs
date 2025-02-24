namespace GenerateTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter streamWriter = new StreamWriter("words.txt");
            streamWriter.Close();

            StreamReader reader = new StreamReader("words.txt");
            string[] wordList = reader.ReadToEnd().Split(' ');
            reader.Close();
        }
    }
}
