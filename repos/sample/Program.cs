namespace ExpenseTracker
{
    class Transaction
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public Transaction(string title, string description, decimal amount, DateTime date)
        {
            Title = title;
            Description = description;
            Amount = amount;
            Date = date;
        }
    }

    class ExpenseManager
    {
        private List<Transaction> transactions = new List<Transaction>();

        public void AddTransaction()
        {
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter Amount: ");
            decimal amount;
            if (decimal.TryParse(Console.ReadLine(), out amount))
            {
                if (amount < 0)
                {
                    amount = -Math.Abs(amount); // ensure negative value for expense
                }
                else
                {
                    amount = Math.Abs(amount); // ensure positive value for income
                }

                Console.Write("Enter Date (yyyy-mm-dd): ");
                DateTime date;
                if (DateTime.TryParse(Console.ReadLine(), out date))
                {
                    transactions.Add(new Transaction(title, description, amount, date));
                    Console.WriteLine("Transaction Added Successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid Date Format!");
                }
            }
            else
            {
                Console.WriteLine("Invalid Amount Format!");
            }

        }

        public void ViewExpenses()
        {
            Console.WriteLine("--- Expense Transactions ---");
            foreach (Transaction transaction in transactions)
            {
                if (transaction.Amount < 0)
                {
                    Console.WriteLine($"{transaction.Title}: {transaction.Description} (${Math.Abs(transaction.Amount)} on {transaction.Date.ToString("yyyy-MM-dd")})");
                }
            }
        }

        public void ViewIncome()
        {
            Console.WriteLine("--- Income Transactions ---");
            foreach (Transaction transaction in transactions)
            {
                if (transaction.Amount > 0)
                {
                    Console.WriteLine($"{transaction.Title}: {transaction.Description} (${Math.Abs(transaction.Amount)} on {transaction.Date.ToString("yyyy-MM-dd")})");
                }
            }
        }

        public void CheckAvailableBalance()
        {
            decimal balance = 0;
            foreach (Transaction transaction in transactions)
            {
                balance += transaction.Amount;
            }

            Console.WriteLine($"Available Balance: Rs{Math.Abs(balance)}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExpenseManager expenseManager = new ExpenseManager();

            while (true)
            {
                Console.WriteLine("1. AddTransaction");
                Console.WriteLine("2. View Expenses");
                Console.WriteLine("3. View Income");
                Console.WriteLine("4. Check Available Balance");

                Console.Write("Enter your choice (1-4): ");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            expenseManager.AddTransaction();
                            break;
                        case 2:
                            expenseManager.ViewExpenses();
                            break;
                        case 3:
                            expenseManager.ViewIncome();
                            break;
                        case 4:
                            expenseManager.CheckAvailableBalance();
                            break;
                        default:
                            Console.WriteLine("Wrong Choice Entered!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Choice Entered!");
                }

                Console.WriteLine();
            }
        }
    }
}