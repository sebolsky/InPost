using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InPost
{
    class Box
    {
        public Box(string name, int destination)
        {
            Name = name;
            Destination = destination;
        }

        public string Name { get; set; }
        public int Destination { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Box box &&
                   Name == box.Name &&
                   Destination == box.Destination;
        }

        public override int GetHashCode()
        {
            int hashCode = 1533375317;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Destination.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"({Name} - {Destination})";
        }
    }
}