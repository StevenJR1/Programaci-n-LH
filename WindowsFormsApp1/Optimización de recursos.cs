using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Optimización_de_recursos
    {
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
        public string Column4 { get; set; }
        public Optimización_de_recursos(string column1, string column2, string column3, string column4)
        {
            this.Column1 = column1;
            this.Column2 = column2;
            this.Column3 = column3;
            this.Column4 = column4;
        }
    }
}
