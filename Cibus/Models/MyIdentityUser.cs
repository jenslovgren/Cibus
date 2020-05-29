using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cibus.Models
{
    public class MyIdentityUser : IdentityUser
    {
        public string ProfileImageUrl { get; set; }
    }
}
