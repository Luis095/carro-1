Carro miCarrito = new Carro("Toyota", 2022, "azul");
Carro LuisiCarrito = new Carro("Ferrari", 2022, "Rojo");



if (miCarrito.Modelo > LuisiCarrito.Modelo)
{
    Console.WriteLine("mi carro es mas reciente");
}
else
{
    Console.WriteLine("El carro de luis es mas reciente");
}



Console.WriteLine($"luis  {LuisiCarrito.Marca}");






LuisiCarrito.EncenderMotor();

for (int i = 0; i < 5; i++)
{
    LuisiCarrito.acelerar();
}

LuisiCarrito.carrobocina();

Console.WriteLine("bajando velocidad");

for (int i = 0; i < 5; i++)
{
    LuisiCarrito.disminucion();
}
Console.WriteLine("estacionando");
LuisiCarrito.frenado();

LuisiCarrito.motorapagado();

