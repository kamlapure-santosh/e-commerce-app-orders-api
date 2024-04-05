using Microsoft.EntityFrameworkCore;
using Orders.Core.Entities;

namespace Orders.Data
{
    public  interface IUserProfileRepository
    {
        Task<UserProfile?> GetUserProfileAsync(string adObjId);
    }
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly skCartHubDbContext _dbContext;

        public UserProfileRepository(skCartHubDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<UserProfile?> GetUserProfileAsync(string adObjId)
        {
            return _dbContext.UserProfiles.FirstOrDefaultAsync(propa => propa.AdObjId == adObjId);
        }
    }
}
