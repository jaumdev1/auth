using Domain.Common;
using Domain.Models;
using System;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IDashboardService
    {
        Task<DashboardModel> GetDemoDashboard();
    }

    public class DashboardService : IDashboardService
    {
        public DashboardService()
        {
        }

        public async Task<DashboardModel> GetDemoDashboard()
        {
            await Task.Delay(500);

            var demoDashboard = new DashboardModel
            {
                Title = "Demo Dashboard",
                Date = DateTime.UtcNow,
                Stats = new DashboardStats
                {
                    Users = 1234,
                    Sales = 5678,
                    Revenue = 91011.12
                }
            };

            return demoDashboard;
        }
    }
}
