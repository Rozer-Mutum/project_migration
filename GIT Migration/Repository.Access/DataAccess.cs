using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Access
{
    public class DataAccess : IDataAccess
    {
        public IList<Profile> GetProfiles()
        {
            var profiles = new List<Profile>();

            profiles.Add(new Profile()
            {
                FirstName = "Jhon",
                LastName = "Peter"
            });

            profiles.Add(new Profile()
            {
                FirstName = "Ramesh",
                LastName = "Rajendran"
            });

            profiles.Add(new Profile()
            {
                FirstName = "Raman",
                LastName = "Andisamy"
            });

            profiles.Add(new Profile()
            {
                FirstName = "Arun",
                LastName = "VijayaKumar"
            });

            profiles.Add(new Profile()
            {
                FirstName = "Vijay",
                LastName = "Joseph"
            });

            profiles.Add(new Profile()
            {
                FirstName = "Vijaya Sethupathi",
                LastName = "Kalimuthu"
            });
            return profiles;
        }


    }
}
