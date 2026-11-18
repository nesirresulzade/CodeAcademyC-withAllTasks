

namespace C_withAllTasks
{
    public class Doctor : HospitalEmployee
    {
        public string specialization;
        public int experienceYears;
        public int patientCount;

        public Doctor(
                int employeeId,
                string fullName,
                byte age,
                decimal salary,
                string department,
                bool isOnDuty)
         : base(employeeId, fullName, age, salary, department, isOnDuty)
        {
            // bos saxlanib, lazim olsa burda yeni constructor yazilacaq
        }

        public void DiagnosePatient(string patientName)
        {
            patientCount++;
            Console.WriteLine($"Dr. {fullName} {patientName} " +
                $"adli xesteni muayine edir.");
        }

        public void PrescribeMedicine(string medicineName)
        {
            Console.WriteLine($"Dr. {fullName} xesteye {medicineName} " +
                $"dermanini teyin etdi.");
        }

        public void PerformSurgery(string surgeryType)
        {
            Console.WriteLine($"Dr. {fullName} {surgeryType} " +
                $"emeliyyatini heyata kecirir.");
        }
    }
}
