using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmSample.Core.CoreVisual.RayTracer
{
    public class Surface
    {
        public Func<Vector, Color> Diffuse;
        public Func<Vector, Color> Specular;
        public Func<Vector, double> Reflect;
        public double Roughness;
    }
}
