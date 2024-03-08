using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968SwadeMockUp
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        // Virtual class to return subclass type when called
        public virtual string[] CheckPartType() { throw new NotImplementedException(); }
    }
}
