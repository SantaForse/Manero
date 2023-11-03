using Manero.Models;

namespace Manero.Services;

public class ProductService
{


    private List<ProductEntity> siteProducts;


    //This static list should ofcourse be moved to db later
    public ProductService()
    {
        siteProducts = new List<ProductEntity>
        {
            new ProductEntity { Id = 1, ProductName = "Green Shoe", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 12 , ProductRating = 5, ProductTag = "new", Categories = new List<string> {"Women", "Shoes" } },
            new ProductEntity { Id = 2, ProductName = "Forest Shoe", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 29 , ProductRating = 3, ProductTag = "top", Categories = new List<string> {"Men", "Shoes" }},
            new ProductEntity { Id = 3, ProductName = "White Shoe", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 35 , ProductRating = 5, ProductTag = "sale", Categories = new List<string> {"Women", "Shoes" }},
            new ProductEntity { Id = 4, ProductName = "Black Shoe", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 12 , ProductRating = 3, ProductTag = "", Categories = new List<string> {"Women", "Shoes" }},

            new ProductEntity { Id = 5, ProductName = "Green Bag", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 11 , ProductRating = 2, ProductTag = "new", Categories = new List<string> {"Women", "Bag" } },
            new ProductEntity { Id = 6, ProductName = "Forest Bag", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 39 , ProductRating = 1, ProductTag = "top", Categories = new List<string> {"Men", "Bag" }},
            new ProductEntity { Id = 7, ProductName = "White Scarf", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 32 , ProductRating = 4, ProductTag = "sale", Categories = new List<string> {"Women", "Scarf" }},
            new ProductEntity { Id = 8, ProductName = "Black Hat", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 9 , ProductRating = 5, ProductTag = "", Categories = new List<string> {"Women", "Hat" }},

            new ProductEntity { Id = 9, ProductName = "Blue Bag", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 11 , ProductRating = 2, ProductTag = "new", Categories = new List<string> {"Women", "BestSeller" } },
            new ProductEntity { Id = 10, ProductName = "Yellow Bag", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 39 , ProductRating = 1, ProductTag = "top", Categories = new List<string> {"Men", "Bag", "FeaturedProducts" }},
            new ProductEntity { Id = 11, ProductName = "Black Scarf", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 32 , ProductRating = 4, ProductTag = "sale", Categories = new List<string> {"Women", "Scarf", "TopProducts" }},
            new ProductEntity { Id = 12, ProductName = "Green Hat", ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", ProductPrice = 9 , ProductRating = 5, ProductTag = "", Categories = new List<string> {"Women", "Hat", "Design" }}
        };
    }

    //Get all products
    public List<ProductEntity> GetAllProducts()
    {
        return siteProducts;
    }

    //Get all products by category
    public List<ProductEntity> GetProductsByCategory(string productCategory)
    {
        return siteProducts.Where(p => p.Categories.Contains(productCategory)).ToList();
    }

    //Get all products by Tag
    public List<ProductEntity> GetProductsByTag(string productTag)
    {
        return siteProducts.Where(p => p.ProductTag.Contains(productTag)).ToList();
    }

    //Get product by name
    public ProductEntity GetProductByName(string productName)
    {
            return siteProducts.FirstOrDefault(p => p.ProductName == productName)!;
    }

    //Get all categories
    public List<string> GetAllProductCategories()
    {
        List<string> allCategories = siteProducts
            .SelectMany(p => p.Categories)
            .Distinct()
            .ToList();

        return allCategories;
    }

}
