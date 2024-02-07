namespace TechPrakt2024Task0
{
        class Program
        {
            static void Main(string[] args)
            {
                // Зчитуємо два числа з клавіатури
                Console.WriteLine("Введіть перше число:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть друге число:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                // Рахуємо суму двох чисел
                int sum = num1 + num2;

                // Виводимо суму на екран
                Console.WriteLine($"Сума чисел {num1} і {num2} дорівнює: {sum}");

                // Затримка консолі перед закриттям
                Console.ReadLine();
            }
        }
}
