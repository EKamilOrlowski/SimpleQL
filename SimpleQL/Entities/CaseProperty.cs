
namespace SimpleQL.Entities
{
  public class CaseProperty
  {
    public int Id { get; set; }
    public string? Value { get; set; }
    public int CaseId { get; set; }
    public int ContractorPropertyId { get; set; }

    public virtual Case Case { get; set; }
    public virtual ContractorPropertyType ContractorProperty { get; set; }
  }
}
