using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace VGR.Models
{
    public class PowerUser : IdentityUser<Guid>
    {
        public ICollection<Review> Reviews { get; set; }
    }
}
