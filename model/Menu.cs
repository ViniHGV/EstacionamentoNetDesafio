
using ParkModel;

namespace MenuModel
{
    public class Menu
    {
        public Menu()
        {
            Option = "4";
            ShowMenu = true;
        }
    
        private string Option { get; set; }
        private bool ShowMenu { get; set; }

        public void ListMenu(Park park){
            PricesPark(park);
          
            while(ShowMenu){
                DisplayMenu();
                if(Option == "1") MenuAddCar(park);
                else if( Option == "2") ListCars(park);
                else if (Option == "3") ExitCar(park);
                else if (Option == "4") ExitSystem();
            }
        }

        private void PricesPark(Park park){
            Console.WriteLine("Digite o preço inicial:");
            park.PriceInitial = Int32.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite o preço por hora:");
            park.PricePerHour = Int32.Parse(Console.ReadLine());
            Console.Clear();
        }

        private void DisplayMenu (){
            Console.Clear();
            Console.WriteLine("Opções do Sistema de estacionamento:");
            Console.WriteLine("1 - Adicionar Novo Carro");
            Console.WriteLine("2 - Listar Carros");
            Console.WriteLine("3 - Remover carro");
            Console.WriteLine("4 - Sair do Sistema");
            Option = Console.ReadLine();
        }

        private void MenuAddCar(Park park){
            Console.Clear();
            Console.WriteLine("\n\nDigite a placa do carro que está prestes a entrar no estacionamento");
            string Car = Console.ReadLine();
            park.AddCar(Car);
            Console.WriteLine("\n\nPressione qualquer tecla para continuar!!");
            Option = Console.ReadLine();
        }
        private void ListCars(Park park){
            Console.Clear();
            park.ListCars();
            Console.WriteLine("\n\nPressione qualquer tecla para continuar!!");
            Option = Console.ReadLine();
        }
        private void ExitCar(Park park){
            Console.Clear();
            park.ListCars();
            Console.WriteLine("\n\nDigite a Placa do veiculo que ira ser retirado:");
            string plate = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de horas de permanência:");
            int quantityHours = Int32.Parse(Console.ReadLine());
            park.RemoveCar(plate, quantityHours);
            Console.WriteLine("\n\nPressione qualquer tecla para continuar!!");
            Option = Console.ReadLine();
        }

        private void ExitSystem (){
            Console.Clear();
            ShowMenu = false;
            Console.WriteLine("\nObrigado por utilizar o Sistema feito por ViniHGV!!");
        }
    }
}