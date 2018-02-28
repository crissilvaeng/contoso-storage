using System;
using System.Threading.Tasks;
using Contoso.WebApi.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Contoso.WebApi.Controllers
{
    [Route("api/organizations/{organizationId:long}/[controller]")]
    public class MembersController : Controller
    {
        // GET /api/organizations/{organizationId}/members
        [HttpGet(Name = nameof(Get)), Authorize(Roles = "admin")]
        public async Task<IActionResult> Get([FromRoute] long organizationId)
        {
            throw new NotImplementedException();
        }

        // GET /api/organizations/{organizationId}/members/{id}
        [HttpGet("{id}", Name = nameof(GetById)), Authorize(Roles = "admin")]
        public async Task<IActionResult> GetById([FromRoute] long organizationId, long id)
        {
            throw new NotImplementedException();
        }

        // POST /api/organizations/{organizationId}/members
        [HttpPost(Name = nameof(Create)), Authorize(Roles = "admin")]
        public async Task<IActionResult> Create([FromRoute] long organizationId, [FromBody] UserRequest user)
        {
            throw new NotImplementedException();
        }

        // PUT /api/organizations/{organizationId}/members/{id}
        [HttpPut("{id}", Name = nameof(Update)), Authorize(Roles = "admin")]
        public async Task<IActionResult> Update([FromRoute] long organizationId, long id, [FromBody] UserRequest user)
        {
            throw new NotImplementedException();
        }

        // DELETE /api/organizations/{organizationId}/members/{id}
        [HttpDelete("{id}", Name = nameof(Delete)), Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete([FromRoute] long organizationId, long id)
        {
            throw new NotImplementedException();
        }
    }
}