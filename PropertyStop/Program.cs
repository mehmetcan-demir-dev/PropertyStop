using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PropertyStop.Hubs;
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


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
builder.Services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
builder.Services.AddTransient<IStatisticsRepository, StatisticsRepository>();
builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IContactRepository, ContactRepository>();
builder.Services.AddTransient<IToDoListRepository, ToDoListRepository>();
builder.Services.AddTransient<IStatisticRepository, StatisticRepository>();
builder.Services.AddTransient<IChartRepository, ChartRepository>();
builder.Services.AddTransient<ILast5ProductRepository, Last5ProductRepository>();
builder.Services.AddTransient<IMessageRepository, MessageRepository>();
builder.Services.AddTransient<IProductImageRepository, ProductImageRepository>();
builder.Services.AddTransient<IAppUserRepository, AppUserRepository>();
builder.Services.AddTransient<IPropertyAmenityRepository, PropertyAmenityRepository>();
builder.Services.AddTransient<ISubFeatureRepository, SubFeatureRepository>();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed((host) => true)
        .AllowCredentials();
    });
});

builder.Services.AddHttpClient();
builder.Services.AddSignalR();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<SignalRHub>("/signalrhub");

app.Run();
