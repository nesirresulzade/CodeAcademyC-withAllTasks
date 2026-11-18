//Base classimizdir bu yeni miras alacagimiz classdir ( parent )

namespace C_withAllTasks
{
    public class HospitalEmployee
    {
        public int employeeId;
        public string fullName;
        public byte age;
        public decimal salary;
        public string department;
        public bool isOnDuty;

        public HospitalEmployee(
            int employeeId,
            string fullName,
            byte age,
            decimal salary,
            string department,
            bool isOnDuty)

        {
            this.employeeId = employeeId;
            this.fullName = fullName;
            this.age = age;
            this.salary = salary;
            this.department = department;
            this.isOnDuty = isOnDuty;
        }

        public void StartShift()
        {
            isOnDuty = true;
        }

        public void EndShift()
        {
            isOnDuty = false;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Employee ID: {employeeId}");
            Console.WriteLine($"Full Name: {fullName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Salary: {salary:C}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"On Duty: {isOnDuty}");
        }

        public void CalculateSalary()
        {
            decimal totalSalary = salary;
            Console.WriteLine($"Total Salary: {totalSalary:C}");
        }
    }
}
