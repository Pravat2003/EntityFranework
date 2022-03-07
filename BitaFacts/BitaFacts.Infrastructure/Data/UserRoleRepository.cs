using BitaFacts.Core.Entities.Modeles;
using BitaFacts.Core.Interface;
using BitaFacts.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitaFacts.Infrastructure.Data
{
    public class UserRoleRepository:Repository<UserRole>, IUserRoleRepository
    {
        public ApplicationDbContext applicationDbContext
        {
            get { return applicationDbContext as ApplicationDbContext; }
        }

        public UserRoleRepository(ApplicationDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
