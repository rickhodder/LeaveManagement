using AutoMapper;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Configurations
{
    public class MapperConfig: Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<Employee, EmployeeListVM>().ReverseMap();
            //CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            //CreateMap<LeaveAllocationVM, LeaveAllocation>().ReverseMap();
            //CreateMap<LeaveTypeVM, LeaveType>().ReverseMap();
        }
    }
}
