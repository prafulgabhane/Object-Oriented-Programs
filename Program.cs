using Object_Oriented_Programs;

namespace InventoryManagementDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Object Oriented Program");

            string path = "Macintosh HD/Users/prafulgabhane/Projects/Object Oriented Programs/Object Oriented Programs/Inventory.json";
            ReadData obj = new ReadData();
            var Info = obj.Read(path);

            //Storing the multiple values of Array in List.

            Console.WriteLine("\n");
            Console.WriteLine("Types of Rice:");
            for (int i = 0; i < Info.typesOfRice.Count; i++)
            {
                Console.WriteLine(Info.typesOfRice[i].name);
                Console.WriteLine(Info.typesOfRice[i].weight);
                Console.WriteLine(Info.typesOfRice[i].price);


            }
            Console.WriteLine("\n");
            Console.WriteLine("Types of Pulses is:");

            for (int i = 0; i < Info.typesOfPulses.Count; i++)
            {
                Console.WriteLine(Info.typesOfPulses[i].name);
                Console.WriteLine(Info.typesOfPulses[i].weight);
                Console.WriteLine(Info.typesOfPulses[i].price);



            }
            Console.WriteLine("\n");
            Console.WriteLine("Types of Wheat is:");

            for (int i = 0; i < Info.typesOfWheat.Count; i++)
            {
                Console.WriteLine(Info.typesOfWheat[i].name);
                Console.WriteLine(Info.typesOfWheat[i].weight);
                Console.WriteLine(Info.typesOfWheat[i].price);

            }
        }
    }
}