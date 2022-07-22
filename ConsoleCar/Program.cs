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
            CarManagerTest();


            //Colortest();

        }

        private static void Colortest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());


            foreach (var c in colorManager.GetAll())
            {
                Console.WriteLine(c.Name);
            }
        }

        private static void CarManagerTest()
        {
            CarManager cars = new CarManager(new EfCarDal());
           

          
            foreach (var car in cars.GetCarsDtails())
            {
                Console.WriteLine(car.Id +"  "+ car.BrandName+"  color:"+car.ColorName+" " + car.ModelYear);
            }
            Console.WriteLine(cars.GetCarsByBrandId(1).Description);
        }
    }
}