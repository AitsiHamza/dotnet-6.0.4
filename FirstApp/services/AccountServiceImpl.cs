using FirstApp.entities;

namespace FirstApp.services;

public class AccountServiceImpl : IAccountService
{
    private readonly List<Account> accounts = new List<Account>();
    
    public Account AddNewAccount(string id, string name, string email, string password, double debit, double balance)
    {
        Account account = new Account(id,name,email,password,debit,balance);
        accounts.Add(account);
        return account;
    }

    public List<Account> GetAllAccounts()
    {
        return accounts;
    }

    public Account? GetAccountById(string id)
    {
        Account? account = null;
        accounts.ForEach(delegate(Account a) {
            if (a!.id.Equals(id))
            {
                account = a;
            } });
        return account;
    }

    public List<Account> GetDebitedAccounts()
    {
        List<Account> debitedAccounts = new List<Account>();
        accounts.ForEach(delegate(Account a) {
            if (a!.debit>0)
            {
                debitedAccounts.Add(a);
            } });
        return debitedAccounts;
    }

    public double GetBalanceAvg()
    {
        double avg = 0;
        accounts.ForEach(delegate(Account a)
        {
            avg += a.balance;
        });
        avg /= accounts.Count;
        return avg;
    }
}