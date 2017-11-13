using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace consoleapp.Models
{
    [DataContract(Name = "productSettings")]
    class ProductSettings
    {
        [DataMember(Name = "name")]
        public static string ProductName
        {
            get { return "Product" + DateTime.Now.Second; }
        }
        [DataMember(Name = "count")]
        public static int ProductCount
        {
            get
            {
                Random random = new Random();
                return random.Next(0, 1000);
            }
        }
    }
}
