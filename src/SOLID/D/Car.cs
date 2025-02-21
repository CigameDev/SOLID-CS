using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src.SOLID.D
{
    public class Car
    {
        private IEngine engine;
        public Car(IEngine engine)
        {
            this.engine = engine;
        }

        public void StartCar()
        {
            engine.Start();
            System.Console.WriteLine("Car started.");
        }
    }
}
/*
 *  Bây giờ có thể đưa bất kỳ loại engine nào vào car
    var engine = new Engine(); // concrete implementation to be "injected" into the car

    var car = new Car(engine);

    car.StartCar();var engine = new Engine(); // concrete implementation to be "injected" into the car
*/

