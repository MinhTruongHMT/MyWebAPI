namespace MyWebAPI.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Correo {  get; set; }
        public double Sueldo { get; set; }
        public string? FechaContrato { get; set; }
    }
}
