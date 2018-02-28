namespace Contoso.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class FilesController : Controller
    {
        // GET /api/files
        [HttpGet(Name = nameof(Get)), Authorize(Roles = "global")]
        public async Task<IActionResult> Get()
        {
            throw new NotImplementedException();
        }
    }
}