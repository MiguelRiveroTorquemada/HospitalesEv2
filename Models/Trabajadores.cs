namespace Clases;

public class Trabajadores
{
    public int id { get;set; }
    public String nombre { get;set; }
    public String email { get;set; }
    public bool baja { get; set; }
    public DateTime inicioTrabajo { get;set; }
    public decimal salario { get;set; }
    public int edad { get;set; }

    public Trabajadores(String nombre, string email, bool baja, DateTime inicioTrabajo, decimal salario, int edad)
    {
        this.nombre = nombre;
        this.email = email;
        this.baja = baja;
        this.inicioTrabajo = inicioTrabajo;
        this.salario = salario;
        this.edad = edad;
    }
    
    public void Profesion()
    {
        baja =!baja;
    }

    public String Form()
    {
        return nombre + " " + email + " " + baja.ToString() + " " + inicioTrabajo.ToString() + " " + salario.ToString() + " " + edad.ToString();
    }
}