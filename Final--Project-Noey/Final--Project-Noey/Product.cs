using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final__Project_Noey
{
    internal class Product
    {
        public string name;
        protected string price;
        protected string color;
        protected string size;

        public string getName() { return this.name; }
        public string getPrice() { return this.price; }
        public string getColor() { return this.color; }
        public string getSize() { return this.size; }
    }
}
