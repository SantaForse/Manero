using Manero.Data;
using Manero.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Manero.Services;

public class ProductsService
{

    private readonly ProductDbContext _context;

    public ProductsService(ProductDbContext context)
    {
        _context = context;
    }



    //Gets all products from product table in db
    public IEnumerable<ProductEntity> GetProducts()
    {
        return _context.Products.ToList();
    }

    //Gets products by tag
    public IEnumerable<ProductEntity> GetProductsByTag()
    {
        return _context.Products.ToList();
    }



    //Get product by name
    public ProductEntity GetProductByName(string productName)
    {
        return _context.Products.FirstOrDefault(p => p.ProductName == productName)!;
    }

    //Get all categoryEntities from category table in db
    public IEnumerable<CategoryEntity> GetAllCategories()
    {
        var category = _context.Categories.ToList();

        return category;
    }

    //Get all categories from category table in db
    public IEnumerable<String> GetAllUniqueCategories()
    {
        var uniqueCategories = _context.Categories.Select(category => category.CategoryName)
            .Distinct()
            .ToList();

        return uniqueCategories;
    }

}
