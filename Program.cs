using System.Diagnostics;
using System.Numerics;

class Stuff
{
    static void Main(string[] args)
    {
        Ilala iIlala = new Ilala();

        while (true)
        {
            Console.WriteLine("WELCOME TO RECIPE BOOK!!");
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. Reset quantity");
            Console.WriteLine("4. Display");
            Console.WriteLine("5. Scale");
            Console.WriteLine("6. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) {
                case 1:
                    iIlala.CreateRecipe();

                    break;
                case 2:

                    iIlala.DeleteRecipe();

                    break;
                case 3:

                    iIlala.ResetQuantity();

                    break;
                case 4:
                    iIlala.DisplayRecipe();
                    break;
                case 5:
                    iIlala.ScaleQuantity();
                    break;
                case 6:
                    iIlala.Exit();
                    break;
                default:
                    Console.WriteLine("Invalid option.Please enter a number");
                    break;
            }
        }
    }
    class Ingredient
    {
        // Public properties to store the ingredient details
        public string ingreName { get; }
        public float ingreQuantity { get; set; }
        public string nit { get; }

        // Constructor to initialize the ingredient details
        public Ingredient(string ingreName, float ingreQuantity, string measurementUnit)
        {
            IngreName = ingreName;
            IngreQuantity = ingreQuantity;
            MeasurementUnit = measurementUnit;
        }

        // Method to reset the quantity of the ingredient
        public void ResetQuantity()
        {
            // Reset the quantity to the original value
        }
    }
    class Ilala
    {
        private Ingret[] ingrets;
        private int ingreNo;
      //  private Ingredient[] ingredients;
        private int stepsNo;
        private string[] thingy;

        public void CreateRecipe()

        {
            Console.WriteLine("Enter the number of ingredients:");
            ingreNo = int.Parse(Console.ReadLine());

            Ingret = new Ingrets[ingreNo];

            for (int i = 0; i < ingreNo; i++)
            {
                Console.WriteLine($"Enter details for ingredient #{i + 1}:");
                Console.Write("Name: ");
                string ingreNname = Console.ReadLine();
                Console.Write("Quantity: ");
                float ingreQuantity = float.Parse(Console.ReadLine());
                Console.Write("Unit of measurement: ");
                string measurementUnit = Console.ReadLine();

                // Create a new Ingredient object and add it to the array
                ingrets[i] = new Ingret(ingreName, ingreQuantity, measurementUnit);

            }
            Console.WriteLine("Enter number of steps");
            int stepsNo = int.Parse(Console.ReadLine());

            thingy =  new string[stepsNo];

            for(int i = 0;i < stepsNo; i++)
            {
                Console.WriteLine("Enter steps{i + 1} description:");
                thingy[i] = Console.ReadLine();
            }
            Console.WriteLine("Sucessfully saved recipe!!");
        }
        public void DisplayRecipe()
        {
            Console.WriteLine("Recipe ");

            Console.WriteLine("Ingredients:");
            for(int i = 0; i < ingreNo; i++)
            {
                Ingret ingret = ingrets[i];

                Console.WriteLine($"{i + 1}. {ingret.Name}: {ingret.Quantity} {ingret.Unit}");

            }

        }
        public void DeleteRecipe()
        {

            ingreNo = 0;

            ingreQuantity = null;

            stepsNo = 0;

            steps = null;

            Console.WriteLine("Deleted sucessfully");
        }

        public void ScaleQuantity()
        {
            Console.WriteLine("Type in either one of the following unit of measurement:");

            Console.WriteLine("0.5  or   2   or    3");

            float factor = float.Parse(Console.ReadLine()));

            for (int i; i < ingreQuantity;i++)

            {

                Ingrets[i].ingreQuantity += factor;

            }


        }

        public void ResetQuantity()
        {
            for(int i;i<ingreNo;i++){
                Ingrets[i].ResetQuantiy();
                    }
            Console.WriteLine("Quantity reset");
        }

        
    }



































}
}
