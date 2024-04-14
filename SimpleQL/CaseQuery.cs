using SimpleQL.Data;
using SimpleQL.Entities;

namespace SimpleQL
{
  public class CaseQuery // : ObjectType<Case>
  {
    [UsePaging]
    [UseProjection]
    [UseFiltering] // https://chillicream.com/docs/hotchocolate/v13/fetching-data/filtering
    [UseSorting]
    public IQueryable<Case> GetFoo([Service] SimpleQLDbContext dbContext)
        => dbContext.Set<Case>();

    //protected override void Configure(IObjectTypeDescriptor<Case> descriptor)
    //{
    //  descriptor.UseFiltering();
    //  descriptor.Field(t => t.Properties).UseFiltering();
    //}
  }
}
/*
 query {
  foo(first: 2, where: { number: { eq: "1" } }) {
    nodes {
      id
      number
      description
      debt
      properties#(where: { contractorProperty: { type: {eq: "PRODUCT"} }}) 
      {
        contractorProperty {
          name
          type
        }
        value
      }
      creditor {
        firstName
        lastName
        companyName
      }
    }
    pageInfo {
      hasNextPage
      hasPreviousPage
    }
  }
}

 */