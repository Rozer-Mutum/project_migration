using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Access
{
    public interface IDataAccess 
    {
        IList<Profile> GetProfiles();
    }
}
