using AutoMapper;
using Net5TestApp.Business.Mappings.AutoMapper;
using System.Collections.Generic;

namespace Net5TestApp.Business.Helpers
{
    public static class ProfileHelper
    {
        public static List<Profile> GetProfiles()
        {
            return new List<Profile>
            {
                new ProvidedServiceProfile(),
                new AdvertisementProfile(),
                new AppUserProfile(),
                new GenderProfile(),
            };
        }
    }
}
