namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 31;
            char middleInitial = 'D';
            bool isOver18 = true;
            double currentTemp = 77.9;
            decimal currentPrice = 29.99m;

            Console.WriteLine($"Name: {name}\n" +
                              $"Age: {age}\n" +
                              $"Middle Initial: {middleInitial}\n" +
                              $"{name} is over 18: {isOver18}\n" +
                              $"Current Temperature: {currentTemp}\n" +
                              $"Current Price: {currentPrice}");
        }
    }
}
