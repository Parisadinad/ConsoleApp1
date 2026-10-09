Console.WriteLine("Hello, World!");
static void Main(string[] args)
{
    Console.WriteLine("Mobile?");
    string mobile = null;

    for (; ; )
    {
        mobile = Console.ReadLine();

        if (string.IsNullOrEmpty(mobile))
        {
            Console.WriteLine("Please enter valid mobile!");
            continue;
        }

        if (mobile.StartsWith("+98"))
        {
            mobile = mobile.Replace("+98", "0");
        }

        if (mobile.Length == 11)
        {
            break;
        }
    }

    int number = default;
    int number2 = 255;
    long number3 = 0;

    number2 = (int)number3;

    number = number2;
    byte b = default;
    bool isAdmin = false;
    char c = 'C';
    string name = Console.ReadLine();

    Console.WriteLine("Age?");


    string ageStr = Console.ReadLine();
    int age = int.Parse(ageStr);
    int result = 100 - age;
    string role = "xxxx";
    int discount = 0;

    switch (role)
    {
        case "admin":
            discount = 10;
            break;

        case "technical":
            discount = 30;
            break;

        default:
            discount = 0;
            break;
    }
    if (role == "admin")
    {
        discount = 10;
    }
    else if (role == "technical")
    {
        discount = 20;
    }
    else
    {

        discount = 0;
    }

    if (result < 50)
    {
        Console.WriteLine("alskndfad");
    }
    else
    {
    }

    string res = result.ToString();

    Console.WriteLine($"{name} Thanks 1!");

    for (int i = 0; i < 10; i++)
    {
        if (i == 4)
        {
            continue;
        }

        if (i == 9)
        {
            break;
        }

        Console.WriteLine(i * i);
    }

    Console.Write("عدد را وارد کنید: ");
    int number = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < 1; i++)
    {
        Console.WriteLine("مربع عدد برابر است با: " + (number * number));
    }
    Console.Write("یک عدد وارد کنید: ");
    int number = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i <= number; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i + " زوج است");
        }
        else
        {
            Console.WriteLine(i + " فرد است");
        }
    }
    Random random = new Random();

    for (int i = 0; i < 10; i++)
    {
        int number = random.Next(10, 20001);
        Console.WriteLine(number);
    }
    internal class Program
{
    static void Main(string[] args)
    {
        string num1Str = Console.ReadLine();
        string num2Str = Console.ReadLine();

        int num1 = int.Parse(num1Str);
        int num2 = int.Parse(num2Str);

        int result = Sum(num1, num2);

        Console.WriteLine(result);
    }
}
static int Sum(int num1, int num2)
{
    return num1 + num2;
}

}

