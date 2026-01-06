using CRUD_operation.DTOs.Enums;

namespace CRUD_operation.DTOs
{
    public class TeacherDto
    {

    }
    public class CreateTeacherDto
    {
        public string name { get; set; }
        public int phone { get; set; }
        public TeacherEnum position { get; set; }
        public float salary { get; set; }
    }
    public class UpdateTeacherDto
    {
        public string name { get; set; }
        public int phone { get; set; }
        public TeacherEnum position { get; set; }
        public float salary { get; set; }
    }
    public class DeleteTeacherDto
    {
        public string name { get; set; }
        public int id { get; set; }
        public int phone { get; set; }
        public TeacherEnum position { get; set; }
        public float salary { get; set; }
    }
}
