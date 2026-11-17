using System.Security.Cryptography.X509Certificates;

namespace C_withAllTasks
{
    public class BankAccount
    {
        public int accountId;
        public string ownerName;
        public string accountNumber;
        public decimal balance;
        public string currency;
        public bool isActive;

        public BankAccount(int accountId, string ownerName, string accountNumber, decimal balance, string currency, bool isActive)
        {
            this.accountId = accountId;
            this.ownerName = ownerName;
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.currency = currency;
            this.isActive = isActive;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Hesaba elave edilen mebleg sifirdan boyuk olmalidir.");
                return;
            }
            balance += amount;
            Console.WriteLine("Hesaba mebleg elave edildi.");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Cixarilan mebleg sifirdan boyuk olmalidir.");
                return;
            }
            if (amount > balance)
            {
                Console.WriteLine("Yeterli mebleg yoxdur.");
                return;
            }
            balance -= amount;
            Console.WriteLine($"Yeni balans: {balance} {currency}");
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Transfer(BankAccount target, decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Kocurulen mebleg sifirdan boyuk olmalidir.");
                return;
            }
            if (amount > balance)
            {
                Console.WriteLine("Yeterli mebleg yoxdur.");
                return;
            }
            balance -= amount;
            target.balance += amount;
            Console.WriteLine($"Kocurme ugurlu oldu. Yeni balans: {balance} {currency}");
        }

        public void GetAccountInfo()
        {
            Console.WriteLine($"Hesab ID: {accountId}");
            Console.WriteLine($"Sahibin adi: {ownerName}");
            Console.WriteLine($"Hesab nomresi: {accountNumber}");
            Console.WriteLine($"Balans: {balance} {currency}");
            Console.WriteLine($"Aktivdir: {isActive}");
        }

        public void DeactivateAccount()
        {
            isActive = false;
            Console.WriteLine("Hesab deaktiv edildi.");
        }

        public void ActivateAccount()
        {
            isActive = true;
            Console.WriteLine("Hesab aktiv edildi.");
        }
    }
}
