﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Room
    {
        int roomNumber;

        public Room(int number)
        {
            RoomNumber = number;
        }

        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
    }


}
