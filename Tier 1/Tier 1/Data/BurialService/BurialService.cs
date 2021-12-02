using System.Collections.Generic;
using System.Threading.Tasks;
using Tier_1.Models.Burial;

namespace Tier_1.Data.BurialService
{
    public class BurialService : IBurialService
    {
        public Task<IList<Burial>> GetBurialsAsync(int clientId)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateBurial(Burial burial)
        {
            throw new System.NotImplementedException();
        }

        public Task EditBurial(Burial burial)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteBurial(int burialId)
        {
            throw new System.NotImplementedException();
        }
    }
}