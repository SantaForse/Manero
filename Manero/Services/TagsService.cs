﻿using Manero.Data;
using Manero.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Manero.Services;

public class TagsService
{
    private readonly ProductDbContext _context;

    public TagsService(ProductDbContext context)
    {
        _context = context;
    }

    //This list of all the tags could be moved to database
    public IEnumerable<string> Tags() 
    {
        var tags = new List<string>
            {
            //One tag for each tagfunction
                "Sale",
                "Top",
                "New"
            };

        return tags;
     }



    //Get a list of all the products
    public async Task<IEnumerable<ProductEntity>> GetProducts()
    {
        IEnumerable<ProductEntity> products = await _context.Products.ToListAsync();

        return products;
    }


    //Pick out the top 10 newest products and add to a list
    public async Task<IEnumerable<ProductEntity>> GetNewProducts()
    {

        //Checks which id is highest and then descends (Because we dont have "creationDate"
        //in the ProductEntity)
        IEnumerable<ProductEntity> products = await _context.Products
            .OrderByDescending(product => product.Id)
            .Take(10)
            .ToListAsync();

        return products;
    }


    //Pick out the products that has a salePrice and add to list
    public async Task<IEnumerable<ProductEntity>> GetSaleProducts()
    {
        IEnumerable<ProductEntity> products = await GetProducts();

        //Makes a list of the products with a sale price
        IEnumerable<ProductEntity> saleProducts = products.Where(product => product.SalePrice != null);

        return saleProducts;
    }


    // Look at all products and see which has the highest rating and add to list
    public async Task<IEnumerable<ProductEntity>> GetTopProducts()
    {

        //Makes a list of top 10 best rated products in descending order
        IEnumerable<ProductEntity> products = await _context.Products
            .OrderByDescending(product => product.Rating)
            .Take(10)
            .ToListAsync();

        return products;
    }

    //Picks the tag from the list, that has the same name
    public string GetTag(string tagName)
    {
        if (Tags() != null)
        {
            return Tags().FirstOrDefault(tag => string.Equals(tag, tagName, StringComparison.OrdinalIgnoreCase))!;
        }
        return null!;
    }


}
