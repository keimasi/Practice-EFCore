namespace Relation.One_to_One
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BankAccount BankAccount { get; set; }
    }
}
