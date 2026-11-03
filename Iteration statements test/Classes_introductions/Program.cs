namespace Classes_introductions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // main logic here
            Employee prgramins = new Employee();

            prgramins.id=2;
            Console.WriteLine($"{prgramins.id}");

    }
        
    }
    
     public class Employee()
    {
        public int id;
    }
}
