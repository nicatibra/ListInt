namespace ListInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt array1 = new ListInt(1, 2, 3, 4, 5);
            Console.WriteLine("Intial array: " + array1.ToString());

            Console.WriteLine($"Array contains your number? : " + array1.Contains(34));
            array1.Add(6);
            array1.AddRange(7, 8);
            Console.WriteLine("Elements of array after adding: " + array1.ToString());
            Console.WriteLine("Sum of array: " + array1.Sum());

            array1.Remove(8);
            array1.RemoveRange(1, 0, 3);
            Console.WriteLine("Elements of array after removing: " + array1.ToString());
        }
    }
}
