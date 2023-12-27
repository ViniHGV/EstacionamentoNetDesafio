using Parking.Interfaces;

namespace Parking.Models
{
    public class Park : IPark
    {
        public Park()
        {
            Cars = new List<string>();
            PriceInitial = 0.1M;
            PricePerHour = 0.1M;
        }
        private List<string> _cars;
        private decimal _priceInitial;
        private decimal _pricePerHour;

        public List<string> Cars { 
            get => _cars; 
            set{
                if(value == null){
                    throw new ArgumentException("Não é aceito um valor nullo");
             }
                _cars = value;
            }
        }
        public decimal PriceInitial { 
            get => _priceInitial;
            set{
                if(value <= 0){
                    throw new ArgumentException("Não é possivel cobrar valor negativo ou zero!!");
                }
                _priceInitial = value;
            } 
        }
        public decimal PricePerHour { 
            get => _pricePerHour;
            set{
                if(value <= 0){
                    throw new ArgumentException("Não é possivel cobrar valor negativo ou zero!!");
                }
                _pricePerHour = value;
            }
        }

        public void AddCar(string Car){
           if(Cars.Contains(Car)){
            Console.WriteLine("Este carro já esta adicionado!!");
           } else{
            Cars.Add(Car);
            Console.WriteLine("Carro adicionado com sucesso!");}
        }

        public void ListCars(){
            if(Cars.Count >0){
            Console.WriteLine("Listagem de carros no Estacionamento:");
            foreach(string Car in Cars){
                Console.WriteLine(Car);
            }}else{
                Console.WriteLine("Nenhum carro cadastrado até o momento!!");
            }
        }

        public void RemoveCar (string Car, int QuantityHours){
            if(Cars.Contains(Car)){
                Cars.Remove(Car);
                decimal TotalPrice = (QuantityHours * PricePerHour) + PriceInitial;
                Console.WriteLine($"\nCarro com a placa {Car} removido com sucesso Total da permanência: {TotalPrice.ToString("C")}");
            }else{
                Console.WriteLine("\nEste carro não está no estacionamento! Confira a placa!!");
            }

        }
    }
}