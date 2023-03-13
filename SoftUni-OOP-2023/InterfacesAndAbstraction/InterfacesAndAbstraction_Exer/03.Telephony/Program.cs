using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries);

            string[] urls = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries);

            
            ICallable phone = default;

            foreach (var number in phoneNumbers)
            {
                if (number.Length == 7)
                {
                    phone = new StationaryPhone();
                }
                else if (number.Length == 10)
                {
                    phone = new Smartphone();
                }


                try
                {

                    Console.WriteLine(phone.Calling(number));
                    
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }

            IBrowsable modernPhone = default;

            foreach (var url in urls)
            {

                    modernPhone = new Smartphone();
                

                try
                {
                    Console.WriteLine(modernPhone.Brows(url));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); ;
                }

               
            }

            
        }
    }
}
