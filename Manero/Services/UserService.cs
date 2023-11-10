using Manero.Data;
using Manero.Models.Entities;
using Manero.Repositories;
using Manero.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Manero.Services
{
    public class UserService
    {
        private readonly ProductDbContext _context;
        private readonly PromoCodeRepo _promoCodeRepo;
        private readonly UserPromoCodeRepo _userPromoCodeRepo;
        public UserService(ProductDbContext context, PromoCodeRepo promoCodeRepo, UserPromoCodeRepo userPromoCodeRepo)
        {
            _context = context;
            _promoCodeRepo = promoCodeRepo;
            _userPromoCodeRepo = userPromoCodeRepo;
        }





        public async Task<List<PromoCodeViewModel>> GetPromoCodesByUserId(string userId)
        {
            var requestedCodeIds = new List<int>();
            foreach (var codes in await _userPromoCodeRepo.GetSelectedAsync(x => x.UserId == userId))
            {
                requestedCodeIds.Add(codes.PromoCodeId);
            }
            
            
            var associatedCodes = new List<PromoCodeViewModel>();
            foreach (var codeId in requestedCodeIds)
            {
                var result = _context.PromoCodes.FirstOrDefault(p => p.Id == codeId);
                associatedCodes.Add(new PromoCodeViewModel
                    {
                        ImageUrl = result.ImageUrl,
                        Title = result.Title,
                        Discount = result.Discount,
                        ExpirationDate = result.ExpirationDate
                    });
            }



            return associatedCodes;
        }
    }
}
