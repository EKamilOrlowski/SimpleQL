
using HotChocolate.Types.Pagination;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SimpleQL.Data;
using SimpleQL.Entities;

namespace SimpleQL
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var builder = WebApplication.CreateBuilder(args);

      builder.Services.AddAuthentication().AddBearerToken(IdentityConstants.BearerScheme);
      builder.Services.AddAuthorizationBuilder();

      builder.Services.AddDbContext<SimpleQLDbContext>(x => x.UseSqlite("DataSource=SimpleQL.db"));

      builder.Services.AddIdentityCore<User>()
        .AddEntityFrameworkStores<SimpleQLDbContext>()
        .AddApiEndpoints();

      // Add services to the container.
      builder.Services.AddControllers();

      builder.Services
        .AddGraphQLServer()
        .RegisterDbContext<SimpleQLDbContext>()
        .AddQueryType<CaseQuery>()
        .SetPagingOptions(new PagingOptions { MaxPageSize = 5 })
        .AddFiltering()
        .AddSorting()
        .AddProjections();

      // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
      builder.Services.AddEndpointsApiExplorer();
      builder.Services.AddSwaggerGen(opt =>
      {
        opt.SwaggerDoc("v1", new OpenApiInfo { Title = "SimpleQL", Version = "v1" });
        opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
          In = ParameterLocation.Header,
          Description = "Please enter token",
          Name = "Authorization",
          Type = SecuritySchemeType.Http,
          BearerFormat = "JWT",
          Scheme = "bearer"
        });
        opt.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type=ReferenceType.SecurityScheme,
                        Id="Bearer"
                    }
                },
                new string[]{}
            }
        });
      });
      var app = builder.Build();

      app.MapIdentityApi<User>();

      // Configure the HTTP request pipeline.
      if (app.Environment.IsDevelopment())
      {
        app.UseSwagger();
        app.UseSwaggerUI();
      }

      app.UseHttpsRedirection();

      app.UseAuthorization();

      app.MapControllers();

      app.MapGraphQL();

      app.Run();
    }
  }
}
