namespace SimpleQL.Entities
{
  public class Email
  {
    public int Id { get; set; }
    public required string Address { get; set; }
    public EmailType Type { get; set; }
    public int ContractorId { get; set; }

    public virtual Contractor Contractor { get; set; }
  }

  public enum EmailType
  {
    Undefined, Business, Private
  }
}
