
using CRUD_operation.DTOs.Enums;
using meraproject.Models.Entities;

namespace CRUD_operation.Models.Entities
{
    public class Teacher
    {
       public string name { get; set; }
        public int id { get; set; }
       public int phone { get; set; } 
        public TeacherEnum position { get; set; }
       public float salary { get; set; }
        public bool isActive { get; set; }
       public ICollection<Student>Students { get; set; }
    }
}
