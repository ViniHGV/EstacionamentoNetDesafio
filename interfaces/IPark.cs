namespace Parking.Interfaces
{
    public interface IPark
    {
        void AddCar(string Car);
        void ListCars();
        void RemoveCar (string Car, int QuantityHours);
    }
}