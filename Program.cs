using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone n1 = new Nokia(number: "99996-7234", model: "C3", imei: "111111111", memory: 500);
n1.Ligar();
n1.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Iphone: ");
Smartphone ip1 = new Iphone(number: "99996-7234", model: "7 Plus", imei: "111111111", memory: 500);
ip1.Ligar();
ip1.InstalarAplicativo("Whatsapp");