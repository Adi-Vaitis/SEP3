using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tier3.Repositories.Burial
{
    public interface IBurialRepo
    {
        Task CreateBurial(Models.Burial.Burial burial);
        Task EditBurial(Models.Burial.Burial burial);
        Task DeleteBurial(int burialId);
        Task<List<Models.Burial.Burial>> GetBurial();
        Task<IList<Models.Preference.Preference>> GetPreferencesForBurial(int burialId);
        Task<IList<Models.Burial.Burial>> GetBurialsForClient(int clientId);
    }
}