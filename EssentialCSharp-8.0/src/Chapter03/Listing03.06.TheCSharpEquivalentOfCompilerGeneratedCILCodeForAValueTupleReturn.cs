namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_06
{
    public class Program
    {
        public static void Main()
        {
            (string First, string Second, string Third) namedFruits = ("apple", "orange", "banana");

            namedFruits.First = "Eat";

            System.Console.WriteLine(namedFruits);
        }
    }

}
