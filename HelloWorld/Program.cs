using HelloWorld.Math;

internal partial class Program
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }



    private static void Main(string[] args)
    {
        var method = ShippingMethod.Express;
        Console.WriteLine((int)method);

        var methodId = 3;
        Console.WriteLine((ShippingMethod)methodId);

        Console.WriteLine(method.ToString());

        var methodName = "Express";
       Enum.Parse(typeof(ShippingMethod), methodName);


        var freddie = new Person();
        freddie.firstName = "Fredrick";
        freddie.lastName = "Ochieng";
        freddie.Introduce();


        Calculator calculator = new Calculator();
        var result = calculator.Add(1, 2);
        Console.WriteLine(result);


        var numbers = new int[3];   
        numbers[0] = 1;

        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers[2]);




        byte number = 7;
        int count = 10;
        float totalPrice = 20.95f;
        char character = 'A';
        string firstName = "Freddie";
        bool isWorking = false;

        Console.WriteLine(number);
        Console.WriteLine(count);
        Console.WriteLine(totalPrice);
        Console.WriteLine(character);
        Console.WriteLine(firstName);
        Console.WriteLine(isWorking);


        int hour = 10;
        if (hour > 0 && hour < 12)
            Console.WriteLine("Its Morning.");
        else if (hour >= 12 && hour <18)
                Console.WriteLine("Its Afternoon");
        else Console.WriteLine("Its Evening");



        try
        {
            var numberVal = "1234";
            byte b = Convert.ToByte(numberVal);
            Console.WriteLine(b);
        }
        catch (Exception)
        {

            Console.WriteLine("The number could not be converted to a byte.");
        }
    }
}