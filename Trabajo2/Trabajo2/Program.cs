using ConsoleApp3.Entidades;


//polimorfismo y caste (atribuos)
Entity ve = new VehiculoElectrico(id: "1", placa: "hgb233", horasCarga: 50.1);
var ve1 = (VehiculoElectrico)ve;
Console.WriteLine(ve1.HorasCarga);

//Polimorfismo y caste (metodo)
Entity vg = new VehiculoGasolina(id: "2", placa: "hnn322");
var vg1 = (VehiculoGasolina)vg;
vg1.ImprimirValores();
