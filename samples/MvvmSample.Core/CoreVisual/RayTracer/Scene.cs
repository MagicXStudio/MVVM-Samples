using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvvmSample.Core.CoreVisual.RayTracer
{
    public class Scene
    {
        public SceneObject[] Things;
        public Light[] Lights;
        public Camera Camera;

        public IEnumerable<ISect> Intersect(Ray r)
        {
            return from thing in Things
                   select thing.Intersect(r);
        }
    }
}
