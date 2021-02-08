using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InPost
{
    class Bundle
    {
        public List<Box> Boxes { get; set; }

        public Bundle(List<Box> boxes)
        {
            Boxes = boxes;
        }

        public override string ToString()
        {
            return string.Join(", ", Boxes);
        }
    }
}