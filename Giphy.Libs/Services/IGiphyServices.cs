using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Giphy.Libs.Models;

namespace Giphy.Libs.Services
{
    public interface IGiphyServices
    {
        Task<GiphyModel> GetRandonGifBasedOnSearchCriteria(string searchCriteria);
    }
}
