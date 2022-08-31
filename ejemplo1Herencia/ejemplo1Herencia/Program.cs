// See https://aka.ms/new-console-template for more information

using ejemplo1Herencia;

Console.WriteLine("Sistema de vehiculos");


//Polimorfismo y casteo (atributos)

VehiculoEmpresarial ve= new Camioneta("2.5 L","DDO 389","PRADO TXL", "Toyota", "Nivel 2");
var ve1 = (Camioneta)ve;
Console.WriteLine(ve1.TipoBlindaje)

    
//Polimorfismo y casteo (Metodo)

    VehiculoEmpresarial au= AutoMovil("1.8 L Turbo","HVW 163","ONIX","Chevrolet","5 Puestos");
    var au1= (AutoMovil)au1;
    au1.ImprimirValores();



//Herencia  

Camioneta c = Camioneta("2.5 L","DDO 389","PRADO TXL", "Toyota", "Nivel 2");

Moto m = Moto("200","JWL 94F","RC200","KTM","Deportiva");

AutoMovil a = AutoMovil("1.8 L Turbo","HVW 163","ONIX","Chevrolet","5 Puestos");
