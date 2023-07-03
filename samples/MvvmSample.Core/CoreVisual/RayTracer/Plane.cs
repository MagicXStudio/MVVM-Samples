using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmSample.Core.CoreVisual.RayTracer
{
    public class Plane : SceneObject
    {
        public Vector Norm;
        public double Offset;

        public override ISect Intersect(Ray ray)
        {
            double denom = Vector.Dot(Norm, ray.Dir);
            if (denom > 0) return null;
            return new ISect()
            {
                Thing = this,
                Ray = ray,
                Dist = (Vector.Dot(Norm, ray.Start) + Offset) / (-denom)
            };
        }

        public override Vector Normal(Vector pos)
        {
            return Norm;
        }
    }

}
