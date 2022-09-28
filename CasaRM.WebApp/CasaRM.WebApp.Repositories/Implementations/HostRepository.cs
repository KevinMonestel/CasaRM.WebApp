﻿using CasaRM.WebApp.Persistance;
using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Shared.Models.Host;
using CasaRM.WebApp.Shared.Models.SocialStudy;
using Microsoft.EntityFrameworkCore;

namespace CasaRM.WebApp.Repositories.Implementations
{
    public class HostRepository : GenericRepository<Host>, IHostRepository
    {
        private readonly ISocialStudyRepository _socialStudyRepository;

        public HostRepository(ApplicationDbContext context, ISocialStudyRepository socialStudyRepository) : base(context)
        {
            _socialStudyRepository = socialStudyRepository;
        }

        public async Task<int> GetSocialStudyIdByHostIdAsync(string hostId)
        {
            try
            {
                int result = 0;

                Host hostFinded = (await FindAsync(x => x.Id.ToString() == hostId)).FirstOrDefault();

                result = hostFinded is not null ? hostFinded.SocialStudyId : result;

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<HostDto> CreateHostAsync(HostDto hostDto)
        {
            try
            {
                Host dbModel = await AddAsync(new Host
                {
                    SocialStudyId = hostDto.SocialStudyId,
                    CreatedBy = hostDto.CreatedBy,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });

                if (dbModel is null) throw new Exception();

                hostDto.Id = dbModel.Id.ToString();

                return hostDto;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<SearchHostResultsDto>> SearchHostByHostSearchingAsync(SearchHostDto searchHostDto)
        {
            try
            {
                IEnumerable<SearchHostResultsDto> result;

                result = await _context.Host.
                    Where(x => x.Id.ToString().Contains(searchHostDto.Code) ||
                    x.SocialStudy.MinorPersonData.FullName.Contains(searchHostDto.MinorPersonName) ||
                    x.SocialStudy.MinorPersonData.FileNumber.Contains(searchHostDto.MinorPersonFileNumber) ||
                    x.SocialStudy.ParentData.FullName.Contains(searchHostDto.ParentName) ||
                    x.SocialStudy.ParentData.Identification.Contains(searchHostDto.ParentIdentification) ||
                    x.SocialStudy.CompanionData.FullName.Contains(searchHostDto.CompanionName) ||
                    x.SocialStudy.CompanionData.Identification.Contains(searchHostDto.CompanionIdentification)).
                    Select(x => new SearchHostResultsDto
                    {
                        Code = x.Id.ToString(),
                        MinorPersonName = x.SocialStudy.MinorPersonData.FullName,
                        MinorPersonFileNumber = x.SocialStudy.MinorPersonData.FileNumber,
                        ParentName = x.SocialStudy.ParentData.FullName,
                        ParentIdentification = x.SocialStudy.ParentData.Identification,
                        CompanionName = x.SocialStudy.CompanionData.FullName,
                        CompanionIdentification = x.SocialStudy.CompanionData.Identification
                    }).ToListAsync();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
