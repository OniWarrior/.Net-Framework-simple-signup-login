using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProfileCreation
{
	public interface IProfileDatabase
    {
        Profile AddProfile(Profile profile);
        Profile GetProfile(int id);
        IEnumerable<Profile> GetAllProfiles();
        Profile UpdateProfile( Profile profile);
        void DeleteProfile(int id);
    }
}
	
