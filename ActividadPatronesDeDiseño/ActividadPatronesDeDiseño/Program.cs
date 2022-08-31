// See https://aka.ms/new-console-template for more informatiou
using ActividadPatronesDeDiseño.Concecionarios;

IFactory factory = new Factory();

factory.BuildMotoAltoCC(1, true);

var MotoBajoCC = factory.BuildMotoBajoCC(2);


  



