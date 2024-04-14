namespace SimpleQL.Entities
{
  public class CaseDebtor
  {
    public int Id { get; set; }
    public DebtorType Type { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int CaseId { get; set; }
    public int DebtorId { get; set; }

    public virtual Case Case { get; set; }
    public virtual Contractor Debtor { get; set; }
  }

  public enum DebtorType
  {
    Primary, Spouse, ThirdPerson, Representative, Attorney
  }
}
