namespace ParkModel
{
    public class Park
    {
        public Park(List<string> Cars, int PriceInitial, int PricePerHour)
        {
            this.Cars = Cars;
            this.PriceInitial = PriceInitial;
            this.PricePerHour = PricePerHour;
        }
        private List<string> _cars;
        private int _priceInitial;
        private int _pricePerHour;

        public List<string> Cars { 
            get => _cars; 
            set{
                if(value == null){
                    throw new ArgumentException("Não é aceito um valor nullo");
             }
                _cars = value;
            }
        }
        public int PriceInitial { 
            get => _priceInitial;
            set{
                if(value <= 0){
                    throw new ArgumentException("Não é possivel cobrar valor negativo ou zero!!");
                }
                _priceInitial = value;
            } 
        }
        public int PricePerHour { 
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
            Console.WriteLine("Listagem de carros no Estacionamento:");
            foreach(string Car in Cars){
                Console.WriteLine(Car);
            }
        }

        public void RemoveCar(string Car, int QuantityHours){
            int TotalPrice = (QuantityHours * PricePerHour) + PriceInitial;

            if(Cars.Contains(Car)){
                Cars.Remove(Car);
                Console.WriteLine($"Carro com a placa {Car} removido com sucesso Total da permanência: {TotalPrice}");
            }else{
                Console.WriteLine("Este carro não está no estacionamento! Confira a placa");
            }

        }
    }
}