

namespace C_withAllTasks
{
    public class Nurse : HospitalEmployee
    {
        public string assignedWard;
        public int patientsUnderCare;
        public string certificationLevel;

        public Nurse(
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

        public void MonitorPatient(string patientName)
        {
            patientsUnderCare++;
            Console.WriteLine($"Tibb bacisi {fullName} {patientName} " +
                $"adli xestenin veziyyetini musahide edir.");
        }

        public void AdministerMedication(string medicineName)
        {
            Console.WriteLine($"Tibb bacisi {fullName} xesteye " +
                $"{medicineName} dermanini verdi.");
        }

        public void RecordVitalSigns()
        {
            Console.WriteLine($"Tibb bacisi {fullName} {assignedWard} " +
                $"nomreli palatada xestelerin " +
                $"heyati gostericilerini qeyde alir.");
        }
    }
}