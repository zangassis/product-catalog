using ProductCatalog.Data;
using ProductCatalog.Data.Repository;
using ProductCatalog.Data.Repository.Interfaces;
using ProductCatalog.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ProductCatalogContext>();
builder.Services.AddTransient<IGenericRepository<Product>, GenericRepository<Product>>();
builder.Services.AddTransient<IGenericRepository<Seller>, GenericRepository<Seller>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

#region Product API

app.MapGet("productCatalog/product/getAll", (IGenericRepository<Product> service) =>
{
    var products = service.GetAll();
    return Results.Ok(products);
})
.WithName("GetProductCatalog")
.WithOpenApi();

app.MapGet("productCatalog/product/getById", (IGenericRepository<Product> service, Guid id) =>
{
    var products = service.GetById(id);
    return Results.Ok(products);
})
.WithName("GetProductCatalogById")
.WithOpenApi();

app.MapPost("productCatalog/product/create", (IGenericRepository<Product> service, Product product) =>
{
    service.Create(product);
    service.Save();
    return Results.Ok();
})
.WithName("CreateProductCatalog")
.WithOpenApi();

app.MapPut("productCatalog/product/update", (IGenericRepository<Product> service, Product product) =>
{
    service.Update(product);
    service.Save();
    return Results.Ok();
})
.WithName("UpdateProductCatalog")
.WithOpenApi();

app.MapDelete("productCatalog/product/delete", (IGenericRepository<Product> service, Guid id) =>
{
    service.Delete(id);
    service.Save();
    return Results.Ok();
})
.WithName("DeleteProductCatalog")
.WithOpenApi();

#endregion

#region Seller API

app.MapGet("productCatalog/seller/getAll", (IGenericRepository<Seller> service) =>
{
    var products = service.GetAll();
    return Results.Ok(products);
})
.WithName("GetSeller")
.WithOpenApi();

app.MapGet("productCatalog/seller/getById", (IGenericRepository<Seller> service, Guid id) =>
{
    var products = service.GetById(id);
    return Results.Ok(products);
})
.WithName("GetSellerById")
.WithOpenApi();

app.MapPost("productCatalog/seller/create", (IGenericRepository<Seller> service, Seller seller) =>
{
    service.Create(seller);
    service.Save();
    return Results.Ok();
})
.WithName("CreateSeller")
.WithOpenApi();

app.MapPut("productCatalog/seller/update", (IGenericRepository<Seller> service, Seller seller) =>
{
    service.Update(seller);
    service.Save();
    return Results.Ok();
})
.WithName("UpdateSeller")
.WithOpenApi();

app.MapDelete("productCatalog/seller/delete", (IGenericRepository<Seller> service, Guid id) =>
{
    service.Delete(id);
    service.Save();
    return Results.Ok();
})
.WithName("DeleteSeller")
.WithOpenApi();

#endregion

app.Run();

