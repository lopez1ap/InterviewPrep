internal class Program
{
    private static void Main(string[] args)
    {
        int[] unsortedList = { 6, 3, 2, 0, 1, 8, 13, 2, 54, 2, 44 };
        string[] stringList = { "Test", "Hello", "Trust", "best", "no", "Yes", "very", "ugly"};
        Console.WriteLine("Aggregate:" + unsortedList.Aggregate((a, b) => { 
            Console.WriteLine("A: " + a);
            Console.WriteLine("B: " + b);
            return a + b; 
        }).ToString());

       Console.WriteLine("All: " + unsortedList.All((num) => num > -1));
       
       Console.WriteLine("Any: " + unsortedList.Any(num => num % 2 == 0));

        Console.WriteLine("Append + Aggregate: " + unsortedList.Append(10).Aggregate((a, b) => a + b));
        var zippedList = unsortedList.Zip(stringList, (num, word) => new { num, word });
        foreach (var item in zippedList)
        {
            Console.WriteLine("Num: " + item.num);
            Console.WriteLine("Word: " + item.word);
        }
    }

    private static int[] mergeSort(int[] nums)
    {
        
        return [];
    }
}