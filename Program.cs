internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Я меня");
    }

    private static void Welcome(string user_name){
        System.Console.WriteLine("Hi");
        System.Console.WriteLine($"Ваше Имя: {user_name}");
    }

    private static int Sum(int a, int b){
        return a + b;
    } 

    private static int Mult(int a, int b) {
        return a * b;
    }
}