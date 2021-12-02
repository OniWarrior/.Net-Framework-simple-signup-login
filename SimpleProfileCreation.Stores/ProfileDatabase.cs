using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
                else if(profile.Username == individual.Username)
                {
                    throw new ArgumentException("This username is already taken");
                }
            }

            try
            {
                return AddProfileCore(profile);
            }
            catch (SqlException err)
            {
                throw new Exception("Add failed",err);
            }
        }

        // Middleware for deletion of profile.
        public void DeleteProfile(int id)
        {
            // Check to see if this profile even exists.
            Profile existing = GetProfile(id);
            if (existing == null)
            {
                throw new ArgumentNullException("This profile does not exist!");
            }

            //Delete the profile if it does exist.
            try
            {
                DeleteProfileCore(id);
            }
            catch(SqlException err)
            {
                throw new Exception("Deletion failed", err);
            }

        }

        // Middleware for profile retrieval.
        public Profile GetProfile(int id)
        {
            try
            {
                return GetProfileCore(id);
            }
            catch(SqlException err)
            {
                throw new ArgumentException("Retrieval of profile failed!", err);
            }
        }

        // Middleware of profiles retrieval.
        public IEnumerable<Profile> GetProfiles()
        {
            try
            {
                return GetProfilesCore();
            }
            catch(SqlException err)
            {
                throw new Exception("Retrieval of profiles failed", err);
            }
        }

        public Profile UpdateProfile(Profile profile)
        {
            // get the existing profile.
            Profile existing = GetProfile(profile.ID) ?? throw new ArgumentException("Profile was not found");

            try
            {
                return UpdateProfileCore(existing, profile);
            }
            catch(SqlException err)
            {
                throw new Exception("Update failed", err);
            }
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
