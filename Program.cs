using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// FEITO
Console.WriteLine("Telefone Nokia:");
Smartphone nokiaTijolao = new Nokia(numero: "148456856", modelo: "Tijolao", imei: "01010101", memoria: 128);
nokiaTijolao.Ligar();
nokiaTijolao.ReceberLigacao();
nokiaTijolao.InstalarAplicativo("Pinterest");

Console.WriteLine("Telefone Iphone:");
Smartphone iphoneBuxa = new Iphone(numero: "148456856", modelo: "Tijolao", imei: "01010101", memoria: 128);
iphoneBuxa.Ligar();
iphoneBuxa.ReceberLigacao();
iphoneBuxa.InstalarAplicativo("Intagram");