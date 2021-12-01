using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleProfileCreation
{
    public interface IProfileDatabase
    {
        Profile AddProfile(Profile profile);
        Profile GetProfile(int id);
        Profile UpdateProfile(Profile profile);
        IEnumerable<Profile> GetProfiles();
        void DeleteProfile(int id);

    }
}
