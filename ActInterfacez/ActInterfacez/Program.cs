// See https://aka.ms/new-console-template for more information
using ActInterfacez.Accesorios;
using ActInterfacez.Motos;

Console.WriteLine("Hello, World!");

//Crear Accesorios

IAccesorios accesorio = new EspejoDeLujo();
 

Moto moto = new Moto(accesorio);