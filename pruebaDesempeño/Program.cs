using pruebaDesempeño.Data;
using Microsoft.EntityFrameworkCore;
using pruebaDesempeño.Services.Owners;


var builder = WebApplication.CreateBuilder(args);


//controller
builder.Services.AddControllers();
//mysql
builder.Services.AddDbContext<GestionContext>(options => options.UseMySql(
                                builder.Configuration.GetConnectionString("MySqlConnection"),
                                Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql")
                                ));
builder.Services.AddScoped< IOwnersService, OwnersService>();



// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();
app.Run();
