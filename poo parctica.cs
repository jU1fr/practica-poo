using System;

// Abstracción: Creamos una clase abstracta que representa una forma geométrica
public abstract class FormaGeometrica
{
    // Método abstracto para calcular el área
    public abstract double CalcularArea();
}

// Encapsulación: Creamos una clase con propiedades encapsuladas para representar un rectángulo
public class Rectangulo : FormaGeometrica
{
    // Propiedades privadas
    private double Base { get; }
    private double Altura { get; }

    // Constructor
    public Rectangulo(double @base, double altura)
    {
        Base = @base;
        Altura = altura;
    }

    // Implementación del método abstracto para calcular el área
    public override double CalcularArea()
    {
        return Base * Altura;
    }
}

// Polimorfismo: Creamos otra clase que hereda de FormaGeometrica y sobrescribe el método CalcularArea para representar un círculo
public class Circulo : FormaGeometrica
{
    // Propiedad privada
    private double Radio { get; }

    // Constructor
    public Circulo(double radio)
    {
        Radio = radio;
    }

    // Implementación del método abstracto para calcular el área
    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }
}

// Herencia: Creamos una clase que hereda de FormaGeometrica para representar un cuadrado
public class Cuadrado : Rectangulo
{
    // Constructor que llama al constructor de la clase base (Rectangulo) con los mismos valores para base y altura
    public Cuadrado(double lado) : base(lado, lado)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de uso
        Rectangulo rectangulo = new Rectangulo(5, 4);
        Circulo circulo = new Circulo(3);
        Cuadrado cuadrado = new Cuadrado(5);

        Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());
        Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
        Console.WriteLine("Área del cuadrado: " + cuadrado.CalcularArea());
    }
}
