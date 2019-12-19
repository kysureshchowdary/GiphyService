using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Giphy.Libs.Giphy;
using Giphy.Libs.Models;

namespace Giphy.Libs.Services
{
    public class GiphyServices : IGiphyServices
    {
        private readonly IGetRandomGiphy _getRandonGif;

        public GiphyServices(IGetRandomGiphy getRandomGif)
        {
            _getRandonGif = getRandomGif;
        }
        public async Task<GiphyModel> GetRandonGifBasedOnSearchCriteria(string searchCriteria)
        {
            return await _getRandonGif.ReturnRandomGifBasedOnTag(searchCriteria);
        }
    }
}
