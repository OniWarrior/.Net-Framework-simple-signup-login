using System;
using System.Collections.Generic;

namespace SimpleProfileCreation.Stores
{
    public abstract class ProfileDatabase : IProfileDatabase
    {
        public Profile AddProfile(Profile profile)
        {
            throw new NotImplementedException();
        }

        public void DeleteProfile(int id)
        {
            throw new NotImplementedException();
        }

        public Profile GetProfile(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Profile> GetProfiles()
        {
            throw new NotImplementedException();
        }

        public Profile UpdateProfile(Profile profile)
        {
            throw new NotImplementedException();
        }



        #region Core Functionality:Members
        protected abstract Profile AddProfileCore(Profile profile);
        #endregion
    }
}
