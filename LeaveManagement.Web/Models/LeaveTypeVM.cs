using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        
        public int Id { get; set; }

        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Default Number Of Days")]
        [Range(1, 25, ErrorMessage = "Please enter valid number")]
        public int DefaultDays { get; set; }
    }
}
