namespace Relation.One_to_One;

public class BankAccount
{
    public int Id { get; set; }
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public User User { get; set; }
    public int UserId { get; set; }
}