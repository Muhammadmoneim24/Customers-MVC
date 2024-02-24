namespace Mvc_Day2.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SingUpFee { get; set; }
        public int DiscountRate { get; set; }
        public int DurationInMonths { get; set; }

    }
}
