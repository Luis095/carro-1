internal class Carro
{
    public string Marca { get; }
    public int Modelo { get; }

    public String Color { get; set; }

    private int Encendido = 0;
    private int velocidad_actual = 0;
    private const int MAXVELOCIDAD = 150;






    public Carro(string _marca, int _modelo, string _color)
    {
        Marca = _marca;
        Modelo = _modelo;
        Color = _color;
        Encendido = 0;
        this.velocidad_actual = 0;
    }



    public string acelerar()
    {
        if (Encendido == 0)
        {
            return $"El carro esta apagado, asi no se puede";
        }


        string mensaje = "";
        if (velocidad_actual <= MAXVELOCIDAD)
        {
            velocidad_actual += 10;
            mensaje = $"vas a {velocidad_actual} KPH";
        }
        else
        {
            velocidad_actual = MAXVELOCIDAD;
            mensaje = "Aguas, vas a maxima velocidad, rapido y furioso???";
        }

        Console.WriteLine(mensaje);
        return mensaje;

    }



    public string acelerar(int AcekerarAkph)
    {
        if (Encendido == 0)
        {
            return $"El carro esta apagado, asi no se puede";
        }


        string mensaje = "";
        if (velocidad_actual <= MAXVELOCIDAD)
        {
            velocidad_actual += AcekerarAkph;
            mensaje = $"vas a {velocidad_actual} KPH";
        }
        else
        {
            velocidad_actual = MAXVELOCIDAD;
            mensaje = "Aguas, vas a maxima velocidad, rapido y furioso???";
        }

        Console.WriteLine(mensaje);
        return mensaje;

    }



    public string GetVelocidadActual()
    {
        return $"VAmos a {velocidad_actual}KPH";
    }


    public void EncenderMotor()
    {
        if (Encendido == 0)
        {
            Encendido = 1;
            Console.WriteLine("Brururururururu carro encendido!!");
            velocidad_actual = 0;

        }
        else
        {
            Console.WriteLine("ups el carro ya estaba encendido");
        }
    }

    public void DameInformacion()
    {
        Console.WriteLine($"Soy un carro marca {Marca} y mi modelo es {Modelo}");
    }





    public string disminucion()
    {
       


        string mensaje = "";
        if (velocidad_actual <= MAXVELOCIDAD)
        {
            velocidad_actual -= 10;
            mensaje = $"vas a {velocidad_actual} KPH";
        }
       

        Console.WriteLine(mensaje);
        return mensaje;

    }



    public string frenado()
    {



        string mensaje = "";
        if (velocidad_actual <= MAXVELOCIDAD)
        {
            velocidad_actual = 0;
            mensaje = $"vas a {velocidad_actual} KPH";
        }
        mensaje = "frenando; carro frenado";

        Console.WriteLine(mensaje);
        return mensaje;

    }
    public string motorapagado()
    {


        string mensaje = "";


        if (Encendido == 1)
        {
            Encendido = 0;
            mensaje = $"apagando carro";
        }


        Console.WriteLine(mensaje);
        return mensaje;

    }

    public string carrobocina()
    {


        string mensaje = "";


        
            
            mensaje = $"Tocando la bocina: beeeeeep";
        


        Console.WriteLine(mensaje);
        return mensaje;

    }



}

