using Mvc_Day2.Models;

namespace Mvc_Day2.ViewModels
{
    public class NewCustomerViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
    }
}
