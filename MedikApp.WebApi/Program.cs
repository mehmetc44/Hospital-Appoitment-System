using Randevu_API.Model.DbContext;
using Randevu_API.Repositories.PersonRepositories;
using Randevu_API.Repositories.RandevuRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<Context>();
builder.Services.AddScoped<IPersonRepo, PersonRepo>();
builder.Services.AddScoped<IRandevuRepo, RandevuRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
