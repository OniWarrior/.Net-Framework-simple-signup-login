using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleProfileCreation
{
    interface IProfileDatabase
    {
        Profile AddProfile(Profile profile);
        Profile GetProfile(int id);
        IEnumerable<Profile> GetProfiles();
        Profile UpdateProfile(Profile profile);
        void DeleteProfile(int id);
    }
}
