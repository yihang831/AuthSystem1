using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AuthSystem.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string ProfilePicture { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string CardOwnerName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(16)")]
        public string CardNumber { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(5)")]
        public string ExpirationDate { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(3)")]
        public string SecurityCode { get; set; }

        [PersonalData]
        public string DateOfBirth { get; set; }

    }
}
