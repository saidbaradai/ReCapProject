using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleCar
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            CarManager cars = new CarManager(new InMemoryCarDal());
            foreach (var car in cars.GetAll())
            {
                Console.WriteLine(car.ModelYear);
            }
        }
    }
}