using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}