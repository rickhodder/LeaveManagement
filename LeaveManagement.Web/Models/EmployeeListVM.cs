using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class EmployeeListVM
    {
        public string Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Date Joined")]
        public string DateJoined { get; set; }

        [DisplayName("Email Address")]
        public string Email { get; set; }
    }
}
