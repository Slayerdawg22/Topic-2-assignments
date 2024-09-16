namespace Topic_2_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I will now count my chickens:");
            Console.WriteLine("Hens" + (10 + 5 * 2));
            Console.WriteLine("Roosters" + (25 + 30 / 6));
            Console.WriteLine("six" + 6);

            Console.WriteLine("Now I will count the eggs");
            Console.WriteLine(11.0 / 2);

            Console.WriteLine("Is it true that 3+2<5-7?");

            Console.WriteLine(3 + 2 < 5 - 7);

            Console.WriteLine("What is 3+2" + (3 + 2));
            Console.WriteLine("What is 5-7" + (5 - 7));
            Console.WriteLine("Oh that's why it's" + (3 + 2 < 5 - 7));

            Console.WriteLine(8 * 21);
            Console.WriteLine("Eggs cost 6$ for 12 eggs " + (6.0 / 12).ToString("C"));
            Console.WriteLine("Tax on 79.99 would be " + (79.99 * 0.13).ToString("C"));
            Console.WriteLine(5.6 * 2.54);
        }
    }
}
