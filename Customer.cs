using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Customer
    {
        private string customerName;
        private  Vehicle vehicle;
        private string creditCardNo;

        public string CustomerName { get => customerName; set => customerName = value; }
        public string CreditCardNo { get => creditCardNo; set => creditCardNo = value; }
        internal Vehicle Vehicle { get => vehicle; set => vehicle = value; }
    }
}
