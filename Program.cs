using DesafioPOO.Models;

Console.WriteLine("Inicializando Android...");
Smartphone android = new Nokia(numero: "84987651234", modelo: "TopLinhaAndroid", imei: "987654321", memoria: 256);
android.InstalarAplicativo("Skype");
android.Ligar();

Console.WriteLine("\n");

Console.WriteLine("Inicializando IOs...");
Smartphone siri = new Iphone(numero: "84912349876", modelo: "TopLinhaIphone", imei: "123456789", memoria: 256);
siri.InstalarAplicativo("Instagram");
siri.ReceberLigacao();