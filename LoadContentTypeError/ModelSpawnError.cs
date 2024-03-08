using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using Stride.Rendering;

namespace LoadContentTypeError
{
    public class ModelSpawnError : StartupScript
    {
        // Declared public member fields and properties will show in the game studio

        public override void Start()
        {
            var model = Content.Load<Model>("Boat");
            var modelComponent = new ModelComponent(model);
            Entity.Add(modelComponent);
        }
    }
}
