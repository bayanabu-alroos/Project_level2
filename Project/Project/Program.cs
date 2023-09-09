#region Create File
using Project.Classes;

string folderPath = @"C:\Users\bayan\OneDrive\Desktop\Project 2\";
if (!File.Exists(folderPath))
{
    if (!Directory.Exists(folderPath))
    {
        try
        {
            Directory.CreateDirectory(folderPath);
            Console.WriteLine("Create Folder Project 2 in desktop");
            #region Create File Customer
            Console.WriteLine("Enter Five Names of Customers:");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter phone: ");
                string phone = Console.ReadLine();

                Console.Write("Enter address: ");
                string address = Console.ReadLine();

                Console.Write("Enter age: ");
                int age;
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.Write("Invalid input. Please enter a valid age: ");
                }
                var customer = new Customer
                {
                    Id = i,
                    Name = name,
                    Phone = phone,
                    Address = address,
                    Age = age
                };
                await Helper.CreateFile(folderPath, "Customer.json", customer);
            }
            var customers = await Helper.ReadFile<Customer>(folderPath, "Customer.json");
            var customernamesWithA = customers.Where(u => u.Name.Contains('A'));
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*******************************************************");
            foreach (var person in customernamesWithA)
            {

                Console.WriteLine($"{person.Id} - The name of the customer is => {person.Name} \t" +
                    $" age is => {person.Age} \t " +
                    $"Number Phone is => {person.Phone} \t" +
                    $"Address is => {person.Address}");
            }
            #endregion
            #region Create File Category
            Console.WriteLine("Enter Five Names of Categories:");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter Name Category: ");
                string name = Console.ReadLine();

                Console.Write("Enter Type: ");
                string type = Console.ReadLine();

                var category = new Category
                {
                    Id = i,
                    Name = name,
                    Type = type
                };
                await Helper.CreateFile(folderPath, "Category.json", category);
            }
            var categories = await Helper.ReadFile<Category>(folderPath, "Category.json");
            var categorynamesWithC = categories.Where(u => u.Name.Contains('C'));
            Console.WriteLine("*******************************************************");
            foreach (var cat in categorynamesWithC)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{cat.Id} - The name of the Category is => {cat.Name} \t" +
                    $"Type is => {cat.Type} ");
            }
            #endregion
            #region Create File Item
            Console.WriteLine("Enter Tine Names of Items:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter Name Item: ");
                string name = Console.ReadLine();

                Console.Write("Enter description item: ");
                string description = Console.ReadLine();

                Console.Write("Enter Price: ");
                decimal price = Convert.ToDecimal(Console.ReadLine());
                var item = new Item
                {
                    Id = i + 1,
                    Name = name,
                    Price = price,
                    Description = description
                };
                await Helper.CreateFile(folderPath, "Item.json", item);
            }
            var items = await Helper.ReadFile<Item>(folderPath, "Item.json");
            var orderedItems = items.OrderByDescending(i => i.Name);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*******************************************************");
            foreach (var iteam in orderedItems)
            {
                Console.WriteLine($"{iteam.Id} - The name of the Item is => {iteam.Name} \t" +
                    $"Price item  is => {iteam.Price} \t" +
                    $"Description item is => {iteam.Description}");
            }
            #endregion
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    else
    {
        Console.WriteLine("The Folder  Project 2 already exists.");
        #region Create File Customer
        //Console.WriteLine("Enter Five Names of Customers:");

        //for (int i = 1; i <= 5; i++)
        //{
        //    Console.Write("Enter name: ");
        //    string name = Console.ReadLine();

        //    Console.Write("Enter phone: ");
        //    string phone = Console.ReadLine();

        //    Console.Write("Enter address: ");
        //    string address = Console.ReadLine();

        //    Console.Write("Enter age: ");
        //    int age;
        //    while (!int.TryParse(Console.ReadLine(), out age))
        //    {
        //        Console.Write("Invalid input. Please enter a valid age: ");
        //    }
        //    var customer = new Customer
        //    {
        //        Id = i,
        //        Name = name,
        //        Phone = phone,
        //        Address = address,
        //        Age = age
        //    };
        //    await Helper.CreateFile(folderPath, "Customer.json", customer);
        //}
        var customers = await Helper.ReadFile<Customer>(folderPath, "Customer.json");
        var customernamesWithA = customers.Where(u => u.Name.Contains('A'));

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("*******************************************************");
        foreach (var person in customernamesWithA)
        {
            Console.WriteLine($"{person.Id} - The name of the customer is => {person.Name} \t" +
                $" age is => {person.Age} \t " +
                $"Number Phone is => {person.Phone} \t" +
                $"Address is => {person.Address}");
        }
        #endregion
        #region Create File Category
        //Console.WriteLine("Enter Five Names of Categories:");

        //for (int i = 1; i <= 5; i++)
        //{
        //    Console.Write("Enter name: ");
        //    string name = Console.ReadLine();

        //    Console.Write("Enter address: ");
        //    string type = Console.ReadLine();

        //    var category = new Category
        //    {
        //        Id = i,
        //        Name = name,
        //        Type = type
        //    };
        //    await Helper.CreateFile(folderPath, "Category.json", category);
        //}
        var categories = await Helper.ReadFile<Category>(folderPath, "Category.json");
        var categorynamesWithC = categories.Where(u => u.Name.Contains('C'));
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("*******************************************************");
        foreach (var cat in categorynamesWithC)
        {
            Console.WriteLine($"{cat.Id} - The name of the Category is => {cat.Name} \t" +
                $"Type is => {cat.Type} ");
        }
        #endregion
        #region Create File Item
        //Console.WriteLine("Enter Tine Names of Items:");
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.Write("Enter name: ");
        //    string name = Console.ReadLine();

        //    Console.Write("Enter phone: ");
        //    string phone = Console.ReadLine();

        //    Console.Write("Enter description item: ");
        //    string description = Console.ReadLine();

        //    Console.Write("Enter Price: ");
        //    decimal price = Convert.ToDecimal(Console.ReadLine());
        //    var item = new Item
        //    {
        //        Id = i,
        //        Name = name,
        //        Price = price,
        //        Description = description
        //    };
        //    await Helper.CreateFile(folderPath, "Item.json", item);
        //}
        var items = await Helper.ReadFile<Item>(folderPath, "Item.json");
        var orderedItems = items.OrderByDescending(i => i.Name);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("*******************************************************");
        foreach (var iteam in orderedItems)
        {
            Console.WriteLine($"{iteam.Id} - The name of the Item is => {iteam.Name} \t" +
                $"Price item  is => {iteam.Price} \t" +
                $"Description item is => {iteam.Description}");
        }
        #endregion
    }
}
#endregion

var randomString = Extenstion.CreateRandomString(10);
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Random String: {randomString}");

var randomDoubles = Extenstion.CreateRandomArray<double>(5);
Console.WriteLine("Random Double Array: ");
foreach (var num in randomDoubles)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write($"{num}\t");
}

var randomInt = Extenstion.GetRandomInt(5, 20);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(randomInt.ToString());

#region Two-Dimensional Arrays
int[,] arr = new int[4, 5];
Random random = new Random();
Console.WriteLine("The array random between 1 -  100 is:");

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 100);
        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}

var flatArray = arr.Cast<int>().ToArray();

Console.WriteLine("\nMax value: " + flatArray.Max(x => x));
Console.WriteLine("Min value: " + flatArray.Min(x => x));
Console.WriteLine("Sum: " + flatArray.Sum(x => x));
Console.WriteLine("Average: " + flatArray.Average(x => x));
#endregion