using AutoMapper;
using BitaFacts.Core.Entities.Modeles;
using BitaFacts.Core.Entities.Response;
using System.Collections.Generic;

namespace BitaFacts.Infrastructure.Mapper
{
    public class MappingProfile: Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            ConfigureMappings();
        }

        private void ConfigureMappings()
        {
            CreateMap<UserRole, UserRoleResponse>()
                .ForMember(x => x.RoleId,options => options
                .MapFrom(source =>source.Id));
        }
    }
}
