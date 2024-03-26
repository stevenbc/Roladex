using System.ComponentModel.DataAnnotations;

namespace Roladex.Models.Interfaces
{
    public interface IContact
    {
        public int Id { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Address11 { get; set; }
        public string? Address12 { get; set; }
        public string? Address1City { get; set; }
        public string? Address1State { get; set; }
        public string? Address1Zip { get; set; }
        public string? Address21 { get; set; }
        public string? Address22 { get; set; }
        public string? Address2City { get; set; }
        public string? Address2State { get; set; }
        public string? Address2Zip { get; set; }
        public string? Email1 { get; set; }
        public string? Email2 { get; set; }
        public string? Telephone1 { get; set; }
        public string? Telephone2 { get; set; }

    }

}
