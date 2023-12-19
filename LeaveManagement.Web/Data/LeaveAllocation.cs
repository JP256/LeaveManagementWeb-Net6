using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeIt")]
        public LeaveType LeaveType { get; set; }// point to the other table
        public int LeaveTypeId { get; set; }    // foreing key

        public string EmployeeId { get; set; }
    }
}
