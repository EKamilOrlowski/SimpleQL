using Bogus;
using SimpleQL.Entities;

namespace SimpleQL.Data
{
  public class FakeData
  {
    public List<Case> Cases = new();
    public List<Contractor> Contractors = new();
    public List<Address> Addresses = new();
    public List<Phone> Phones = new();
    public List<Email> Emails = new();
    public List<ContractorPropertyType> ContractorPropertyTypes = new();
    public List<CaseDebtor> CaseDebtors = new();
    public List<CaseProperty> CaseProperties = new();
    private int v;

    public FakeData(int count)
    {
      Init(count);
    }

    private void Init(int count)
    {
      var contractorPropertyTypeId = 1;
      var contractorPropertyTypeFaker = new Faker<ContractorPropertyType>()
        .RuleFor(p => p.Id, _ => contractorPropertyTypeId++)
        .RuleFor(p => p.Name, f => f.Lorem.Word());

      var addressId = 1;
      var addressFaker = new Faker<Address>()
        .RuleFor(p => p.Id, _ => addressId++)
        .RuleFor(p => p.Street, f => f.Address.StreetAddress())
        .RuleFor(p => p.BuildingNumber, f => f.Address.BuildingNumber())
        .RuleFor(p => p.City, f => f.Address.City())
        .RuleFor(p => p.State, f => f.Address.State())
        .RuleFor(p => p.Zip, f => f.Address.ZipCode());

      var phoneId = 1;
      var phoneFaker = new Faker<Phone>()
        .RuleFor(p => p.Id, _ => phoneId++)
        .RuleFor(p => p.Number, f => f.Phone.PhoneNumber())
        .RuleFor(p => p.Type, f => f.Random.Enum<PhoneType>());

      var emailId = 1;
      var emailFaker = new Faker<Email>()
        .RuleFor(p => p.Id, _ => emailId++)
        .RuleFor(p => p.Address, f => f.Internet.Email())
        .RuleFor(p => p.Type, f => f.Random.Enum<EmailType>());

      var contractorId = 1;
      var contractorFaker = new Faker<Contractor>()
        .RuleFor(p => p.Id, _ => contractorId++)
        .RuleFor(p => p.FirstName, f => f.Person.FirstName)
        .RuleFor(p => p.LastName, f => f.Person.LastName)
        .RuleFor(p => p.CompanyName, f => f.Company.CompanyName())
        .RuleFor(p => p.PropertyTypes, (f, p) =>
        {
          contractorPropertyTypeFaker.RuleFor(cpt => cpt.ContractorId, _ => p.Id);
          List<ContractorPropertyType> propertyTypes = new();
          foreach (var propertyType in Enum.GetValues<PropertyType>())
          {
            contractorPropertyTypeFaker.RuleFor(cpt => cpt.Type, _ => propertyType);
            propertyTypes.Add(contractorPropertyTypeFaker.Generate());
          }

          ContractorPropertyTypes.AddRange(propertyTypes);
          return null;
        })
        .RuleFor(p => p.Addresses, (f, p) =>
        {
          addressFaker.RuleFor(a => a.ContractorId, _ => p.Id);
          var addreses = addressFaker.GenerateBetween(0, 3);
          Addresses.AddRange(addreses);
          return null;
        })
        .RuleFor(p => p.Phones, (f, p) =>
        {
          phoneFaker.RuleFor(p => p.ContractorId, _ => p.Id);
          var phones = phoneFaker.GenerateBetween(0, 10);
          Phones.AddRange(phones);
          return null;
        })
        .RuleFor(p => p.Emails, (f, p) =>
        {
          emailFaker.RuleFor(e => e.ContractorId, _ => p.Id);
          var emails = emailFaker.GenerateBetween(0, 5);
          Emails.AddRange(emails);
          return null;
        });

      var caseDebtorId = 1;
      var caseDebtorFaker = new Faker<CaseDebtor>()
        .RuleFor(p => p.Id, _ => caseDebtorId++)
        .RuleFor(p => p.Type, f => f.Random.Enum<DebtorType>())
        .RuleFor(p => p.StartDate, f => f.Date.Past())
        .RuleFor(p => p.EndDate, f => f.Date.Soon())
        .RuleFor(p => p.Debtor, (f, p) =>
        {
          var contractor = contractorFaker.Generate();
          p.DebtorId = contractor.Id;
          Contractors.Add(contractor);
          return null;
        });

      var caseId = 1;
      var casePropertyId = 1;
      var caseFaker = new Faker<Case>()
        .RuleFor(p => p.Id, _ => caseId++)
        .RuleFor(p => p.Number, f => f.Random.Number().ToString())
        .RuleFor(p => p.Description, f => f.Lorem.Sentence())
        .RuleFor(p => p.Debt, f => f.Finance.Amount())
        .RuleFor(p => p.Currency, f => f.Finance.Currency().Code)
        .RuleFor(p => p.CreditorId, (f, p) =>
        {
          var creditor = contractorFaker.Generate();
          Contractors.Add(creditor);
          return creditor.Id;
        })
        .RuleFor(p => p.Debtors, (f, p) =>
        {
          caseDebtorFaker.RuleFor(p => p.CaseId, _ => p.Id);
          var caseDebtors = caseDebtorFaker.GenerateBetween(0, 10);
          CaseDebtors.AddRange(caseDebtors);
          return null;
        })
        .RuleFor(p => p.Properties, (f, p) =>
        {
          List<CaseProperty> caseProperties = new();
          foreach (var propertyType in ContractorPropertyTypes.Where(x => x.ContractorId == p.CreditorId))
          {
            caseProperties.Add(new()
            {
              Id = casePropertyId++,
              Value = GetPropertyValue(propertyType.Type),
              ContractorPropertyId = propertyType.Id,
              CaseId = p.Id,
            });
          }
          CaseProperties.AddRange(caseProperties);
          return null;
        });
      Cases.AddRange(caseFaker.Generate(count));
    }

    private static string? GetPropertyValue(PropertyType type)
    {
      Faker faker = new Faker();
      if (faker.Random.Number(0, 10) == 0)
      {
        return null;
      }

      return type switch
      {
        PropertyType.StartDate => faker.Date.Past().ToString(),
        PropertyType.EndDate => faker.Date.Soon().ToString(),
        PropertyType.Product => faker.Commerce.ProductName(),
        _ => null,
      };
    }
  }
}
