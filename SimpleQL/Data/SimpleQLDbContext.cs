using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleQL.Entities;

namespace SimpleQL.Data
{
  public class SimpleQLDbContext : IdentityDbContext<User>
  {
    public DbSet<Address> Address { get; set; }
    public DbSet<Case> Case { get; set; }
    public DbSet<Contractor> Contractor { get; set; }
    public DbSet<Email> Email { get; set; }
    public DbSet<Phone> Phone { get; set; }
    public DbSet<CaseDebtor> CaseDebtor { get; set; }
    public DbSet<CaseProperty> CaseProperty { get; set; }
    public DbSet<ContractorPropertyType> ContractorPropertyType { get; set; }

    public SimpleQLDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Contractor>()
        .HasMany(c => c.ReceivableCases)
        .WithOne(c => c.Creditor)
        .HasForeignKey(c => c.CreditorId);

      modelBuilder.Entity<CaseDebtor>()
        .HasKey(cd => new { cd.CaseId, cd.DebtorId });

      modelBuilder.Entity<CaseDebtor>()
        .HasOne(c => c.Case)
        .WithMany(c => c.Debtors)
        .HasForeignKey(c => c.CaseId);

      modelBuilder.Entity<CaseDebtor>()
       .HasOne(c => c.Debtor)
       .WithMany(c => c.DebtCases)
       .HasForeignKey(c => c.DebtorId);

      modelBuilder.Entity<CaseProperty>()
        .HasOne(p => p.Case)
        .WithMany(c => c.Properties)
        .HasForeignKey(p => p.CaseId);

      modelBuilder.Entity<CaseProperty>()
        .HasOne(p => p.ContractorProperty)
        .WithMany(c => c.CaseProperties)
        .HasForeignKey(p => p.ContractorPropertyId);

      modelBuilder.Entity<ContractorPropertyType>()
        .HasOne(p => p.Contractor)
        .WithMany(c => c.PropertyTypes)
        .HasForeignKey(p => p.ContractorId);

      modelBuilder.Entity<Address>()
        .HasOne(a => a.Contractor)
        .WithMany(c => c.Addresses)
        .HasForeignKey(p => p.ContractorId);

      modelBuilder.Entity<Phone>()
        .HasOne(a => a.Contractor)
        .WithMany(c => c.Phones)
        .HasForeignKey(p => p.ContractorId);

      modelBuilder.Entity<Email>()
        .HasOne(a => a.Contractor)
        .WithMany(c => c.Emails)
        .HasForeignKey(p => p.ContractorId);

      new DbInitializer(modelBuilder).Seed();
    }
  }
}
