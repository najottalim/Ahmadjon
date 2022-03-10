using Ahmadjon.Api.Models.Common;
using System;

namespace Ahmadjon.Api.Models
{
    public class UserModel : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }    
    }
}
