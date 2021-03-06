﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeFromRuszGlowa
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription) : base(name, decoration)
        {
            DoorDescription = doorDescription;
        }

        public string DoorDescription { get; }

        public override string Desciption => base.Desciption + "\r\nNo i są tu drzwi: " + DoorDescription;

        public Location DoorLocation { get; set; }
    }
}
