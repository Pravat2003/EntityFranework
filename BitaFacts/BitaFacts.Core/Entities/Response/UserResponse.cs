using BitaFacts.Core.Entities.Modeles;
using System;

namespace BitaFacts.Core.Entities.Response
{
    public class UserResponse
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public Int64 RoleId { get; set; }
        public string Token { get; set; }
        public UserResponse(User user, string token)
        {
            Id = user.Id;
            Username = user.UserName;
            RoleId = user.RoleId;
            Token = token;
        }
    }
}
