using DJ_WebDesignCore.Enums.AttendanceManagerEnums;

namespace DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceCRUDDTOs
{
    public class AttendanceCreateDTO
    {
        public AttendanceEnum? Status { get; set; }
        public string? ShortDetail { get; set; }
    }
}
