namespace Fiver.Mvc.PartialViews.Models.Home
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public AddressViewModel Address { get; set; }
    }

    public class AddressViewModel
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
    }
}
