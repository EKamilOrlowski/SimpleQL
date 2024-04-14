namespace SimpleQL.Entities
{
  public class Contractor
  {
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? CompanyName { get; set; }

    public virtual ICollection<CaseDebtor> DebtCases { get; set; }
    public virtual ICollection<Case> ReceivableCases { get; set; }
    public virtual ICollection<Address> Addresses { get; set; }
    public virtual ICollection<Phone> Phones { get; set; }
    public virtual ICollection<Email> Emails { get; set; }
    public virtual ICollection<ContractorPropertyType> PropertyTypes { get; set; }
  }
}
