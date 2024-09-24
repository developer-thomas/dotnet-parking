
using _06_ex_parking.Models;

decimal initialPrice, pricePerHour = 0;
Console.WriteLine("==== Dev Parking ====");
Console.WriteLine("==== Seja bem vindo(a) ====");
Console.WriteLine("Defina o valor inicial:\n");
initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Defina o valor por hora:\n");
pricePerHour = Convert.ToDecimal( Console.ReadLine());

Parking parking = new Parking(initialPrice, pricePerHour);

string option = "";

while(option != "0") {
  Console.WriteLine("Selecione uma das opções abaixo:\n");
  
  Console.WriteLine("1 - Adicionar Veículo");
  Console.WriteLine("2 - Remover Veículo");
  Console.WriteLine("3 - Listar Veículos");
  Console.WriteLine("4 - Encontrar Veículo:");
  Console.WriteLine("0 - Sair");

  option = Console.ReadLine();

  switch(option) {
    case "1": 
        parking.addVehicle();
        Console.WriteLine("Voltar ao programa?\n 1-Sim\n 0-Não");
        option = Console.ReadLine();
        break;
    
    case "2": 
        parking.removeVehicle();
        Console.WriteLine("Voltar ao programa?\n 1-Sim\n 0-Não");
        option = Console.ReadLine();
        break;
  
    case "3": 
        parking.listVeihicles();
        Console.WriteLine("Voltar ao programa?\n 1-Sim\n 0-Não");
        option = Console.ReadLine();
        break;
    
    case "4": 
        parking.findAVehicle();
        Console.WriteLine("Voltar ao programa?\n 1-Sim\n 0-Não");
        option = Console.ReadLine();
        break;

    case "0":
      Console.WriteLine("Saíndo do programa...");
      break;
  }

  

}