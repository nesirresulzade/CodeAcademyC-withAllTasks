

namespace C_withAllTasks
{
    public class Processor
    {
        public string brand;
        public string model;
        public int cores;
        public double frequency; // GHz

        public Processor(string brand, string model, int cores, double frequency)
        {
            this.brand = brand;
            this.model = model;
            this.cores = cores;
            this.frequency = frequency;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Processor: {brand} {model}," +
                $" Cores: {cores}, " +
                $"Frequency: {frequency} GHz");
        }
    }
}
