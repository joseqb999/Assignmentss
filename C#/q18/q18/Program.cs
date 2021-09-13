using System;


interface Insurance
{
    void GetInsurance();
}



class TravelInsurance : Insurance
{

    // providing the body part of function
    public void GetInsurance()
    {
        Console.WriteLine("The insurance is approved");
    }

    // Main Method
    public static void Main(String[] args)
    {

        // Creating object
        TravelInsurance t = new TravelInsurance();

        // calling method
        t.GetInsurance();
    }
}
