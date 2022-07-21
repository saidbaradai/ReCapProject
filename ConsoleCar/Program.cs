 using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleCar
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CarManagerTest();


            ColorManager colorManager = new ColorManager(new EfColorDal());


            foreach (var c in colorManager.GetAll())
            {
                Console.WriteLine(c.Name);
            }



        }

        private static void CarManagerTest()
        {
            CarManager cars = new CarManager(new EfCarDal());
            var masda = new Car() { BrandId = 2, ColorId = 4, Description = "said baradi", ModelYear = 2005 };

            cars.Add(masda);
            foreach (var car in cars.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.ModelYear);
            }
            Console.WriteLine(cars.GetCarsByBrandId(1).Description);
        }
    }
}