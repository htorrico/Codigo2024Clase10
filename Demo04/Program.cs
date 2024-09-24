
using Demo04;

Estudiante estudiante = new Estudiante
{
    Apellidos = "Torrico Márquez",
    Nombres = "Hugo Felioe",
    Codigo = "20054124",
    Escuela=  new Escuela
    {
         Direccion="Santa Anita",
         Nivel="Primaria",
         Nombre="Simón Rodriguez"
    }
};

Console.WriteLine(estudiante.Nombres);
Console.WriteLine(estudiante.Escuela.Nombre);


Estudiante estudiante2 = new Estudiante
{
    Apellidos = "Torrico Márquez",
    Nombres = "Hugo Felioe",
    Codigo = "20054124",
    Escuela = new Escuela
    {
        Direccion = "Santa Anita",
        Nivel = "Primaria",
        Nombre = "Simón Rodriguez"
    },
    Ciudad = new Ciudad()
};


Console.WriteLine(estudiante.Nombres);
Console.WriteLine(estudiante.Escuela.Nombre);



Estudiante estudiante3 = new Estudiante
{
    Apellidos = "Altamirano",
    Nombres = "Romulo",
    Codigo = "20054123",
    Escuela = new Escuela(),
    Ciudad = new Ciudad
    {
        Nombre = "Nasca",
        FechaFundacion = DateTime.Now,
        CantidadHabitantes = 50000,
        Pais = new Pais {
            Nombre="Perú",
            Capital="Lima",
            Poblacion=30000000,
            Presidente="No Aplica"
        }
    }
};

Console.WriteLine(estudiante3.Nombres);
Console.WriteLine(estudiante3.Ciudad.Nombre);
Console.WriteLine(estudiante3.Ciudad.Pais.Nombre);

Console.Read();

