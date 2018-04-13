﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2dotNET.ConsoleCommand.Commands
{
    class ObjectsCount : Command
    {
        public override void Execute(string param)
        {
            Console.WriteLine("Count - " + World.L2World.Instance.GetObjects().Count);
        }
    }
}
