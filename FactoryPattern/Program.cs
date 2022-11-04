    namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greeting Adventurer. It's time to pick your class. You can be anything you want, so long as its a Mage or Fighter.");
            Console.WriteLine("Choose wisely!");
            Console.WriteLine("------------------------");
            bool isClass;
            do
            {
                Console.WriteLine("What would you like to be? Mage or Fighter?");
                string cha = Console.ReadLine().ToLower();
                if(cha == "mage" || cha == "fighter")
                {
                    var jones = AdventureFactory.GetCharacter(cha);
                    jones.Create();
                    isClass = true;
                }
                else
                {
                    Console.WriteLine("Listen, I only got the two classes. Mage or Fighter.");
                    isClass = false;
                }
            }
            while(isClass == false);
         
        }
    }
}
