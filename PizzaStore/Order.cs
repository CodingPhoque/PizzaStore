using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Order
    {
        #region Instance field
        double _taxPct;
        double _deliveryCosts;
        Pizza p;
        Customer c;

        #endregion

        #region Constructor
        public Order(Pizza pizza, Customer customer)
        {
            p = pizza;
            TaxPct = 5;
            DeliveryCosts = 35;
        }
        #endregion

        #region Properties
        double TaxPct
        {
            get { return _taxPct; }
            set { _taxPct = value; }
        }
        
        double DeliveryCosts
        { 
            get { return _deliveryCosts; }
            set { _deliveryCosts = value; }
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Pizza: {p.Name} - TaxPct: {TaxPct} + Delivery cost: {DeliveryCosts} = Total: {CalculateTotalPrice()}";
        }

        public double CalculateTotalPrice()
        {
            return p.Price * 1 + TaxPct + DeliveryCosts;
        }
        #endregion
    }


}
