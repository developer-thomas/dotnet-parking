using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_ex_parking.Models
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;

        List<string> vehicleList = new List<string>();

        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            this.initialPrice = initialPrice;
            this.pricePerHour = pricePerHour;
        }

        public void addVehicle() {
            Console.WriteLine("Digite a placa do veículo para adicionar");
            string? carPlate = Console.ReadLine();
            vehicleList.Add(carPlate);
            Console.WriteLine("Veículo adicionado.\n");
        }

        public void removeVehicle() {
            Console.WriteLine("Digite a placa do veículo a remover");
            string carPlateToRemove = Console.ReadLine();

            if (vehicleList.Any(vehicle => vehicle.ToUpper() == carPlateToRemove.ToUpper())){
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                decimal parkingTime = Convert.ToDecimal(Console.ReadLine());

                decimal totalPrice = 0;

                totalPrice = initialPrice + pricePerHour * parkingTime;

                vehicleList.Remove(carPlateToRemove);

                 Console.WriteLine($"O veículo {carPlateToRemove} foi removido e o preço total foi de: R$ {totalPrice}");
            } else {
                Console.WriteLine("Veículo não encontrado!");
            } ;
        }

        public void listVeihicles() {
            if(vehicleList.Any()) {
                Console.WriteLine($"Veículos estacionados: ");
                foreach(string vehicle in vehicleList) {
                    Console.WriteLine(vehicle);
                }
            } else {
                Console.WriteLine("Nenhum veículo estacionado!");
            }
        }

        public void findAVehicle() {
            Console.WriteLine("Digite a placa do veículo que queira buscar. Ex: ABC-123");
            string plateToFind = Console.ReadLine().ToUpper();

            if(vehicleList.Any(vehicle => vehicle.ToUpper() == plateToFind )) {
                Console.WriteLine("Veículo encontrado.");
            } else {
                Console.WriteLine("Veículo NÃO encontrado!");
            }
        }
    }
}