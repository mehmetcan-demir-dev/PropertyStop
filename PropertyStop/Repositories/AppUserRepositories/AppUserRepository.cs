using Dapper;
using PropertyStop.Dtos.AppUserDtos;
using PropertyStop.Models.DapperContext;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.AppUserRepositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly Context _context;
        public AppUserRepository(Context context)
        {
            _context = context;
        }

        public async Task<GetAppUserByProductIDDto> GetAppUserByProductID(int id)
        {
            string query = "select * from AppUser where UserID = @userID";
            var parameters = new DynamicParameters();
            parameters.Add("@userID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetAppUserByProductIDDto>(query, parameters);
                return values;
            }
        }
    }
}
