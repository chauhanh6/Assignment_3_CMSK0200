namespace Assignment_3_CMSK0200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "Welcome to the Advanced C# class";
            int wordCount = myString.GetWordCount();
            Console.WriteLine("String value: " + myString);
            Console.WriteLine("Word Count: " + wordCount);
        }
    }
}