using System;
using System.Threading.Tasks;
using Contoso.Application.Interfaces;
using Contoso.Application.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Contoso.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserAppService service;

        public UsersController(IUserAppService service)
        {
            this.service = service;
        }

        // GET /api/users
        [HttpGet(Name = nameof(Get)), Authorize(Roles = "global")]
        public async Task<IActionResult> Get()
        {
            return Ok(this.service.GetAll());
        }

        // GET /api/users/{id}
        [HttpGet("{id}", Name = nameof(GetById)), Authorize(Roles = "global")]
        public async Task<IActionResult> GetById(long id)
        {
            return Ok(this.service.GetById(id));
        }

        // POST /api/users/
        [HttpPost(Name = nameof(Create)), Authorize(Roles = "global")]
        public async Task<IActionResult> Create([FromBody] UserRequest organization)
        {
            throw new NotImplementedException();
        }

        // PUT /api/users/{id}
        [HttpPut("{id}", Name = nameof(Update)), Authorize(Roles = "global")]
        public async Task<IActionResult> Update(long id, [FromBody] UserRequest organization)
        {
            throw new NotImplementedException();
        }

        // DELETE /api/users/{id}
        [HttpDelete("{id}", Name = nameof(Delete)), Authorize(Roles = "global")]
        public async Task<IActionResult> Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}