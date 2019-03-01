
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("student")]
public class Student
{
    [Column("student_id")]
    [Key]
    public long Id { get; set; }

    [Column("student_id_num")]
    public int StudentID { get; set; }

    [Column("email")]
    public string Email { get; set; }

    [Column("person_id")]
    public long PersonId {get; set;}
    public Person Person { get; set; }
}