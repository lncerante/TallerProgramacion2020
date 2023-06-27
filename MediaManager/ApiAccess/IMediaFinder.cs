using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.ApiAccess
{
    public interface IMediaFinder
    {
        IList<Media> FindMedia(string pTitle, Genre pGenre = null, MediaType? pType = null, int pPage = 1);
        Media GetMediaByImdbID(string pImdbID);
    }
}