using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GrowTogetherHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(GrowTogether.UserProfileService);
            Uri tcp = new Uri("net.tcp://localhost:8090/UserProfileService");
            Uri http = new Uri("http://localhost:8000/UserProfileService");

            ServiceHost host = new ServiceHost(t, tcp, http);
            host.Open();
            Console.WriteLine("Host Started @ " + DateTime.Now.ToString());
            Console.ReadLine();
            host.Close();
        }
    }
}
