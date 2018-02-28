using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Contoso.WebApi.Controllers
{
    [Route("api/organizations/{organizationId:long}/[controller]")]
    public class StatisticsController : Controller
    {
        // GET /api/organizations/organizationId/statistics
        [HttpGet(Name = nameof(Get)), Authorize(Roles = "admin")]
        public async Task<IActionResult> Get([FromRoute] long organizationId)
        {
            throw new NotImplementedException();
        }

        // GET /api/organizations/organizationId/statistics/{id}
        [HttpGet("{id}", Name = nameof(GetById)), Authorize(Roles = "admin")]
        public async Task<IActionResult> GetById([FromRoute] long organizationId, long id)
        {
            throw new NotImplementedException();
        }
    }
}