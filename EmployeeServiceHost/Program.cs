using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServiceHost
{
    class Program
    {
        static void Main()
        {
            //using (ServiceHost host = new ServiceHost(typeof(EmployeeService.EmployeeService)))
            //{
                //host.Open();
                //Console.WriteLine("Host started @ " + DateTime.Now.ToString());
                //Console.ReadLine();


                ServiceHost myserviceHost = new ServiceHost(typeof(EmployeeService.EmployeeService));
                ServiceHost crossDomainserviceHost = new ServiceHost(typeof(CrossDomainService));
                myserviceHost.Open();
                crossDomainserviceHost.Open();
                Console.WriteLine("Host started @ " + DateTime.Now.ToString());
                Console.ReadLine();

           // }
        }
    }
}
