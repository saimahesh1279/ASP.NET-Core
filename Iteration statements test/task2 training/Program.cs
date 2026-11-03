
//🟩 Task 2 — Product Search System
//Data:
//string[] products =
//{
//    "iPhone 17 Pro",
//    "Samsung Galaxy S26",
//    "Google Pixel 10",
//    "OnePlus 14 Pro",
//    "Samsung Galaxy S26 Ultra",
//    "iPhone 17",
//    "Google Pixel 10 Pro"
//};

//Questions:
//1.Print all products.
//2.Find all products containing "Pro".
//3. Find all Samsung products.
//4. Find all iPhone products.
//5. Count products containing "Pro".
//6. Find the longest product name.
//7. Find the shortest product name.
//8. Sort the products alphabetically.
//9. Check whether "OnePlus 14 Pro" exists.
//10. Find the index of "Google Pixel 10".
//11. Replace "Pro" with "Premium" in matching product names.
//12. Print the final product list.
namespace task2_training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] products =
            {
                "iPhone 17 Pro",
                "Samsung Galaxy S26",
                "Google Pixel 10",
                "OnePlus 14 Pro",
                "Samsung Galaxy S26 Ultra",
                "iPhone 17",
                "Google Pixel 10 Pro"
            };

            task1AllProducts(products);

        }

        public static void task1AllProducts(string[] products)
        {
            for(int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i]);
                Console.WriteLine("---------------");
            }
        }
    }
}
