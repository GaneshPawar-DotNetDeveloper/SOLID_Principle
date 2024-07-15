using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            customer sc=new customer();
            sc.Insert();
            
        }
        public class customer
        {
            public void Insert()
            {
                try
                {
                    // here write ADO.net code to insert customer data in database.
                }
                catch (Exception ex)
                {
                    File.WriteAllText(@"E:\vikul\temp\log.txt", ex.Message);

                }

                // In this method we make three things :
                // 1. Instering coustomer data in database.
                // 2. Check If Exception Occurs.
                // 3. If Exception then log it to log.txt file.

            }
        }
        //[HandleError]
        public void InsertCopy()
        {
            // here write ADO.net code to insert customer data in database.


        }
    }

}
