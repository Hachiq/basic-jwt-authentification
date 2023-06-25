using System.Security.Claims;

namespace API.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public UserService(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }
        public string GetUserame()
        {
            var username = string.Empty;
            if (_contextAccessor is not null)
            {
                username = _contextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }
            return username;
        }
    }
}
