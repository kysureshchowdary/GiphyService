using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Giphy.Libs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GiphyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiphyController : ControllerBase
    {
        private readonly IGiphyServices _giphyService;

        public GiphyController(IGiphyServices giphyService)
        {
            _giphyService = giphyService;
        }
        [HttpGet]
        [Route( "v1/giphy/random/{searchcriteria}")]
        public async Task<IActionResult> GetRandomGif(string searchCriteria)
        {
            var result = await _giphyService.GetRandonGifBasedOnSearchCriteria(searchCriteria);
            return Ok(result);
        }
    }
}