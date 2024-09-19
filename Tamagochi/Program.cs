using System.Diagnostics.CodeAnalysis;

Tamagotchi tom = new Tamagotchi();
while (true)
{
    tom.deathScene = false;
    System.Console.WriteLine("This is your stupid pet. What do you want him to be called?");
    tom.Name = Console.ReadLine();


    System.Console.WriteLine($"This is [{tom.Name}]. Please take care of [{tom.Name}] for me");
    System.Console.WriteLine($"[{tom.Name}] will become hungry and bored. Please feed him and teach him new words.");
    Console.ReadLine();
    Console.Clear();

    while (tom.GetAlive() == true)
    {
        tom.Tick();
        System.Console.WriteLine("What do you want to do?");
        System.Console.WriteLine($"\n1. Feed [{tom.Name}]");
        System.Console.WriteLine($"\n2. Teatch [{tom.Name}] a new word");
        System.Console.WriteLine($"\n3. Make [{tom.Name}] speak");
        System.Console.WriteLine($"\n4. Wait for [{tom.Name}] to die.");

        string Choice = Console.ReadLine();
        Console.Clear();

        if (Choice == "1")
        {
            tom.Feed();
        }

        if (Choice == "2")
        {
            Console.WriteLine("What do you want to teach him");
            tom.Teach(Console.ReadLine());
        }
        if (Choice == "3")
        {
            tom.Hi();
        }
        if (Choice == "4")
        {
            System.Console.WriteLine($"You waited for [{tom.Name}] to die you monster");
        }
    }
    tom.TamagotchiIsDead();
}