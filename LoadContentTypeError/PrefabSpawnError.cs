using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;

namespace LoadContentTypeError
{
    public class PrefabSpawnError : StartupScript
    {
        // Declared public member fields and properties will show in the game studio

        public override void Start()
        {
            var boatPrefab = Content.Load<Prefab>("BoatCog");
            Entity.AddChild(boatPrefab.Entities[0]);
        }
    }
}
