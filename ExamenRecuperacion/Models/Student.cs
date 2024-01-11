namespace ExamenRecuperacion.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        //Eliminacion Logica

        public bool IsDeleted { get; set; }
    }
}
