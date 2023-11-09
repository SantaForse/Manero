using Manero.Models.Entities;
using Manero.Repositories;
using Manero.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Manero.Services
{
    public class UserService
    {
        private readonly PromoCodeRepo _promoCodeRepo;
        private readonly UserPromoCodeRepo _userPromoCodeRepo;
        public UserService(PromoCodeRepo promoCodeRepo, UserPromoCodeRepo userPromoCodeRepo)
        {
            _promoCodeRepo = promoCodeRepo;
            _userPromoCodeRepo = userPromoCodeRepo;
        }





        public async Task<List<PromoCodeViewModel>> GetPromoCodesByUserId(string userId)
        {
            var requestedCodes = new List<int>();
            foreach (var codes in await _userPromoCodeRepo.GetSelectedAsync(x => x.UserId == userId))
            {
                requestedCodes.Add(codes.PromoCodeId);
            }
            var associatedCodes = new List<PromoCodeViewModel>();

            foreach (var code in await _promoCodeRepo.GetAllAsync())
            {
                associatedCodes.Add(new PromoCodeViewModel
                {
                    ImageUrl = code.ImageUrl,
                    Title = code.Title,
                    Discount = code.Discount,
                    ExpirationDate = code.ExpirationDate
                    //Selected = requestedCodes!.Contains(code.Id)
                });
            }
            return associatedCodes;
        }
    }
}
