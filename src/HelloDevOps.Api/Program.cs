using HelloDevOps.Api;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/health", () => Results.Ok(new { status = "healthy" }));
app.MapGet("/api/products", () => ProductCatalog.GetAll());

app.Run();