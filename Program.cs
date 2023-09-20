class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Привет, это анкетка на регистрацию и.т.п");
        Console.WriteLine("Сейчас программа задаст тебе некоторые вопросы");
        Console.WriteLine("Как ваше имя:");
        string YourName = Console.ReadLine();
        Console.WriteLine("Хорошо {0}! \nСледующий вопрос \nСколько вам полных лет:", YourName);
        byte YourAge = byte.Parse(Console.ReadLine());
        Console.WriteLine("Прекрастно! \nСледующий вопрос \nВаше любимое блюдо?");
        string YourFood = Console.ReadLine();
        Console.WriteLine("Невероятно {0}", YourFood);
    }
}