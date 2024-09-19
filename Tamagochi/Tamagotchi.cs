public class Tamagotchi
{
    Random random = new Random();
    public string Name;
    private int hunger = 0;
    private int boredom = 0;

    private bool isAlive = true;
    public bool deathScene = false;

    private List<string> words = new List<string>();

    public bool GetAlive()
    {
        if (hunger >= 10 || boredom >= 10)
        {
            return false;
        }
        return true;
    }


    public void Feed()
    {
        hunger -= 4;
        hunger = Math.Max(hunger, 0);
    }

    public void Hi()
    {
        if (words.Count > 0)
        {
            System.Console.WriteLine($"[{Name}] said " + words[Random.Shared.Next(0, words.Count)]);
            ReduceBoredom();
        }
        else
        {
            System.Console.WriteLine("Bro is stupid and can not speak. Try teaching him some words");
        }
    }

    public void Teach(string word)
    {
        Console.Clear();
        Console.WriteLine($"[{Name}] learns: {word}");
        words.Add(word);
        ReduceBoredom();
    }

    public void Tick()
    {
        isAlive = GetAlive();
        if (isAlive)
        {
            hunger++;
            boredom++;
            if (boredom >= 7)
            {
                System.Console.WriteLine($"[{Name}] is bored.");
            }
            if (hunger >= 7)
            {
                System.Console.WriteLine($"[{Name}] is hungry.");
            }
            PrintStats();

        }
        else
        {
            TamagotchiIsDead();
        }
    }


    public void PrintStats()
    {
        Console.WriteLine($"\n[{Name}] Stats are: \nHunger: " + hunger + "\nBoredom: " + boredom);
    }


    private void ReduceBoredom()
    {
        boredom -= 4;
        boredom = Math.Max(boredom, 0);
    }

    public void TamagotchiIsDead()
    {
        Console.Clear();
        Console.WriteLine($"[{Name}] has died. You are a horrible person");
        System.Console.WriteLine("Press ENTER to get a new tamagotchi");
        Console.ReadLine();
        Console.Clear();
    }
}


/* ---------------------------------------------------------------------------
Tamagotchi
− hunger: int
− boredom: int
− words: List<string>
− isAlive: bool
+ Name: string
----------------------------------------------------------------
+ Feed(): void
+ Hi(): void
+ Teach(word: string): void
+ Tick(): void
+ PrintStats(): void
+ GetAlive(): bool
− ReduceBoredom(): void
*/