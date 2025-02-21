using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src.SOLID.D
{
    public class Engine : IEngine
    {
        public void Start()
        {
            System.Console.WriteLine("Engine started.");
        }
    }
}
//Các mô-đun cấp cao không nên phụ thuộc vào các mô-đun cấp thấp. Cả hai đều nên phụ thuộc vào sự trừu tượng.
