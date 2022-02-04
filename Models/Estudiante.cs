using System.ComponentModel.DataAnnotations;
namespace Educacion.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? ApellidoP { get; set; }
        public string? ApellidoM { get; set; }
        public string? Grado { get; set; }
        public int Edad { get; set; }
        public int TelefonoTutor { get; set; }



        [DataType(DataType.Date)]
        public DateTime FechaInscripcion { get; set; }
    }
}
