using PropertyStop.Dtos.EmployeeDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.StatisticsRepositories
{
    public interface IStatisticsRepository
    {
        int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();
        int ProductCount();
        int ApartmentCount();
        string EmployeeNameByMaxProductCount();
        string CategoryNameByMaxProductCount();
        decimal AverageProductPriceByRent();
        decimal AverageProductPriceBySale();
        string CityNameMaxProductCount();
        int DifferentCityCount();
        decimal lastProductPrice();
        string NewestBuildingYear();
        string OldestBuildingYear();
        int AvaregeRoomCount();
        int ActiveEmployeeCount();

    }
}
