using System.Collections.Generic;
using System.Threading.Tasks;
using Tier_1.Models.Burial;

namespace Tier_1.Data.BurialService
{
    public interface IBurialService
    {
        Task<IList<Burial>> GetBurialsAsync(int clientId);
        Task CreateBurial(Burial burial);
        Task EditBurial(Burial burial);
        Task DeleteBurial(int burialId);
    }
}