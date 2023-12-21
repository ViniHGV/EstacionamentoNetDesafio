
using ParkModel;

namespace MenuModel
{
    public class Menu
    {
        public Menu(string Option)
        {
            this.Option = Option;
        }
        private string Option { get; set; }

        public void ListMenu(Park park){
            Console.WriteLine("Digite o preço inicial:");
            park.PriceInitial = Int32.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite o preço por hora:");
            park.PricePerHour = Int32.Parse(Console.ReadLine());
            Console.Clear();

            while(Option != "0"){
                if(Option == "4") DisplayMenu();
                else if(Option == "1") MenuAddCar(park);
                else if( Option == "2") ListCars(park);
                else if (Option == "3") ExitCar(park);
            }
        }

        private void DisplayMenu (){
            Console.Clear();
            Console.WriteLine("Opções do Sistema de estacionamento:");
                    Console.WriteLine("0 - Sair do Sistema");
            Console.WriteLine("1 - Adicionar Novo Carro");
            Console.WriteLine("2 - Listar Carros");
            Console.WriteLine("3 - Remover carro");
            Console.WriteLine("4 - Voltar ao menu");
            Option = Console.ReadLine();
        }

        private void MenuAddCar(Park park){
            Console.Clear();
            Console.WriteLine("\n\nDigite a placa do carro que está prestes a entrar no estacionamento");
            string Car = Console.ReadLine();
            park.AddCar(Car);
            Console.WriteLine("\n\nPressione 4 para voltar ao menu!!");
            Option = Console.ReadLine();
        }
        private void ListCars(Park park){
            Console.Clear();
            park.ListCars();
            Console.WriteLine("\n\nPressione 4 para voltar ao menu!!");
            Option = Console.ReadLine();
        }
        private void ExitCar(Park park){
            Console.Clear();
            Console.WriteLine("Digite a Placa do veiculo que ira ser retirado:");
            string plate = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de horas de permanencia:");
            int quantityHours = Int32.Parse(Console.ReadLine());
            park.RemoveCar(plate, quantityHours);
            Console.WriteLine("\n\nPressione 4 para voltar ao menu!!");
            Option = Console.ReadLine();
        }
    }
}