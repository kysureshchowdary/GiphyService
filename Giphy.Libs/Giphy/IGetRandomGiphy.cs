using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Giphy.Libs.Models;

namespace Giphy.Libs.Giphy
{
    public interface IGetRandomGiphy
    {
        Task<GiphyModel> ReturnRandomGifBasedOnTag(string searchCriteria);
    }
}
