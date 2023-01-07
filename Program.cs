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
            Console.WriteLine("Types of Stock is:");
            for (int i = 0; i < Info.typesOfStock.Count; i++)
            {
                Console.WriteLine("Name: " +Info.typesOfStock[i].name);
                Console.WriteLine("NoOfshare: " +Info.typesOfStock[i].NoOfshare);
                Console.WriteLine("price: " +Info.typesOfStock[i].price);

                int val = Info.typesOfStock[i].NoOfshare * Info.typesOfStock[i].price;
                Console.WriteLine("The price for " + Info.typesOfStock[i].NoOfshare + " Stock is " + val);
                Console.WriteLine();
            }
        }
    }
}
