using Common;
using Repository.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Service : IService
    {
        readonly IDataAccess dataAccess;
        public Service()
        {
            dataAccess = new DataAccess();
        }

       
        public IList<Profile> GetProfileByFirstName(string firstName)
        {
            IList<Profile> profile = default(IList<Profile>);
            var profiles = dataAccess.GetProfiles();
            
            if(profiles !=null && profiles.Any())
            {
                 profile = profiles.Where(param => param.FirstName.ToLower().Contains(firstName.ToLower())).ToList();
            }

            return profile;
        }
    }
}
