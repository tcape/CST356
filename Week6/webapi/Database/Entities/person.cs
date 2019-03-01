using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("person")]
public class Person
{
    [Column("person_id")]
    [Key]
    public int Id { get; set; }

    [Column("first_name")]
    public string FirstName { get; set; }

    [Column("middle_initial")]
    public char MidInitial { get; set; }

    [Column("last_name")]
    public string LastName { get; set; }

    public Student Student {get; set;}
}