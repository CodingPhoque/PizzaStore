using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Customer
    {
        #region Instance field
        string _name;
        int _id;
        #endregion

        #region Constructer
        public Customer(string name, int customerid)
        {
            _name = name;
            _id = customerid;
        }
        
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Customerid 
        {
            get { return _id; }
            set { _id = value; }
        }


        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Customer: {Name} - with customer id: {Customerid}";
        }

        #endregion
    }

}
    

