using Application.Applications;
using Application.Interfaces;
using Domain.Interfaces;
using Domain.Interfaces.Generics;
using Domain.Interfaces.ServicesInterfaces;
using Domain.Services;
using Infra.Repository;
using Infra.Repository.Generics;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using WebAPI.Token;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Interfaces and Repositories
builder.Services.AddSingleton(typeof(IGenerics<>), typeof(GenericRepository<>));
builder.Services.AddSingleton<IState, StateRepository>();
builder.Services.AddSingleton<ICity, CityRepository>();
builder.Services.AddSingleton<IUser, UserRepository>();

// Services and Domain
builder.Services.AddSingleton<IStateService, ServiceState>();
builder.Services.AddSingleton<ICityService, ServiceCity>();

// Interfaces Application
builder.Services.AddSingleton<IStateApplication, StateApplication>();
builder.Services.AddSingleton<ICityApplication, CityApplication>();
builder.Services.AddSingleton<IUserApplication, UserApplication>();

// JWT Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
       .AddJwtBearer(option =>
       {
           option.TokenValidationParameters = new TokenValidationParameters
           {
               ValidateIssuer = false,
               ValidateAudience = false,
               ValidateLifetime = true,
               ValidateIssuerSigningKey = true,

               ValidIssuer = "Basic.Securiry.Bearer",
               ValidAudience = "Basic.Securiry.Bearer",
               IssuerSigningKey = JwtSecurityKey.Create("Secret_Key-12345678")
           };

           option.Events = new JwtBearerEvents
           {
               OnAuthenticationFailed = context =>
               {
                   Console.WriteLine("OnAuthenticationFailed: " + context.Exception.Message);
                   return Task.CompletedTask;
               },
               OnTokenValidated = context =>
               {
                   Console.WriteLine("OnTokenValidated: " + context.SecurityToken);
                   return Task.CompletedTask;
               }
           };
       });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
