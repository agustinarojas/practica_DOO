using System;

namespace ParcticaClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Juan";
            persona.Apellido = "Perez";
            persona.Edad = 30;
            persona.Saludar();

            Perro perro = new Perro();
            perro.Nombre = "Firulais";
            perro.Raza = "Pastor Aleman";
            perro.Edad = 5;
            perro.Ladrar();
        }
    }
    public class Persona
    {
        public string Nombre;
        public string Apellido;
        public int Edad;

        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {Nombre} {Apellido} y tengo {Edad} años.");
        }
        public void Caminar()
        {
            Console.WriteLine("Estoy caminando");
        }
    };

    public class Perro
    {
        public string Nombre;
        public string Raza;
        public int Edad;

        public void Ladrar()
        {
            Console.WriteLine("Guau guau");
        }
        public void Morder()
        {
            Console.WriteLine("Estoy mordiendo");
        }
    }


}

