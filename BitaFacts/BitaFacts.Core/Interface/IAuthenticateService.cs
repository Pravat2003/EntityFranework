using BitaFacts.Core.Entities.Request;
using BitaFacts.Core.Entities.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitaFacts.Core.Interface
{
    public interface IAuthenticateService
    {
        UserResponse Authenticate(UserRequest userRequest);

    }
}
