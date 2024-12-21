using Microsoft.Extensions.DependencyInjection;
using PropertyStop.Models.DapperContext;
using PropertyStop.Repositories.AppUserRepositories;
using PropertyStop.Repositories.BottomGridRepositories;
using PropertyStop.Repositories.CategoryRepository;
using PropertyStop.Repositories.ContactRepositories;
using PropertyStop.Repositories.EmployeeRepositories;
using PropertyStop.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;
using PropertyStop.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;
using PropertyStop.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticsRepositories;
using PropertyStop.Repositories.MessageRepositories;
using PropertyStop.Repositories.PopularLocationRepositories;
using PropertyStop.Repositories.ProductImageRepositories;
using PropertyStop.Repositories.ProductRepository;
using PropertyStop.Repositories.PropertyAmenityRepositories;
using PropertyStop.Repositories.ServiceRepository;
using PropertyStop.Repositories.StatisticsRepositories;
using PropertyStop.Repositories.SubFeatureRepositories;
using PropertyStop.Repositories.TestimonialRepositories;
using PropertyStop.Repositories.ToDoListRepositories;
using PropertyStop.Repositories.WhoWeAreRepository;

namespace PropertyStop.Containers
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddTransient<Context>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IBottomGridRepository, BottomGridRepository>();
            services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
            services.AddTransient<IStatisticsRepository, StatisticsRepository>();
            services.AddTransient<ITestimonialRepository, TestimonialRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IToDoListRepository, ToDoListRepository>();
            services.AddTransient<IStatisticRepository, StatisticRepository>();
            services.AddTransient<IChartRepository, ChartRepository>();
            services.AddTransient<ILast5ProductRepository, Last5ProductRepository>();
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IProductImageRepository, ProductImageRepository>();
            services.AddTransient<IAppUserRepository, AppUserRepository>();
            services.AddTransient<IPropertyAmenityRepository, PropertyAmenityRepository>();
            services.AddTransient<ISubFeatureRepository, SubFeatureRepository>();
        }
    }
}
