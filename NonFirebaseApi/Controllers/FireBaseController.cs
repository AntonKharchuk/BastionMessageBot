using Microsoft.AspNetCore.Mvc;

namespace NonFirebaseApi.Controllers
{
    public class FireBaseController : ControllerBase
    {
        [HttpPost("message-tocken")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetRequest([FromQuery] string request)
        {

            var result = await _youTubeApiClient.GetSerchByVideoRequest(request);

            if (result == null)
            {
                return NotFound("Obj not found");
            }

        private async Task SaveTockenToTxt(string token)
        {
            using (StreamWriter sw = new StreamWriter(_messageTokenListPath))
            {
                await sw.WriteLineAsync(token);
            }
        }

    }

    
}
