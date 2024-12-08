namespace PropertyStop.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticsRepositories
{
    public interface IStatisticRepository
    {
        int ProductCountByEmployeeID(int id);
        int ProductCountByStatusTrue(int id);
        int ProductCountByStatusFalse(int id);
        int AllProductCount();
    }
}
