namespace FirstApp.entities;

public class Account
{
    public String id { get; set; }
    public String name { get; set; }
    public String email { get; set; }
    public String password { get; set; }
    public double debit { get; set; } = 0;
    public double balance { get; set; } = 0;

    public Account()
    {
    }

    public Account(string id, string name, string email, string password, double debit, double balance)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.password = password;
        this.debit = debit;
        this.balance = balance;
    }

    public override string ToString()
    {
        return id+"\t"+name+"\t"+email+"\t"+debit+"\t"+balance;
    }
}