using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace VGR.Models
{
    // Add profile data for application users by adding properties to the PowerUser class
    public class PowerUser : IdentityUser<Guid>
    {
        public PowerUser()
        {
           // this.Reviews = new List<Review>();
        }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        public ICollection<Review> Reviews { get; set; }
    }
}
