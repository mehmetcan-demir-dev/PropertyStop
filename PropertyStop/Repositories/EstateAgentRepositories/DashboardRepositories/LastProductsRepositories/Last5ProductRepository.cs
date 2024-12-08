using Dapper;
using PropertyStop.Dtos.ProductDtos;
using PropertyStop.Models.DapperContext;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories
{
    public class Last5ProductRepository : ILast5ProductRepository
    {
        private readonly Context _context;
        public Last5ProductRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultLast5ProductsWithCategory>> GetLast5ProductAsync(int id)
        {
            string query = "select Top(5) ProductID,Title,Price,City,District,ProductCategory,CategoryName,ProductDate from Product inner join " +
                "Category On Product.ProductCategory=Category.CategoryID where EmployeeId=@employeeId order by ProductID desc";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLast5ProductsWithCategory>(query, parameters);
                return values.ToList();
            }
        }
    }
}
