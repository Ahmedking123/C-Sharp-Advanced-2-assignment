namespace C_Sharp_Advanced__2_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>
            {
                new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
                new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
                new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
                new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
                new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
                new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
                new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
                new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
                new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 },
                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
            };
            #region #1

            Func<Product, bool> predicate = x => x.Category == "Electronics";
            var Electronics = list.Where(predicate).ToList();
            Console.WriteLine("Electronics\n");
            print(Electronics);

            predicate = x => x.Price < 50;
            var Under50 = list.Where(predicate).ToList();
            Console.WriteLine("Under $50\n");
            print(Under50);

            predicate = x => x.Stock > 0;
            var InStock = list.Where(predicate).ToList();
            Console.WriteLine("In stock\n");
            print(InStock);


            predicate = x => x.Category == "Clothing" && x.Price < 100;
            var ClothingUnder100 = list.Where(predicate).ToList();
            Console.WriteLine("Clothing Under 100$\n");
            print(ClothingUnder100); 

            #endregion

        }
        static void print(List<Product> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Category} - ${item.Price}(Stock: {item.Stock})");
            }
        }
            
    }
}
