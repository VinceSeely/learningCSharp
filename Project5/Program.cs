namespace Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<int>();
            //assume we are only going to get in an integer here
            Console.WriteLine("How many items do you want in the list");
            var desiredSize = int.Parse(Console.ReadLine());
            // Fill the list with the desired number of values
            // unlike arrays lists are not fixed in size so you need to stop with an outside value
            // example of how to add to end of list //myList.Add(2);

        }
    }
}