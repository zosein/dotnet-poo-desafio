using DesafioPOO.Models;

Console.WriteLine("Smartphone NOKIA: ");
Smartphone nokia = new Nokia(numero: "132475", modelo: "Nokia Model 1", imei: "ux109", Memoria: 84);
nokia.Ligar();
nokia.InstalarAplicativo("Outlook\n");

Console.WriteLine("Smartphone IPHONE: ");
Smartphone iphone = new Iphone(numero: "908765", modelo: "Iphone 15 PRO", imei: "ux86500", Memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Clash of Clans\n");