using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioFundamentos.Models
{
    public class Parking
    {
        private decimal priceInitial = 0;
        private decimal pricePerHour = 0;
        private List<string> carsList = new List<string>();

        public Parking(decimal priceInitial, decimal pricePerHour)
        {
            this.priceInitial = priceInitial;
            this.pricePerHour = pricePerHour;
        }

        public void AddCar()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string licensePlate = Console.ReadLine();
            carsList.Add(licensePlate.ToUpper());
            Console.WriteLine($"Veículo com placa {licensePlate} estacionado com sucesso!");
        }

        public void RemoveCar()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string licensePlate = Console.ReadLine();

            if (carsList.Any(x => x == licensePlate.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int hours = Convert.ToInt32(Console.ReadLine());

                decimal totalPrice = priceInitial + pricePerHour * hours;

                carsList.Remove(licensePlate.ToUpper());

                Console.WriteLine($"O veículo {licensePlate} foi removido e o preço total foi de: R$ {totalPrice}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void GetListCars()
        {
            if (carsList.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (var licensePlate in carsList)
                {
                    Console.WriteLine(licensePlate);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
