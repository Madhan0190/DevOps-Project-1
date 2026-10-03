using HelloDevOps.Api;
using Xunit;

namespace HelloDevOps.Api.Tests;

public class ProductCatalogTests
{
    [Fact]
    public void GetAll_ReturnsThreeProducts()
    {
        var products = ProductCatalog.GetAll();

        Assert.Equal(3, products.Count);
    }

    [Fact]
    public void GetAll_ReturnsProductsWithPositivePrices()
    {
        var products = ProductCatalog.GetAll();

        Assert.All(products, product => Assert.True(product.Price > 0));
    }

    [Fact]
    public void GetAll_ReturnsNotebookAsFirstProduct()
    {
        var products = ProductCatalog.GetAll();

        Assert.Equal("Notebook", products[0].Name);
    }
}