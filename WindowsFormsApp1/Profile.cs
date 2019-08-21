using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProductToAmazon
{
    class Profile
    {
        public string asin;
        public string price;
        public bool remove;
        public Profile(string asin, string price, bool remove)
        {
            this.asin = asin;
            this.remove = remove;
            this.price = price;
        }
    }
}
