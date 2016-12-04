using aventOfCode2016.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aventOfCode2016
{
    public class SecurityThroughObscurity
    {

        //i think will just make a class that does most of the logic

        public int getSumOfVaildRoomsSectorIds(string[] list)
        {
            int sum = 0;
            roomName room;
            foreach (string s in list)
            {
                room = new roomName(s);
                if (room.isValidRoom())
                {
                    sum += room.sectorId;
                }
            }

            return sum; 
        }

    }
}
