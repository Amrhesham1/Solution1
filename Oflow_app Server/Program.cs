using Blazored.LocalStorage;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Oflow_app_Server.Providers;
using Oflow_app_Server.Services.Base;
using Oflow_app_Server.Services.Authentication;
using Microsoft.EntityFrameworkCore;
using Oflow_app_Server.ActionReq;
using Oflow_app_Server.Data;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient<AuthenticationServices>(client =>
{
    client.BaseAddress = new Uri("http://localhost:7003");
});

// Add services to the container.

builder.Services.AddScoped<Oflow_app_Server.ActionReq.AuctionService>();
builder.Services.AddAuthorizationCore();
// builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();


// Program.cs (Blazor WebAssembly) Added BY Mayaaaa
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


builder.Services.AddHttpClient<IClient, Client>(cl => cl.BaseAddress = new Uri("https://localhost:7003"));

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<Oflow_app_Server.Services.Authentication.IAuthenticationService, Oflow_app_Server.Services.Authentication.AuthenticationServices>();
builder.Services.AddScoped<ApiAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>
          (p => p.GetRequiredService<ApiAuthenticationStateProvider>());   


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
