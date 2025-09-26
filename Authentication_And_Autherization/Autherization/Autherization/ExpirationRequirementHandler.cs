using Microsoft.AspNetCore.Authorization;

namespace Autherization
{
    public class ExpirationRequirementHandler : AuthorizationHandler<ExpirationRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ExpirationRequirement requirement)
        {
            if (DateTime.UtcNow <= requirement.ExpiryDate)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
