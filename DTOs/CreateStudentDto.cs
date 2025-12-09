namespace meraproject.DTOs
{
    public class CreateStudentDto
    {
        public string PhoneNumber { get; set; }
        public string StudentName { get; set; }
        public string? course { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public bool  isActive { get; set; }
    }
}
