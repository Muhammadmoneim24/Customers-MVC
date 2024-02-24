using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc_Day2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsSubscribedToNewLitter { get; set; }
        public int NumberOfWatchedMovies { get; set; }

        [ForeignKey("MembershipType")]
        public int MembershipTypeId { get; set; }
        public MembershipType MembershipType { get; set; }

    }
}
