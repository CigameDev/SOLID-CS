using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src.SOLID.I
{
    public interface IShape2D
    {
        double Area();
    }
}
/*
 * Chia nhỏ các interface ra 
 * Ví dụ IShape có 2 phương thức là diện tích và thể tích thì hình 2D cko có thể tích 
 * Tách thành IShape2D và IShape3D
 */