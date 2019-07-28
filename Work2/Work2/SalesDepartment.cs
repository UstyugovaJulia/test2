using System;
using System.Collections.Generic;
using System.Text;

namespace Work2
{
    public enum InvoiceType
    {
        ruble, currency
    }
    //Отдел продаж
    class SalesDepartment
    {
        public DateTime DateSale;
        public int Total;
        public decimal Sum;
        public string Invoice;
        public InvoiceType InvoiceType;
    }
}

