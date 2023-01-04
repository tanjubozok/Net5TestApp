using Net5TestApp.Dtos.Abstract;
using Net5TestApp.Dtos.Concrete.AdvertisementAppUserStatusDtos;
using Net5TestApp.Dtos.Concrete.AdvertisementDtos;
using Net5TestApp.Dtos.Concrete.AppUserDtos;
using Net5TestApp.Dtos.Concrete.MilitaryStatusDtos;
using System;

namespace Net5TestApp.Dtos.Concrete.AdvertisementAppUserDtos
{
    public class AdvertisementAppUserListDto : IDto
    {
        public int Id { get; set; }

        public int AdvertisementId { get; set; }
        public AdvertisementListDto Advertisement { get; set; }

        public int AppUserId { get; set; }
        public AppUserListDto AppUser { get; set; }

        public int AdvertisementAppUserStatusId { get; set; }
        public AdvertisementAppUserStatusListDto AdvertisementAppUserStatus { get; set; }

        public int MilitaryStatusId { get; set; }
        public MilitaryStatusListDto MilitaryStatus { get; set; }
        public DateTime? EndDate { get; set; }

        public int WorkExperience { get; set; }

        public string CvPath { get; set; }
    }
}
