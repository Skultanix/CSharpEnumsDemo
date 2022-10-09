namespace EnumsDemo
{
    public enum ShippingMethod
    {
        PolarExpress = 1,
        CorgiCaravan = 2,
        CarrierPigeon = 3
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.PolarExpress;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);


        }
    }
}