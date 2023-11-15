using Manero.Data;
using Manero.Models.Entities;
using Manero.Repositories;
using Manero.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Manero.Services
{
    public class UserService
    {
        private readonly ProductDbContext _context;
        private readonly PromoCodeRepo _promoCodeRepo;
        private readonly UserPromoCodeRepo _userPromoCodeRepo;
        private readonly UserAddressRepo _userAddressRepo;
        private readonly PaymentCardRepo _paymentCardRepo;
        private readonly UserPaymentCardRepo _userPaymentCardRepo;

        public UserService(ProductDbContext context, PromoCodeRepo promoCodeRepo, UserPromoCodeRepo userPromoCodeRepo, UserAddressRepo userAddressRepo, PaymentCardRepo paymentCardRepo, UserPaymentCardRepo userPaymentCardRepo)
        {
            _userAddressRepo = userAddressRepo;
            _context = context;
            _promoCodeRepo = promoCodeRepo;
            _userPromoCodeRepo = userPromoCodeRepo;
            _paymentCardRepo = paymentCardRepo;
            _userPaymentCardRepo = userPaymentCardRepo;

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

        public async Task<List<AddressViewModel>> GetAddressesByUserId(string userId)
        {
            var requestedAddresses = new List<int>();
            foreach (var address in await _userAddressRepo.GetSelectedAsync(x => x.UserId == userId))
            {
                requestedAddresses.Add(address.AddressId);
            }

            var associatedAdresses = new List<AddressViewModel>();
            foreach (var addressId in requestedAddresses)
            {
                var result = _context.Addresses.FirstOrDefault(p => p.Id == addressId);
                associatedAdresses.Add(new AddressViewModel
                {
                    Title = result!.Title,
                    Address = result.Address
                });
            }
            return associatedAdresses;
        }

        public async Task<List<PaymentCardViewModel>> GetPaymentCardByUserId(string userId)
        {
            var requestedPaymentCards = new List<int>();
            foreach (var paymentCard in await _userPaymentCardRepo.GetSelectedAsync(x => x.UserId == userId))
            {
                requestedPaymentCards.Add(paymentCard.PaymentCardId);
            }

            var associatedPaymentCards = new List<PaymentCardViewModel>();
            foreach (var addressId in requestedPaymentCards)
            {
                var result = _context.PaymentCards.FirstOrDefault(p => p.Id == addressId);
                associatedPaymentCards.Add(new PaymentCardViewModel
                {
                    Name = result.Name,
                    CardNumber = result.CardNumber,
                    ExpireDate = result.ExpireDate,
                    CVVCode = result.CVVCode
                });
            }
            return associatedPaymentCards;
        }
    }
}
