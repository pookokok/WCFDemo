namespace ConsoleHost
{
    using BusinessService;
    using System;
    using System.ServiceModel;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var serviceHost = new ServiceHost(typeof(UserService)))
                {
                    serviceHost.Open();
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
