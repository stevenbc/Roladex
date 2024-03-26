using Roladex.Models.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Roladex.Models
{
    public class Contact : IContact
    {
        public int Id { get; set; }
        [MaxLength(255)]
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; } = string.Empty;
        [MaxLength(255)]
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; } = string.Empty;
        [MaxLength(500)]
        [DisplayName("Address Line 1")]
        public string? Address11 { get; set; }
        [DisplayName("Address Line 2")]
        [MaxLength(500)]
        public string? Address12 { get; set; }
        [MaxLength(500)]
        [DisplayName("City")]

        public string? Address1City { get; set; }
        [MaxLength(100)]
        public string? Address1State { get; set; }
        [MaxLength(20)]
        [DisplayName("Zip")]
        public string? Address1Zip { get; set; }
        [MaxLength(500)]
        [DisplayName("Address2 Line 1")]
        public string? Address21 { get; set; }
        [MaxLength(500)]
        [DisplayName("Address2 Line 2")]
        public string? Address22 { get; set; }
        [MaxLength(500)]
        [DisplayName("Address2 City")]
        public string? Address2City { get; set; }
        [MaxLength(100)]
        [DisplayName("Address2 State")]
        public string? Address2State { get; set; }

        [MaxLength(20)]
        [DisplayName("Address2 Zip")]
        public string? Address2Zip { get; set; }
        [MaxLength(100)]
        [DisplayName("Email 1")]
        public string? Email1 { get; set; }
        [MaxLength(100)]
        [DisplayName("Email 2")]
        public string? Email2 { get; set; }
        [MaxLength(50)]
        [DisplayName("Telephone 1")]
        public string? Telephone1 { get; set; }
        [MaxLength(50)]
        [DisplayName("Telephone 2")]
        public string? Telephone2 { get; set; }
    }
}
