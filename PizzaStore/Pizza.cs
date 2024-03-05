using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    
    internal class Pizza
    {
        #region Instance field
        string _name;
        int _price;

        #endregion

        #region Constructer
        public Pizza(string name, int price)
        {
            _name = name;
            _price = price;
        }

        #endregion

        #region Properties
        public string Name
        { get { return _name; } 
            set { _name = value; }
        }
        public int Price 
        { get { return _price; }
            set { _price = value; }
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"Pizza: {Name} - Price: {Price}";
        }
        #endregion

    }
}
