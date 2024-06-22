using Application.UseCases.PrincipalDashboard;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : BaseController
    {
        private readonly IGetDemoDashboard _getDemoDashboard;
        public DashboardController(IGetDemoDashboard getDemoDashboard) {
            _getDemoDashboard = getDemoDashboard;
        }


        [HttpGet]
        [Authorize(Policy = "RequireCommonRole")]
        public async Task<IActionResult> Get()
        {
          var dashboard = await _getDemoDashboard.GetDemoDashboardAsync();
         return ResponseBase<DashboardModel>(HttpStatusCode.OK, dashboard);
        }


    }
}
