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

            Console.WriteLine(method.ToString());
            //Console.WriteLine() defaults to string values
            Console.WriteLine(method);

            //Parsing a string to an enum
            var methodName = "CorgiCaravan";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            Console.WriteLine(shippingMethod);
        }
    }
}