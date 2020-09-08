using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Gui
{
    class Music
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return Title+"/"+Category;
        }
    }
}
