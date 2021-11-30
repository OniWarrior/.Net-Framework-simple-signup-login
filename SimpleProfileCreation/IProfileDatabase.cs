using System;

namespace SimpleProfileCreation
{
	public interface IProfileDatabase
    {
        Profile AddProfile(Profile profile);
        Profile GetProfile(int id);
    }
}
	
