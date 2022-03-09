using Ahmadjon.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoLibrary;

namespace Ahmadjon.Api.Controllers
{
    [ApiController]
    [Route("/")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public async Task<RedirectResult> DownloadYoutubeVideo([FromForm]VideoModel model)
        {
            YouTube youtube = YouTube.Default;
            YouTubeVideo video = await youtube.GetVideoAsync(model.Url);
            string videoUrl = await video.GetUriAsync();

            return Redirect(videoUrl);
        }
    }
}
