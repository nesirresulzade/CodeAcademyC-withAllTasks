

namespace C_withAllTasks
{
    public class Computer
    {
        public string computerName;
        public decimal price;
        public Processor processor;
        public RAM[] ramModules;

        public Computer(string computerName, decimal price, Processor processor, RAM[] ramModules)
        {
            this.computerName = computerName;
            this.price = price;
            this.processor = processor;
            this.ramModules = ramModules;
        }

        public void Start()
        {
            Console.WriteLine($"{computerName} kompüteri işə düşür..." +
                $"Prosessor və RAM yoxlanılır." +
                $"Kompüter uğurla işə salındı!");
        }

        public void DisplaySpecifications()
        {
            Console.WriteLine($"Komputerin adi: {computerName}");
            Console.WriteLine($"Qiymeti: {price} AZN");

            Console.WriteLine("\n--- Prosessor melumatlari ---");
            processor.DisplayInfo();

            Console.WriteLine("\n--- RAM melumatlari ---");
            int totalCapacity = 0;

            foreach (RAM ram in ramModules)
            {
                ram.DisplayInfo();
                totalCapacity += ram.capacity;
            }

            Console.WriteLine($"Umumi RAM: {totalCapacity} GB");
        }
    }
}
