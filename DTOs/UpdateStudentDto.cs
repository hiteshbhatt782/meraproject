namespace CRUD_operation.DTOs
{
    public class UpdateStudentDto
    {
        public string PhoneNumber { get; set; }
        public string StudentName { get; set; }
        public string? course { get; set; }
        public string email { get; set; }
        public string address { get; set; }
    }
}
