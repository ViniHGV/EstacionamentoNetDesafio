using Parking.Interfaces;
using Parking.Models.Enum;

namespace Parking.Models
{
    public class Menu(Park Park) : IMenu
    {
        private Park Park { get; set; } = Park;

        private int Option { get; set; }
        private bool ShowMenu { get; set; } = true;

        public void ListMenu(){
            PricesPark();
          
            while(ShowMenu){
                DisplayMenu();

                switch(Option){
                    case (int)Options.MenuAddCar:
                        MenuAddCar();
                        break;
                    case (int)Options.ListCars:
                        ListCars();
                        break;
                    case (int)Options.ExitCar:
                        ExitCar();
                        break;
                    case (int)Options.ExitSystem:
                        ExitSystem();
                        break;
                    case (int)Options.DisplayMenu:
                        DisplayMenu();
                        break;
                    default:
                        DisplayMenu();
                        break;
                }
            }
        }

        private void PricesPark(){
            MessageWarningPrices("Inicial");
            Park.PriceInitial = decimal.Parse(Console.ReadLine());
            MessageWarningPrices("por Hora");
            Park.PricePerHour = decimal.Parse(Console.ReadLine());
            Console.Clear();
        }
        private void MessageWarningPrices(string typePrice){
            Console.Clear();
            Console.WriteLine($"ATENÇÃO: Divida as casas decimais com virgula, exemplo R$ 10,50!!\nDigite o preço {typePrice}:");
            Console.Write("R$ ");
        }

        private void DisplayMenu (){
            Console.Clear();
            Console.WriteLine("Opções do Sistema de Estacionamento:");
            Console.WriteLine("1 - Adicionar Novo Carro");
            Console.WriteLine("2 - Listar Carros");
            Console.WriteLine("3 - Remover carro");
            Console.WriteLine("4 - Sair do Sistema");
            Option = Int32.Parse(Console.ReadLine());
        }

        private void MenuAddCar(){
            Console.Clear();
            Console.WriteLine("Digite a placa do carro que está prestes a entrar no Estacionamento:");
            string Car = Console.ReadLine();
            Park.AddCar(Car);
            Console.WriteLine("\n\nPressione qualquer tecla para continuar!!");
            Console.ReadLine();
            Option = 5;
        }
        private void ListCars(){
            Console.Clear();
            Park.ListCars();
            Console.WriteLine("\n\nPressione qualquer tecla para continuar!!");
            Console.ReadLine();
            Option = 5;
        }
        private void ExitCar(){
            Console.Clear();
            Park.ListCars();
            Console.WriteLine("\n\nDigite a Placa do veiculo que ira ser retirado:");
            string plate = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de horas de permanência:");
            int quantityHours = Int32.Parse(Console.ReadLine());
            Park.RemoveCar(plate, quantityHours);
            Console.WriteLine("\n\nPressione qualquer tecla para continuar!!");
            Console.ReadLine();
            Option = 5;
        }

        private void ExitSystem (){
            Console.Clear();
            ShowMenu = false;
            Console.WriteLine("\nObrigado por utilizar o Sistema feito por ViniHGV!!\n");
        }

    }
}