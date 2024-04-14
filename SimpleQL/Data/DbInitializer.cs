using Microsoft.EntityFrameworkCore;
using SimpleQL.Entities;

namespace SimpleQL.Data
{
  public class DbInitializer
  {
    private readonly ModelBuilder modelBuilder;

    public DbInitializer(ModelBuilder modelBuilder)
    {
      this.modelBuilder = modelBuilder;
    }

    public void Seed()
    {
      var fakeDate = new FakeData(10);
      modelBuilder.Entity<Case>().HasData(fakeDate.Cases);
      modelBuilder.Entity<Contractor>().HasData(fakeDate.Contractors);
      modelBuilder.Entity<Address>().HasData(fakeDate.Addresses);
      modelBuilder.Entity<Phone>().HasData(fakeDate.Phones);
      modelBuilder.Entity<Email>().HasData(fakeDate.Emails);
      modelBuilder.Entity<ContractorPropertyType>().HasData(fakeDate.ContractorPropertyTypes);
      modelBuilder.Entity<CaseDebtor>().HasData(fakeDate.CaseDebtors);
      modelBuilder.Entity<CaseProperty>().HasData(fakeDate.CaseProperties);
    }
  }
}
