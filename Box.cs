using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InPostBackend
{
    public class Box
    {
        public Box(int id, string name, int dest)
        {
            id = Id;
            Name = name;
            Destination = dest;

        }
        public Box()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Destination { get; set; }
    }
}
