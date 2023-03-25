using Microsoft.EntityFrameworkCore;
using Write.API.Business.Product;
using Write.API.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProductBusiness, ProductBusiness>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("ProductWriteDb")));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseDeveloperExceptionPage();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();