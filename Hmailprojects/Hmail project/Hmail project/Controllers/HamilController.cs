using Hmail_project.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Newtonsoft.Json;

namespace Hmail_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HamilController : ControllerBase
    {
        [HttpGet(Name = "GetHmailInbox")]
        public IActionResult GetHmailInbox()
        {
            List<MimeMessage> data =   (new ServiceHelper()).GetInbox();
            return Ok(JsonConvert.SerializeObject(data));
        }
    }
}
