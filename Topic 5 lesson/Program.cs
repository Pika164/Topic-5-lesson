namespace Topic_5_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string magicWord, name;
            int age, ageResponse1, ageResponse2, ageResponse3, freezewaterTemp, waterTempCelcius, waterTempFahrenheit, waterTempKelvin;

            magicWord = "please";
            ageResponse1 = 16;
            ageResponse2 = 18;
            ageResponse3 = 25;
            waterTempCelcius = 0;
            waterTempFahrenheit = 32;
            waterTempKelvin = 273;

            //Topic 5.1 lesson task 1 below
            Console.Write("What is the magic word? ");
            magicWord = Console.ReadLine();
            if (magicWord == "please") ;
            Console.WriteLine("Your welcome!");
            Console.ReadLine();
            Console.Clear();
            //Topic 5.1 lesson task 2 below 
            Console.Write("Hey there. What's your name? ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ok, " + name + " , " + "how old are you? ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (age <= ageResponse1)
            {
                Console.WriteLine("You can't drive " + name);
            }
            Console.WriteLine();
            if (age <= ageResponse2)
            {
                Console.WriteLine("You can't vote " + name);
            }
            Console.WriteLine();
            if (age <= ageResponse3)
            {
                Console.WriteLine("You can't rent a car " + name);
            }
            Console.WriteLine();
            if (age>= ageResponse3)
            {
                Console.WriteLine("You can do anything thats legal");
            }
            Console.ReadLine();
            Console.Clear();
            //Topic 5.1 lesson task 3 below
            Console.Write("What's the temperature to freeze water? ");
            freezewaterTemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if  (freezewaterTemp == waterTempCelcius)
            {
                Console.WriteLine("Ahh yes, " + waterTempCelcius + " degrees Celcius is correct");
            }
            Console.WriteLine();
            if (freezewaterTemp == waterTempFahrenheit)
            {
                Console.WriteLine("Ahh yes, " + waterTempFahrenheit + " degrees Fahrenheit is correct");
            }
            Console.WriteLine();
            if (freezewaterTemp == waterTempKelvin)
            {
                Console.WriteLine("Ahh yes, " + waterTempKelvin + " degrees Kelvin is correct");
            }
        }
    }
}
