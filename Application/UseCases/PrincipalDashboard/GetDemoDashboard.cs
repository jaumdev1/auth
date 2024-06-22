using Application.Services;
using Domain.Common;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.PrincipalDashboard
{
    public interface IGetDemoDashboard
    {
      Task<BasicResult<DashboardModel>> GetDemoDashboardAsync();

    }
    public class GetDemoDashboard : IGetDemoDashboard
    {
        private readonly IDashboardService _dashboardService;
        public GetDemoDashboard(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        public async Task<BasicResult<DashboardModel>> GetDemoDashboardAsync()
        {
        
         var dashboard = await _dashboardService.GetDemoDashboard();

        return BasicResult.Success<DashboardModel>(dashboard);
        }
    }
}
