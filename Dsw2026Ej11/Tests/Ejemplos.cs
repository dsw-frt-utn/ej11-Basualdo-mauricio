using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;

internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        Alumno alumno1 = new Alumno(1, "Federico", 8.5);
        Alumno alumno2 = new Alumno(2, "Lucia", 9);
        Alumno alumno3 = new Alumno(3, "Mateo", 7.5);

        casoList.AgregarAlumno(alumno1);
        casoList.AgregarAlumno(alumno2);
        casoList.AgregarAlumno(alumno3);

        Console.WriteLine("Lista de alumnos:");
        foreach (Alumno alumno in casoList.GetAlumnos())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\nBuscar alumno existente:");
        Alumno? alumnoEncontrado = casoList.BuscarPorNombre("Lucia");

        if (alumnoEncontrado != null)
        {
            Console.WriteLine(alumnoEncontrado);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\nBuscar alumno inexistente:");
        Alumno? alumnoNoEncontrado = casoList.BuscarPorNombre("Carlos");

        if (alumnoNoEncontrado != null)
        {
            Console.WriteLine(alumnoNoEncontrado);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\nEliminar un alumno:");
        casoList.EliminarAlumno(alumno2);

        foreach (Alumno alumno in casoList.GetAlumnos())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\nEliminar el primer elemento:");
        casoList.EliminarPorPosicion(0);

        foreach (Alumno alumno in casoList.GetAlumnos())
        {
            Console.WriteLine(alumno);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();

        Alumno alumno1 = new Alumno(1, "Federico", 8.5);
        Alumno alumno2 = new Alumno(2, "Lucia", 9);
        Alumno alumno3 = new Alumno(3, "Mateo", 7.5);

        casoDictionary.AgregarAlumno(1001, alumno1);
        casoDictionary.AgregarAlumno(1002, alumno2);
        casoDictionary.AgregarAlumno(1003, alumno3);

        Console.WriteLine("Diccionario de alumnos:");
        foreach (KeyValuePair<int, Alumno> item in casoDictionary.GetAlumnos())
        {
            Console.WriteLine($"Legajo: {item.Key} - {item.Value}");
        }

        Console.WriteLine("\nBuscar alumno existente por clave:");
        Alumno? alumnoEncontrado = casoDictionary.BuscarPorClave(1002);

        if (alumnoEncontrado != null)
        {
            Console.WriteLine(alumnoEncontrado);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\nBuscar alumno inexistente por clave:");
        Alumno? alumnoNoEncontrado = casoDictionary.BuscarPorClave(9999);

        if (alumnoNoEncontrado != null)
        {
            Console.WriteLine(alumnoNoEncontrado);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\nEliminar alumno por clave:");
        casoDictionary.EliminarAlumno(1001);

        foreach (KeyValuePair<int, Alumno> item in casoDictionary.GetAlumnos())
        {
            Console.WriteLine($"Legajo: {item.Key} - {item.Value}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("Primer libro:");
        Console.WriteLine(casoLinq.GetPrimero().Titulo);

        Console.WriteLine("\nÚltimo libro:");
        Console.WriteLine(casoLinq.GetUltimo().Titulo);

        Console.WriteLine("\nSuma total de precios:");
        Console.WriteLine(casoLinq.GetTotalPrecios().ToString("C"));

        Console.WriteLine("\nPromedio de precios:");
        Console.WriteLine(casoLinq.GetPromedioPrecios().ToString("C"));

        Console.WriteLine("\nLibros con Id mayor a 15:");
        foreach (Libro libro in casoLinq.GetListById())
        {
            Console.WriteLine($"{libro.Id} - {libro.Titulo} - {libro.Precio:C}");
        }

        Console.WriteLine("\nLibros con título y precio en formato moneda:");
        foreach (string libro in casoLinq.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLibro con mayor precio:");
        Libro mayorPrecio = casoLinq.GetMayorPrecio();
        Console.WriteLine($"{mayorPrecio.Titulo} - {mayorPrecio.Precio:C}");

        Console.WriteLine("\nLibro con menor precio:");
        Libro menorPrecio = casoLinq.GetMenorPrecio();
        Console.WriteLine($"{menorPrecio.Titulo} - {menorPrecio.Precio:C}");

        Console.WriteLine("\nLibros cuyo precio es mayor al promedio:");
        foreach (Libro libro in casoLinq.GetMayorPromedio())
        {
            Console.WriteLine($"{libro.Titulo} - {libro.Precio:C}");
        }

        Console.WriteLine("\nLibros ordenados por título de forma descendente:");
        foreach (Libro libro in casoLinq.GetOrdenadosPorTituloDescendente())
        {
            Console.WriteLine($"{libro.Titulo} - {libro.Precio:C}");
        }
    }
}
