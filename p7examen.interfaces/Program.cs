// Define la interfaz 'IPais'
public interface IPais
{
    string ColorBandera { get; }
    double Tamaño { get; }
    string IdiomaOficial { get; }
}

// Define la clase 'Ecuador' que implementa 'IPais'
public class Ecuador : IPais
{
    public string ColorBandera { get { return "Amarillo, Azul, Rojo"; } }
    public double Tamaño { get { return 283560; } } //coloco la distancia en kilómetros cuadrados
    public string IdiomaOficial { get { return "Español"; } }
}

// Define la clase 'Brasil' que implementa 'IPais'
public class Brasil : IPais
{
    public string ColorBandera { get { return "Verde, Amarillo, Azul"; } }
    public double Tamaño { get { return 8515767; } } //coloco la distancia en kilómetros cuadrados
    public string IdiomaOficial { get { return "Portugués"; } }
}

// Define la clase 'Andorra' que implementa 'IPais'
public class Andorra : IPais
{
    public string ColorBandera { get { return "Azul, Amarillo, Rojo"; } }
    public double Tamaño { get { return 468; } } // en kilómetros cuadrados
    public string IdiomaOficial { get { return "Catalán"; } }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de los países
        IPais ecuador = new Ecuador();
        IPais brasil = new Brasil();
        IPais andorra = new Andorra();

        // Imprimir la información requerida
        Console.WriteLine("Color de la bandera de Ecuador: " + ecuador.ColorBandera);
        Console.WriteLine("Tamaño de Andorra: " + andorra.Tamaño + " kilómetros cuadrados");
        Console.WriteLine("Idioma oficial de Brasil: " + brasil.IdiomaOficial);

        Console.ReadLine();
    }
}