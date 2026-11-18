

namespace C_withAllTasks
{
    public class RAM
    {
        public string brand;
        public int capacity; // GB
        public string type; // DDR4, DDR5

        public RAM(string brand, int capacity, string type)
        {
            this.brand = brand;
            this.capacity = capacity;
            this.type = type;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"RAM: {brand}," +
                $" Capacity: {capacity} GB, " +
                $"Type: {type}");
        }
    }
}
