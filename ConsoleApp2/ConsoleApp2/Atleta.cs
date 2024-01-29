using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Atleta
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Categoria(int peso)
        {
            if (peso > 80)
            {
                return "peso massimo";
            }
            else
            {
                return "peso medio";
            }
        }
    }
}
