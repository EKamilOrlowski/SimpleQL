namespace SimpleQL.Entities
{
  public class Phone
  {
    public int Id { get; set; }
    public required string Number { get; set; }
    public PhoneType Type { get; set; }
    public int ContractorId { get; set; }

    public virtual Contractor Contractor { get; set; }
  }

  public enum PhoneType
  {
    Undefined, Ok, NoResponse
  }
}
