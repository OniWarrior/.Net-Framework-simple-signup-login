using System;
using System.Collections.Generic;

namespace SimpleProfileCreation.Stores
{
    public abstract class ProfileDatabase : IProfileDatabase
    {
        // middleware for adding a profile
        public Profile AddProfile(Profile profile)
        {
            // check for duplicate profiles and/or existing usernames
            foreach(Profile individual in GetProfiles())
            {
                if(profile == individual)
                {
                    throw new ArgumentException("This profile already exists");
                }
                
            }
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
        protected abstract Profile GetProfileCore(int id);
        protected abstract Profile UpdateProfileCore(Profile existing, Profile update);
        protected abstract IEnumerable<Profile> GetProfilesCore();
        protected abstract void DeleteProfileCore(int id);
        #endregion
    }
}
