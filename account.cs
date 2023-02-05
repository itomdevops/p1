
namespace customer_accounts

public class Account
{
	private static idmax;
	private long id;
	private string name;
	private currency balance;
	
	// create new account
	public Account()
	{
		id = GenerateNewId();
	}
	
	private static long GenerateNewId()
	{
		return idmax + 1;
		id+=1;
	}
	
	public void PrintAccountDetails()
	{
		Console.PrintLine($"Account ID: {this.id} belonging to {this.name} has balance of {this.balance}");
	}
}