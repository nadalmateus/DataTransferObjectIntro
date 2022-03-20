namespace DataTransferObjectIntro.Dto
{
    public class UserDto
    {
        public int Id { get; private set; }
        public string? Name { get; set; }
        public string? CreditCardNumber { get; set; }
    }
}