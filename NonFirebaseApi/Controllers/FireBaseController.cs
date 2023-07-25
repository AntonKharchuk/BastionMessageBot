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

            //var ResponseToUser = new LikeVideo
            //{
            //    Id = result.Id,
            //    UserId = result.UserId,
            //    VideoId = result.VideoId,
            //    VideoTitle = result.VideoTitle,
            //    ChannelId = result.ChannelId,
            //    ChannelTitle = result.ChannelTitle,
            //    UserName = result.UserName,
            //};
            return Ok(result);
        }

    }
}
