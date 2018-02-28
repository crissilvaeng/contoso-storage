using System;
using System.Threading.Tasks;
using Contoso.WebApi.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Contoso.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class OrganizationsController : Controller
    {
        // GET /api/organizations
        [HttpGet(Name = nameof(Get)), Authorize(Roles = "global")]
        public async Task<IActionResult> Get()
        {
            throw new NotImplementedException();
        }

        // GET /api/organizations/{id}
        [HttpGet("{id}", Name = nameof(GetById)), Authorize(Roles = "global,admin")]
        public async Task<IActionResult> GetById(long id)
        {
            throw new NotImplementedException();
        }

        // POST /api/organizations
        [HttpPost(Name = nameof(Create)), Authorize(Roles = "global")]
        public async Task<IActionResult> Create([FromBody] OrganizationRequest organization)
        {
            throw new NotImplementedException();
        }

        // PUT /api/organizations/{id}
        [HttpPut("{id}", Name = nameof(Update)), Authorize(Roles = "global")]
        public async Task<IActionResult> Update(long id, [FromBody] OrganizationRequest organization)
        {
            throw new NotImplementedException();
        }

        // DELETE /api/organizations/{id}
        [HttpDelete("{id}", Name = nameof(Delete)), Authorize(Roles = "global,admin")]
        public async Task<IActionResult> Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}