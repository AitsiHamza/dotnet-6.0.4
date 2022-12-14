// See https://aka.ms/new-console-template for more information

using FirstApp.entities;
using FirstApp.services;

IAccountService service = new AccountServiceImpl();

/***********AddNewAccount***********/
Console.WriteLine("AddNewAccount");
service.AddNewAccount("aaa1", "hamza", "hamza@gmail.com", "1234", 132.02, 1000000);
service.AddNewAccount("aaa2", "meriem", "meriem@gmail.com", "1234", 0.02, 8000000);
service.AddNewAccount("aaa3", "aitsi", "aitsi@gmail.com", "1234", 0, 4000000);
service.AddNewAccount("aaa4", "amine", "amine@gmail.com", "1234", 0, 2000000);

/***********GetAllAccounts***********/
Console.WriteLine("\nGetAllAccounts");
List<Account> accounts = service.GetAllAccounts();
accounts.ForEach(delegate(Account a) { Console.WriteLine(a); });

/***********GetAccountById***********/
Console.WriteLine("\nGetAccountById");
Console.WriteLine(service.GetAccountById("aaa1"));

/***********GetAllAccounts***********/
Console.WriteLine("\nGetDebitedAccounts");
List<Account> debitedAccounts = service.GetDebitedAccounts();
accounts.ForEach(delegate(Account a) { Console.WriteLine(a); });

/***********GetBalanceAvg***********/
Console.WriteLine("\nGetBalanceAvg");
Console.WriteLine(service.GetBalanceAvg());