using aventOfCode2016.Entitites;
using System;
using System.Collections.Generic;
using System.IO;
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

        //because i have to do this on by inspection i am just going to write all the decrypted strings out to a file and read it 

        public void decodeAllText()
        {

            string path = @"C:\Users\Sai\Documents\Visual Studio 2015\Projects\aventOfCode2016\aventOfCode2016\realInputForProblem\p4.txt";
            string[] readTextP4 = File.ReadAllLines(path);
            roomName room;

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Sai\Documents\visual studio 2015\Projects\aventOfCode2016\aventOfCode2016\testInputForProblems\output.txt", true))
            {
                file.WriteLine("Author: Sai Wentum");
                file.WriteLine("Date: {0}", DateTime.Now);
                foreach (string roomName in readTextP4)
                {
                    room = new roomName(roomName);
                    file.WriteLine(room.decode()+" {0}",room.sectorId);
                }
                file.WriteLine("\n\n");
            }

        }

    }
}
