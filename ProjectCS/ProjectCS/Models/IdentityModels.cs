using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ProjectCS.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string AvatarUrl { get; set; }
        public string BackgroundUrl { get; set; }
        public virtual ICollection<Project> Likes { get; set; }
        public virtual ICollection<Project> Following { get; set; } 

        public string FullName { get { return FirstName + " " + LastName; } }

        public string GetDateOfBirth()
        {
            return DateOfBirth != null ? DateOfBirth.Value.ToString("dd.MM.yyyy") : null;
        }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}