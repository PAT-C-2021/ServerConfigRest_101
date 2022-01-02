using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ServiceRest_101_Raditya_Pratama_Putra;

namespace ServerConfigRest_101_Raditya_Pratama_Putra
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObjek = null;
            try
            {
                hostObjek = new ServiceHost(typeof(TI_UMY));
                hostObjek.Open();
                Console.WriteLine("Server is Ready...");
                Console.ReadLine();
                hostObjek.Close();
            }
            catch (Exception ex)
            {
                hostObjek = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
