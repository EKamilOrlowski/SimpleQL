namespace SimpleQL.Entities
{
  public class Address
  {
    public int Id { get; set; }
    public string Street { get; set; }
    public string BuildingNumber { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public int ContractorId { get; set; }

    public virtual Contractor Contractor { get; set; }
  }
}
