namespace DataTransferObjectIntro.Entities
{
    public class User
    {
        public User(int id, string name, string creditCardNumber)
        {
            Id = id;
            Name = name;
            CreditCardNumber = creditCardNumber;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string CreditCardNumber { get; private set; }
    }
}