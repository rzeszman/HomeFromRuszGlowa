﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeFromRuszGlowa
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(bool hotOrNot, string name, string door) : base(hotOrNot, name)
        {
            DoorDescription = door;
        }

        public string DoorDescription { get; }

        public Location DoorLocation => throw new NotImplementedException();
    }
}