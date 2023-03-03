using Microsoft.AspNetCore.Mvc;
using YodaApi.Interfaces;
using YodaApi.Requests;
using YodaApi.Responses;

namespace YodaApi.Controllers
{
    [ApiController]
    public class TranslateController : ControllerBase
    {
        private readonly IYodaApi _yodaExternalApi;

        public TranslateController(IYodaApi yodaExternalApi)
        {
            _yodaExternalApi = yodaExternalApi;
        }

        [HttpGet("/translate/yoda")] 
        public async Task <ActionResult<YodaTranslateResponse>> Translate([FromQuery] YodaTranslateRequest request)
        {
            try
            {
                return Ok (await _yodaExternalApi.Translate(request));
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
