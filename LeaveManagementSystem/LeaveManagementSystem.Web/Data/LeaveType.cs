using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.Web.Data
{
    public class LeaveType
    {
        [Key]
        public int LeaveId { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string? LeaveTypeName { get; set; }
        public int NumberOfDays { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
