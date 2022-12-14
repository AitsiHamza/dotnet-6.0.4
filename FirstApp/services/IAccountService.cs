using FirstApp.entities;

namespace FirstApp.services;

public interface IAccountService
{
    Account AddNewAccount(string id, string name, string email, string password, double debit, double balance);
    List<Account> GetAllAccounts();
    Account? GetAccountById(String id);
    List<Account> GetDebitedAccounts();
    double GetBalanceAvg();

}