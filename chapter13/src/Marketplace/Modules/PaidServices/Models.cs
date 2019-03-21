using System;
using Marketplace.PaidServices.Domain.Services;

namespace Marketplace.Modules.PaidServices
{
    public static class Models
    {
        public class PaidServiceItem
        {
            public string Description { get; set; }
            public string Duration { get; set; }
            public string Price { get; set; }

            public static PaidServiceItem FromDomain(
                PaidService paidService)
                => new PaidServiceItem
                {
                    Description = paidService.Description,
                    Price = $"€{paidService.Price}",
                    Duration = paidService.Duration == TimeSpan.Zero 
                        ? null : $"{paidService.Duration.Days} days"
                };
        }
    }
}