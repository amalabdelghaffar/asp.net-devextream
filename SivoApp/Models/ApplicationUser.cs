using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SivoApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Propriété personnalisée pour stocker le prénom
        public string FirstName { get; set; }

        // Propriété personnalisée pour stocker le nom de famille
        public string LastName { get; set; }

        // Propriété personnalisée pour stocker une adresse
        public string Address { get; set; }

        
    }
}
