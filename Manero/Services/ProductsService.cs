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

    //Ill just divide the code a bit into regions, for cleaner code - Jeppe
    #region Get Products
    //Gets all products from product table in db
    public IEnumerable<ProductEntity> GetProducts()
    {
        return _context.Products.ToList();
    }


    //Gets products by category
    public IEnumerable<ProductEntity> GetProductsByCategory(string categoryName)
    {
        return _context.ProductCategories
            .Where(pc => pc.Category.CategoryName == categoryName)
            .Select(pc => pc.Product)
            .ToList();
    }

    //Förväxla inte dessa 2!
    public IEnumerable<ProductEntity> SearchProductsByString(string categoryName)
    {
        return _context.ProductCategories
            .Where(pc => pc.Category.CategoryName == categoryName)
            .Select(pc => pc.Product)
            .ToList();
    }


    //Get product by name
    public ProductEntity GetProductByName(string productName)
    {
        return _context.Products.FirstOrDefault(p => p.ProductName == productName)!;
    }

    //Asyncronous task that returns a list of products with similar names as searchword
    public async Task<IEnumerable<ProductEntity>> GetProductsByStringAsync(string searchWord)
    {
        // Use a case-insensitive search for products with names similar to the provided search word
        var products = await _context.Products
            .Where(p => EF.Functions.Like(p.ProductName, $"%{searchWord}%"))
            .ToListAsync();

        return products;
    }

    #endregion


    #region Get Categories

    //Get all categoryEntities from category table in db
    public IEnumerable<CategoryEntity> GetAllCategories()
    {
        var category = _context.Categories.ToList();

        return category;
    }


    //Get a single category by name
    public CategoryEntity GetCategory(string productCategory)
    {
        return _context.Categories.FirstOrDefault(c => c.CategoryName == productCategory)!;
    }


    //Get all unique categories from category table in db
    public IEnumerable<String> GetAllUniqueCategories()
    {
        var uniqueCategories = _context.Categories.Select(category => category.CategoryName)
            .Distinct()
            .ToList();

        return uniqueCategories;
    }

    //Gets an IEnumerable list af all categoryEntities that a product has 
    public IEnumerable<CategoryEntity> GetCategoriesForProduct(string productName)
    {
        return _context.ProductCategories
            .Where(pc => pc.Product.ProductName == productName)
            .Select(pc => pc.Category)
            .ToList();
    }
    #endregion



    ///////////////////////////////  REVIEW
    

    public IEnumerable<ReviewEntity> GetReviews(int productId)
    {
        return _context.ProductReviews
            .Where(pr => pr.ProductId == productId)
            .Select(pr => pr.Review)
            .ToList();
    }



}




