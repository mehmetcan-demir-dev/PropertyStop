using Dapper;
using Microsoft.CodeAnalysis;
using PropertyStop.Dtos.ProductDetailDtos;
using PropertyStop.Dtos.ProductDtos;
using PropertyStop.Models.DapperContext;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateProduct(CreateProductDto createProductDto)
        {
            string query = "insert into Product (Title,Price,City,District,CoverImage,Address,Description,Type,DealOfTheDay,ProductDate,ProductStatus,ProductCategory,EmployeeID) values " +
                "(@Title,@Price,@City,@District,@CoverImage,@Address,@Description,@Type,@DealOfTheDay,@ProductDate,@ProductStatus,@ProductCategory,@EmployeeID)";
            var parameters = new DynamicParameters();
            parameters.Add("@Title", createProductDto.Title);
            parameters.Add("@Price", createProductDto.Price);
            parameters.Add("@City", createProductDto.City);
            parameters.Add("@District", createProductDto.District);
            parameters.Add("@CoverImage", createProductDto.CoverImage);
            parameters.Add("@Address", createProductDto.Address);
            parameters.Add("@Description", createProductDto.Description);
            parameters.Add("@Type", createProductDto.Type);
            parameters.Add("@DealOfTheDay", createProductDto.DealOfTheDay);
            parameters.Add("@ProductDate", createProductDto.ProductDate);
            parameters.Add("@ProductStatus", createProductDto.ProductStatus);
            parameters.Add("@ProductCategory", createProductDto.ProductCategory);
            parameters.Add("@EmployeeID", createProductDto.EmployeeID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "Select * from Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query = "Select ProductID, Title, Price, City, District, CategoryName,CoverImage,Type,Address, DealOfTheDay from Product inner join Category on Product.ProductCategory=Category.CategoryID";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultLast5ProductsWithCategory>> GetLast5ProductAsync()
        {
            string query = "select Top(5) ProductID,Title,Price,City,District,ProductCategory,CategoryName,ProductDate from Product inner join Category On Product.ProductCategory=Category.CategoryID where type='Kiralık' order by ProductID desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLast5ProductsWithCategory>(query);
                return values.ToList();
            }
        }

        public async Task<GetProductByProductIDDto> GetProductByProductID(int id)
        {
            string query = "Select ProductID, Title, Price, City, District, CategoryName,CoverImage,Type,Address, DealOfTheDay, ProductDate, Description " +
                "from Product inner join Category on Product.ProductCategory=Category.CategoryID where ProductID= @productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<GetProductByProductIDDto>(query, parameters);
                return values.FirstOrDefault();
            }
        }

        public async Task<GetProductDetailByIDDto> GetProductDetailByProductID(int id)
        {
            string query = "Select * from ProductDetails where ProductID =@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<GetProductDetailByIDDto>(query, parameters);
                return values.FirstOrDefault();
            }
        }

        public async Task<List<ResultProductListingWithCategoryByEmployeeDto>> GetProductListingByEmployeeAsyncByFalse(int id)
        {
            string query = "Select ProductID, Title, Price, City, District, CategoryName,CoverImage,Type,Address, DealOfTheDay from Product inner join Category on Product.ProductCategory=Category.CategoryID where EmployeeID=@employeeID and ProductStatus = 0";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductListingWithCategoryByEmployeeDto>(query, parameters);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductListingWithCategoryByEmployeeDto>> GetProductListingByEmployeeAsyncByTrue(int id)
        {
            string query = "Select ProductID, Title, Price, City, District, CategoryName,CoverImage,Type,Address, DealOfTheDay from Product inner join Category on Product.ProductCategory=Category.CategoryID where EmployeeID=@employeeID and ProductStatus = 1";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductListingWithCategoryByEmployeeDto>(query, parameters);
                return values.ToList();
            }
        }

        public async Task ProductDealOfTheDayStatusChangeToFalse(int id)
        {
            string query = "update Product set DealOfTheDay=0 where ProductID=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task ProductDealOfTheDayStatusChangeToTrue(int id)
        {
            string query = "update Product set DealOfTheDay=1 where ProductID=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
