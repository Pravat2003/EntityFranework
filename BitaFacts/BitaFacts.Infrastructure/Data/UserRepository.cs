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
    public class UserRepository :Repository<User>, IUserRepository
    {
        public ApplicationDbContext applicationDbContext
        {
            get { return applicationDbContext as ApplicationDbContext; }
        }

        public UserRepository(ApplicationDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
