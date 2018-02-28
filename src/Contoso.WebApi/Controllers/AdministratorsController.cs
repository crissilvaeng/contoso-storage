using System;
using System.Threading.Tasks;
using Contoso.WebApi.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Contoso.WebApi.Controllers
{
    [Route("api/organizations/{organizationId:long}/[controller]")]
    public class AdministratorsController : Controller
    {
        // POST /api/organizations/{organizationId}/members
        [HttpPost(Name = nameof(Set)), Authorize(Roles = "global")]
        public async Task<IActionResult> Set([FromRoute] long organizationId, [FromBody] UserRequest user)
        {
            throw new NotImplementedException();
        }
    }
}