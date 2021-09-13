using System;
interface ILoanCustomer
{
    void GetCostomerInfo();
}
interface IBankCustomer
{
    void GetCostomerInfo();
}

class customer : ILoanCustomer, IBankCustomer
{
    void ILoanCustomer.GetCostomerInfo()
    {
        Console.WriteLine("the iloan customer");
    }
    void IBankCustomer.GetCostomerInfo()
    {
        Console.WriteLine("the ibank customer");
    }

    class bank

    {
        static void Main(string[] args)
        {
            IBankCustomer bc = new customer();
            bc.GetCostomerInfo();

            ILoanCustomer lc = new customer();
            lc.GetCostomerInfo();

        }
    }
}