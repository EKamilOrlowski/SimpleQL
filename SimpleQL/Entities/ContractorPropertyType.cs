namespace SimpleQL.Entities
{
  public class ContractorPropertyType
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public PropertyType Type { get; set; }
    public int ContractorId { get; set; }

    public virtual Contractor Contractor { get; set; }
    public virtual ICollection<CaseProperty> CaseProperties { get; set; }
  }

  public enum PropertyType
  {
    StartDate, EndDate, Product
  }
}
