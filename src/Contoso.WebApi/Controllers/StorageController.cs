using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;

namespace Contoso.WebApi.Controllers
{
    [Route("api/users/{userId:long}/[controller]")]
    public class StorageController : Controller
    {
        // GET /api/users/{userId}/storage
        [HttpGet(Name = nameof(Get)), Authorize(Roles = "user")]
        public async Task<IActionResult> Get([FromRoute] long userId)
        {
            throw new NotImplementedException();
        }

        // GET /api/users/{userId}/storage
        [HttpGet("{id}", Name = nameof(GetById)), Authorize(Roles = "user")]
        public async Task<IActionResult> GetById([FromRoute] long userId, long id)
        {
            throw new NotImplementedException();
        }

        // POST /api/users/{userId}/storage
        [HttpPost(Name = nameof(Create)), Authorize(Roles = "user")]
        public async Task<IActionResult> Create([FromRoute] long userId, FormFile file)
        {
            throw new NotImplementedException();
        }

        // PUT /api/users/{userId}/storage/{id}
        [HttpPut("{id}", Name = nameof(Update)), Authorize(Roles = "user")]
        public async Task<IActionResult> Update([FromRoute] long userId, long id, FormFile file)
        {
            throw new NotImplementedException();
        }

        // DELETE /api/users/{userId}/storage/{id}
        [HttpDelete("{id}", Name = nameof(Delete)), Authorize(Roles = "user")]
        public async Task<IActionResult> Delete([FromRoute] long userId, long id)
        {
            throw new NotImplementedException();
        }
    }
}