using Microsoft.AspNetCore.Authorization;

namespace Autherization
{
    public class ExpirationRequirement : IAuthorizationRequirement
    {
        public DateTime ExpiryDate { get; }

        public ExpirationRequirement(DateTime expiryDate)
        {
            ExpiryDate = expiryDate;
        }
    }
}
