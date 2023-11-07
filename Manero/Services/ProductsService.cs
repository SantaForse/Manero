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




    public IEnumerable<ProductEntity> GetProducts()
    {
        return _context.Products.ToList();
    }




}
