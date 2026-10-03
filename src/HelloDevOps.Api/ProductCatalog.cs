namespace HelloDevOps.Api;

public static class ProductCatalog
{
    private static readonly Product[] Products =
    {
        new(1, "Notebook", 3.50m),
        new(2, "Pen", 1.25m),
        new(3, "Mug", 8.00m)
    };

    public static IReadOnlyList<Product> GetAll() => Products;
}