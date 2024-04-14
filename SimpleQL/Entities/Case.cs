namespace SimpleQL.Entities
{
  public class Case
  {
    public int Id { get; set; }
    public string Number { get; set; }
    public string Description { get; set; }
    public decimal Debt { get; set; }
    public string Currency { get; set; }
    public int CreditorId { get; set; }
    public virtual Contractor Creditor { get; set; }
    public virtual ICollection<CaseDebtor> Debtors { get; set; }
    public virtual ICollection<CaseProperty> Properties { get; set; }
  }
}
