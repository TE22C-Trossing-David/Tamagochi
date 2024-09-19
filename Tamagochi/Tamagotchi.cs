public class Tamagotchi
{
    Random random = new Random();
    public string Name;
    private int hunger;
    private int boredom;

    private bool isAlive;

    private List<string> words = new List<string>();

    public bool GetAlive()
    {
        if (hunger >= 100 || boredom >= 100)
        {
            return false;
        }
        return true;
    }

    public void Feed()
    {
        hunger -= 10;
    }

    public void Hi()
    {
        System.Console.WriteLine(words[Random.Shared.Next(0, words.Count)]);
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        Console.WriteLine($" [{Name}] learns: {word}");
        words.Add(word);
        ReduceBoredom();
    }

    public void Tick()
    {
        if (isAlive)
        {
            hunger++;
            boredom++;
        }
        else
        {
            TamagotchiIsDead();
        }
    }


    public void PrintStats()
    {

    }


    private void ReduceBoredom()
    {
        boredom -= 10;
    }

    private void TamagotchiIsDead()
    {
        Console.WriteLine("Your tamagotchi has died. You are a horrible person");

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