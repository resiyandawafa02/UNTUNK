using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNTUNK_Class
{
    public class Payment
    {
        private double amount;

        public void ShowReceipt()
        {

        }
    }

    public class Cash : Payment
    {
        private double moneyReceived;
    }

    public class Debt : Payment
    {
        private int debtID;
    }
}
