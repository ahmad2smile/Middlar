using Microsoft.AspNetCore.Mvc;
using Middlar.Services;
using Middlar.ViewModels;

namespace Middlar.Controllers
{
    [Route("api/request")]
    public class MiddlarRequest: Controller
    {
        private readonly IRequestService _requestService;

        public MiddlarRequest(IRequestService requestService)
        {
            this._requestService = requestService;
        }

        [HttpPost]
        public IActionResult Index([FromBody] IncomingRequest req)
        {
            var returnValue = this._requestService.PostRequest(req.RequestUrl, req.RequestPayload);
            return new JsonResult(returnValue);
        }
    }
}
